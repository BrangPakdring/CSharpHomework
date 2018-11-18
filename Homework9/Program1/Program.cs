using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Program1
{
	internal class Program
	{
		private const ushort PageLimit = 100;
		private const uint TimeLimit = 20;
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

		public static void Main(string[] args)
		{
			Console.WriteLine("Test using single thread:");
			new Program().Run(false);
			Console.WriteLine();
			Console.WriteLine("Test using optimized thread:");
			new Program().Run(true);
			
		}

		void Run(bool parallel = false)
		{
			Program program = new Program();
			
			Stopwatch stopwatch = new Stopwatch();
			Thread thread = new Thread(() => program.Crawl(parallel));
			_threads.Add(thread);

			Console.WriteLine("Start crawling.");
			stopwatch.Start();
			thread.Start();
//			thread.Join();
			int cnt = 0;
			while (program._count < PageLimit)
			{
				Console.WriteLine("Waiting... " + cnt + "s.");
				++cnt;
				if (cnt > TimeLimit)
				{
					Console.WriteLine("Time limit exceeded.");
					foreach (var thread1 in _threads)
					{
						thread1.Abort();
					}

					break;
				}
				Thread.Sleep(1000);
			}
			
			stopwatch.Stop();
			Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds + ".");
		}

		private void Crawl(bool parallel = false)
		{
			string html = "";
			do
			{
				string current = null;
				lock (this)
				{
					foreach (DictionaryEntry dictionaryEntry in _urls)
					{
						if ((bool) dictionaryEntry.Value) continue;
						current = dictionaryEntry.Key as string;
						_urls[current] = true;
						++_count;
						break;
					}
				}

				if (current == null || _count >= PageLimit) return;
				Console.WriteLine("Crawling #" + _count + ": " + current);
				html = Download(current, _count);

				/*if (!parallel)*/
				Parse(html);

				if (parallel)
				{
					/*Parse(html);*/
//					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Crawl), true))
					var thread = new Thread(() => this.Crawl(true));
					_threads.Add(thread);
					thread.Start();
//					thread.Join();
				}
			} while (true);
		}

		private void Parse(string html)
		{
			string strRef = @"(href|HREF)[]*=[]*[""']http[s]?://[^""']+[""']>";
			MatchCollection collection = new Regex(strRef).Matches(html);
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
