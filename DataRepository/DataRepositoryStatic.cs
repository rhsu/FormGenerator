using System;
using System.Collections.Generic;

namespace FormGenerator
{
	/// <summary>
	/// A DataRepository that always returns the same static data and behavior
	/// Contains no data store (sql)
	/// </summary>
	public class DataRepositoryStatic : IDataRepository
	{
		private Form _myform;
		private IEnumerable<Form> _myForms;

		public Form GetFormById(int formId)
		{
			return null;
		}

		public IEnumerable<Form> GetAllForms()
		{
			return null;
		}

		public DataRepositoryStatic ()
		{
			_myform = new Form ();
		}
	}
}

