using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Program1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Test using single thread:");
			new Program().Run(false);
			Console.WriteLine();
			Console.WriteLine("Test using optimized thread:");
			new Program().Run(true);
		}
		
		/**
		 * Crawling speed depends on network environment and its stability, so
		 * I am not sure whether the optimization itself does the acceleration.
		 * (Sometimes the parallel slows down the process.) 
		 * 
		 * Also too many threads would be harmful to machine.
		 * 
		 * Though there might be any better optimization, this is from the many
		 * tries the best one being tested yet in my own machine, with the
		 * result exported to two text files output1.txt & output2.txt.
		 */

		private const uint ThreadLimit = 128;
		
		private const ushort PageLimit = 500;

		private const uint TimeLimit = 15;

		private Hashtable _urls;

		private int _count;

		private string startURL = "https://blog.csdn.net/lttree/article/category/2397059";

		private List<Thread> _threads;

		public Program()
		{
			_urls = Hashtable.Synchronized(new Hashtable());
			_count = 0;
			_urls.Add(startURL, false);
			_threads = new List<Thread>();
		}

		void Run(bool parallel)
		{
			Program program = new Program();

			Stopwatch stopwatch = new Stopwatch();

			var lim = parallel == false ? 1
				: Math.Min(PageLimit, ThreadLimit);

			Console.WriteLine("Start crawling.");
			stopwatch.Start();
			for (var i = 0; i < lim; ++i)
			{
				Thread thread = new Thread(() => program.Crawl(parallel)) {Name = i.ToString()};
				_threads.Add(thread);
				thread.Start();
			}

//			thread.Join();
			int cnt = 0;
			while (program._count < PageLimit)
			{
				Console.WriteLine("Waiting... " + cnt + "s.");
				++cnt;
				if (cnt > TimeLimit)
				{
					Console.WriteLine("Time limit exceeded.");
					lock (this)
					{
						foreach (var thread1 in _threads)
						{
							thread1.Abort();
						}
					}

					break;
				}

				Thread.Sleep(1000);
			}

			stopwatch.Stop();
			Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds + ".");
		}

		private void Crawl(bool parallel)
		{
			string html = "";
			while (true)
			{
				string current = null;
				int count;
				try
				{
					foreach (DictionaryEntry dictionaryEntry in _urls)
					{
						if ((bool) dictionaryEntry.Value) continue;
						current = dictionaryEntry.Key as string;
						if (current == null) continue;
						break;
					}
				}
				catch (InvalidOperationException e)
				{
					continue;
				}

				lock (this)
				{
					if (current == null) return;
					_urls[current] = true;
					++_count;
					if (_count >= PageLimit) return;
					count = _count;
				}

				Console.WriteLine("Crawling #" + count + ": " + current);
				html = Download(current, count);
				Parse(html, parallel);
			}
		}

		private void Parse(string html, bool parallel = false)
		{
			string strRef = @"(href|HREF)[]*=[]*[""']http[s]?://[^""']+[""']>";
			MatchCollection collection = new Regex(strRef).Matches(html);

			if (parallel)
				Parallel.For(0, collection.Count, i =>
				{
					var match = collection[i];
					var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '#', ' ', '>');
					if (url.Length <= 0 || !url.StartsWith("http")) return;
					if (_urls[url] == null) _urls[url] = false;
				});
			else
				foreach (Match match in collection)
				{
					strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '#', ' ', '>');
					if (strRef.Length == 0) continue;
					if (strRef.StartsWith("https://") == false) continue;
					lock (this)
					{
						if (_urls[strRef] == null) _urls[strRef] = false;
					}
				}
		}

		private string Download(string url, int index)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string html = webClient.DownloadString(url);
				string fileName = index + ".html";
				File.WriteAllText(fileName, html, Encoding.UTF8);
				return html;
			}
			catch (Exception e)
			{
//				Console.WriteLine(e);
				return "";
			}
		}
	}
}
