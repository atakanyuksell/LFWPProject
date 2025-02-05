using Microsoft.AspNetCore.Mvc;
using LawFirmWebPage.Models;
using LawFirmWebPage.ServiceContracts.DTO;

namespace LawFirmWebPage.Controllers
{

	public class HomeController : Controller
	{
		[Route("/")]
        public IActionResult page()
		{
			return View();
        }

    }
}
