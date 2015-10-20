using System;
using System.IO;
using GTFS;
using GTFS.IO;

namespace Demo.GtfsTest.ConsoleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			RunExample();
		}

		private static void RunExample()
		{
			// create the reader.
			var reader = new GTFSReader<GTFSFeed>(strict:false);

			// execute the reader.
			GTFSFeed feed = reader.Read(new GTFSDirectorySource(new DirectoryInfo("feeds/lirr")));
			Console.WriteLine(feed);

			feed = reader.Read(new GTFSDirectorySource(new DirectoryInfo("feeds/subway")));
			Console.WriteLine(feed);

			Console.Read();
		}
	}
}
