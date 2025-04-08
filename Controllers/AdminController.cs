using LawFirmWebPage.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LawFirmWebPage.Entities;

namespace LawFirmWebPage.Controllers
{
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public AdminController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpGet("login")]
        public IActionResult Login() => View();

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            var adminUser = _configuration["Admin:Username"];
            var adminPass = _configuration["Admin:Password"];

            if (username == adminUser && password == adminPass)
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("Panel","Admin");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı!";
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsAdmin");
            return RedirectToAction("Login");
        }

        [HttpGet("Panel")]
        public IActionResult Panel()
        {
            // Admin girişinin doğruluğunu kontrol et
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToAction("Login");
            }

            List<ContactMessage> messages = _context.ContactMessages.OrderByDescending(m => m.SentDate).ToList();

            return View(messages);

            // Admin paneline yönlendirme işlemleri burada yapılabilir.
            return View();
        }
    }
}
