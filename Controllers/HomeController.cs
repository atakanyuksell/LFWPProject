using Microsoft.AspNetCore.Mvc;
using LawFirmWebPage.Models;
using LawFirmWebPage.ServiceContracts.DTO;

namespace LawFirmWebPage.Controllers
{

	public class HomeController : Controller
	{

		//Get Home/Login
		[Route("/")]
		[Route("[action]")]
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[Route("[action]")]
		public IActionResult Login(LoginPerson person)
		{
			if (!ModelState.IsValid)
			{
				// Eğer model doğrulama hatalıysa tekrar Index view'ına döner
				return RedirectToAction("Login", "Home");
			}
			if (person.Name == "abdhanabd" && person.Password == "081123")
			{
				// Giriş başarılıysa Login view'ına yönlendir
				return View("Page"); // Page view'ını döndür

			}

			return View();
		}

	}
}
