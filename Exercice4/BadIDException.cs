using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class BadIDException : Exception
	{
		string error;

		public BadIDException(Exception error) { 
			this.error = error.Message;
		}

	}
}
