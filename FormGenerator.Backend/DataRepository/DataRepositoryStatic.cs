using System;
using System.Collections.Generic;

namespace FormGenerator.Backend
{
	/// <summary>
	/// A DataRepository that always returns the same static data and behavior
	/// Contains no data store (sql)
	/// </summary>
	public class DataRepositoryStatic : IDataRepository
	{
		private GeneralFactory _factory;

		//private Form _myform;
		//private IEnumerable<Form> _myForms;

		public Form GetFormById(int formId)
		{
			throw new NotImplementedException ("This method is not implemented");
		}

		/// <summary>
		/// This static method will return 1 form which contains 3 panels
		/// </summary>
		/// <returns>All Forms in the data store</returns>
		public IEnumerable<Form> GetAllForms()
		{
			List<Panel> panels = new List<Panel> ();

			for (var i = 0; i < 3; i++) 
			{
				var panel = _factory.CreatePanel ();
				panels.Add (panel);
			}

			List<Form> returnVal = new List<Form> ();

			var form = _factory.CreateForm (panels, 1);
			returnVal.Add (form);

			return returnVal;
		}

		public DataRepositoryStatic ()
		{
			_factory = new GeneralFactory ();
			//_myform = new Form ();
		}
	}
}

