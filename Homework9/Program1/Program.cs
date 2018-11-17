using System;
using System.Collections;
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
		private const ushort PageLimit = 10;
		private Hashtable _urls;
		private int _count;
		public static void Main(string[] args)
		{
			new Program().Run(false);
			new Program().Run(true);
			
		}

		void Run(bool parallel = false)
		{
			Program program = new Program();
			program._urls = new Hashtable();
			program._count = 0;
			string startURL = "https://www.cnblogs.com/dstang2000/";
			program._urls.Add(startURL, false);
			
			Stopwatch stopwatch = new Stopwatch();
			Thread thread = new Thread(() => program.Crawl(parallel));

			Console.WriteLine("Start crawling.");
			stopwatch.Start();
			thread.Start();
			thread.Join();
			stopwatch.Stop();
			Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds + ".");
		}

		private void Crawl(bool parallel = false)
		{
			string html = "";
			do
			{
				string current = null;
				foreach (DictionaryEntry dictionaryEntry in _urls)
				{
					if ((bool) dictionaryEntry.Value) continue;
					current = dictionaryEntry.Key as string;
					break;
				}

				if (current == null || _count > PageLimit) return;
				Console.WriteLine("Crawling: " + current);
				html = Download(current);

				_urls[current] = true;
				++_count;

				/*if (!parallel)*/
				Parse(html);

				if (parallel)
				{
					/*Parse(html);*/
					var thread = new Thread(() => this.Crawl(true));
					thread.Start();
					thread.Join();
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
				if (_urls[strRef] == null) _urls[strRef] = false;
			}
		}

		private string Download(string url)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string html = webClient.DownloadString(url);
				string fileName = _count.ToString();
				File.WriteAllText(fileName, html, Encoding.UTF8);
				return html;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return "";
			}
		}
	}
}
