using System;
using System.ComponentModel;

namespace FormGenerator.Models
{
	public class IndexViewModel
	{
		[DisplayName("Enter the name of the form: ")]
		public string FormName { get; set; }

		[DisplayName("Enter the number of panels for this form: ")]
		public int NumberOfPanels { get; set; }

		public IndexViewModel ()
		{
		}
	}
}

