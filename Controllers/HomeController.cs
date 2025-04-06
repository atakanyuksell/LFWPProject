using Microsoft.AspNetCore.Mvc;
using LawFirmWebPage.Models;
using LawFirmWebPage.ServiceContracts.DTO;

namespace LawFirmWebPage.Controllers
{

	public class HomeController : Controller
	{

		[Route("/")]
		public IActionResult Index()
		{
            return View();
        }

        [Route("/About")]
		public IActionResult About()
		{
            return View();
        }

        [Route("/Contact")]
		public IActionResult Contact()
		{
			return View();
		}

        [Route("/Services")]
		public IActionResult Services()
		{
            return View();
        }

        [Route("/Team")]
		public IActionResult Team()
		{
            return View();
        }
    }
}
