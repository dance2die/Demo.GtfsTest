﻿using System.ComponentModel.DataAnnotations;

namespace Demo.GtfsTest.Lib.Core
{
	/// <remarks>
	/// https://github.com/OsmSharp/GTFS/blob/2b8f3201e65ab5dd31cdacd82b4b05d34c288204/GTFS/Entities/Agency.cs
	/// </remarks>
	public class Agency
	{
		public string Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Url { get; set; }

		[Required]
		public string Timezone { get; set; }

		public string Language { get; set; }

		public string Phone { get; set; }

		public string FareUrl { get; set; }

		/// <summary>
		/// Credit <see cref="https://github.com/OsmSharp/GTFS/blob/2b8f3201e65ab5dd31cdacd82b4b05d34c288204/GTFS/Entities/Agency.cs"/>
		/// </summary>
		/// 
		public override string ToString()
		{
			return string.Format("[{0}] {1}", this.Id, this.Name);
		}
	}
}
