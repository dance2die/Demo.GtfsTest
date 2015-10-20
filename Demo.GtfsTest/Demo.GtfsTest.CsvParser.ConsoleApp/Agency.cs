using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace Demo.GtfsTest.CsvParser.ConsoleApp
{
	public class FileNameAttribute : Attribute
	{
		/// <summary>
		/// Creates a new FileNameAttribute with a given file name.
		/// </summary>
		/// <param name="fileName"></param>
		public FileNameAttribute(string fileName)
		{
			this.FileName = fileName;
		}

		/// <summary>
		/// Gets the filename.
		/// </summary>
		public string FileName { get; private set; }
	}

	public class FieldNameAttribute : Attribute
	{
		/// <summary>
		/// Creates a new FieldNameAttribute with a given field name.
		/// </summary>
		/// <param name="fieldName"></param>
		public FieldNameAttribute(string fieldName)
		{
			this.FieldName = fieldName;
		}

		/// <summary>
		/// Gets the fieldname.
		/// </summary>
		public string FieldName { get; private set; }
	}

	public class RequiredAttribute : Attribute
	{
	}

	/// <summary>
	/// Represents a transit agency.
	/// </summary>
	[FileName("agency")]
	public class Agency
	{
		[Required]
		[FieldName("agency_id")]
		public string Id { get; set; }

		[Required]
		[FieldName("agency_name")]
		public string Name { get; set; }

		[Required]
		[FieldName("agency_url")]
		public string URL { get; set; }

		[Required]
		[FieldName("agency_timezone")]
		public string Timezone { get; set; }

		[FieldName("agency_lang")]
		public string LanguageCode { get; set; }

		[FieldName("agency_phone")]
		public string Phone { get; set; }

		[FieldName("agency_fare_url")]
		public string FareURL { get; set; }

		/// <summary>
		/// Returns a description of this trip.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("[{0}] {1}", this.Id, this.Name);
		}
	}

	public class AgencyMap : CsvClassMap<Agency>
	{
		public AgencyMap()
		{
			Map(e => e.Id).Name("agency_id");
			Map(e => e.Name).Name("agency_name");
			Map(e => e.URL).Name("agency_url");
			Map(e => e.Timezone).Name("agency_timezone");
			Map(e => e.LanguageCode).Name("agency_lang");
			Map(e => e.Phone).Name("agency_phone");
			Map(e => e.FareURL).Name("agency_fare_url");
		}
	}

}
