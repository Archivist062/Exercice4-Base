﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	internal class CommandLinePrinter : IPrinter
	{
		public string printLine;
		void IPrinter.PrintLine(string str)
		{
			printLine = str;
		}
		public CommandLinePrinter()
        {

        }
	}
}
