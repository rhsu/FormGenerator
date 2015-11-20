using System;
using System.Collections.Generic;

namespace FormGenerator
{
	public class FormViewModel
	{
		public IEnumerable<PanelViewModel> Panels { get; }
		public string FormName { get; }
		public int FormId { get; }

		public FormViewModel ()
		{
			Panels = new List<PanelViewModel> ();
		}
	}
}

