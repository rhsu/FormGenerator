using System;
using System.Collections.Generic;

namespace FormGenerator.Backend
{
	public class GeneralFactory
	{
		public Panel CreatePanel()
		{
			throw new NotImplementedException ("This is not implemented yet");
		}

		public Form CreateForm(IEnumerable<Panel> panels, int i)
		{
			throw new NotImplementedException ("This is not implemented yet");
		}

		public GeneralFactory ()
		{
		}
	}
}

