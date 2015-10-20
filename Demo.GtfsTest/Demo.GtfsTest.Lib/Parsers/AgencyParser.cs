using System.Collections.Generic;
using System.IO;
using CsvHelper;
using Demo.GtfsTest.Lib.Core;

namespace Demo.GtfsTest.Lib.Parsers
{
	public class AgencyParser
	{
		public IEnumerable<Agency> Parse(TextReader textReader)
		{
			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<AgencyMap>();
			csv.Configuration.WillThrowOnMissingField = false;
			var records = csv.GetRecords<Agency>();

			return records;
		}
	}
}