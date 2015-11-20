using System;
using System.Collections.Generic;

namespace FormGenerator.Models
{
	public class DisplayViewModel
	{
		public ICollection<PanelViewModel> Panels { get; }
		public string FormName { get; set; }

		public DisplayViewModel (IndexViewModel indexPage)
		{
			this.Panels = new List<PanelViewModel> ();

			for (var i = 0; i < indexPage.NumberOfPanels; i++) 
			{
				Panels.Add (new PanelViewModel ());
			}
		}
	}
}

