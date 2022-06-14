﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	internal class EmployeeRecordAdder : IEmployeeRecordAdder
	{
		void IEmployeeRecordAdder.AddEmployeeRecord(IEmployee employee, IDictionary<string, IEmployee> dico)
		{
			string id = employee.GetEID();
			string name = employee.GetName();
			dico.Add("id", IEmployee);

		}
	}
}
