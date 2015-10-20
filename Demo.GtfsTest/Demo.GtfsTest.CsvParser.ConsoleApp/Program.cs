using System;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Demo.GtfsTest.CsvParser.ConsoleApp
{
	public class Program
	{
		/// <summary>
		/// http://joshclose.github.io/CsvHelper/
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			const string path = "feeds/subway/agency.txt";
			using (TextReader textReader = File.OpenText(path))
			{
				var csv = new CsvReader(textReader);
				csv.Configuration.RegisterClassMap<AgencyMap>();
				csv.Configuration.WillThrowOnMissingField = false;
				var records = csv.GetRecords<Agency>().ToList();

				//while (csv.Read())
				//{
				//	var record = csv.GetRecord<Agency>();
				//	Console.WriteLine(record);
				//}
			}

			Console.Read();
		}
	}
}
