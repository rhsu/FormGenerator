using FormGenerator.Models;
using System.Web.Mvc;

namespace FormGenerator.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index ()
		{
			var pageViewModel = new IndexViewModel ();

			return View (pageViewModel);
		}

		[HttpPost]
		public ActionResult Index (IndexViewModel pageViewModel)
		{
			// return View ("Display", pageViewModel);
			return RedirectToAction("Display", "Home", pageViewModel);
		}

		public ActionResult Display(IndexViewModel vmIndexPage)
		{
			DisplayViewModel pageViewModel = new DisplayViewModel (vmIndexPage);

			return View (pageViewModel);
		}
	}
}

