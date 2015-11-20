using System;
using System.Collections.Generic;

namespace FormGenerator.Backend
{
	public interface IDataRepository
	{
		/// <summary>
		/// Gets a specific form by Id
		/// </summary>
		/// <returns>The form with the specific identifier</returns>
		/// <param name="formId">Form identifier.</param>
		Form GetFormById(int formId);

		/// <summary>
		/// Gets all forms.
		/// </summary>
		/// <returns>All Forms in the data store</returns>
		IEnumerable<Form> GetAllForms();
	}
}

