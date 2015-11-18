using System;
using System.Collections.Generic;

namespace FormGenerator
{
	public class Form
	{
		public IEnumerable<Panel> Panels { get; }
		public int Id { get; }

		internal Form (IEnumerable<Panel> panels, int id)
		{
			this.Panels = panels;
			this.Id = id;
		}
	}
}

