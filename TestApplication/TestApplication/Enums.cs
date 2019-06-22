using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
	public class Enums
	{
		public enum StatusCodes
		{
			initial = 0,
			fileCreated = 1,
			waiting = 2,
			failure = 3,
			success = 4
		}

		public enum FileType
		{
			add_user = 0,
			add_account = 1,
			assign_account = 2
		}
	}
}
