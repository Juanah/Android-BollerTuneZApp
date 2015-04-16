using System;
using SQLite;
namespace BTZ.App.Data
{
	[Table("LocalUser")]
	public class LocalUser
	{
		public LocalUser ()
		{
		}

		public string Name{ get; set; }

		public string Password{ get; set; }
	}
}

