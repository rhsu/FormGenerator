using FormGenerator.Models;
using System.Web.Mvc;

namespace FormGenerator.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var pageViewModel = new IndexViewModel ();

			return View ();
		}
	}
}

