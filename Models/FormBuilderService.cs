using System;
using System.Collections.Generic;

namespace FormGenerator
{
	public class FormBuilderService
	{
		public Form AddPanelToForm(Form currentForm, Panel newPanel)
		{
			List<Panel> newPanels = new List<Panel> ();
			newPanels.AddRange (currentForm.Panels);
			newPanels.Add (newPanel);

			//return new Form (newPanels);
			return null;
		}

		public FormBuilderService ()
		{
			
		}
	}
}

