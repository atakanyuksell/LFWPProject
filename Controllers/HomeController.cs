using Microsoft.AspNetCore.Mvc;
using LawFirmWebPage.Models;
using LawFirmWebPage.ServiceContracts.DTO;
using LawFirmWebPage.ServiceContracts;
using LawFirmWebPage.ServiceContracts.DTO;
using LawFirmWebPage.Models;
using LawFirmWebPage.Entities;
using Microsoft.EntityFrameworkCore;
using LawFirmWebPage.Data;

namespace LawFirmWebPage.Controllers
{

    [Route("[controller]")]
    public class HomeController : Controller
	{

        private readonly IContactService _contactService;
        private readonly ApplicationDbContext _context;


        
        /// <summary>
        /// Importing variables by using dependency injection
        /// </summary>
        /// <param name="contactService"></param>
        /// <param name="context"></param>
        public HomeController(IContactService contactService,ApplicationDbContext context)
        {
            _contactService = contactService;
            _context = context;
        }


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

        [HttpGet("/Contact")]
        public IActionResult Contact()
		{
            return View(new ContactFormModel());
		}

        [HttpPost("/Contact")]
        public async Task<IActionResult> Contact(ContactFormModel request)
        {
            if (ModelState.IsValid)
            {
                // ContactFormModel'i ContactMessage'a dönüştür
                ContactMessage contactMessage = new ContactMessage
                {
                    Name = request.Name,
                    Surname = request.Surname,
                    Email = request.Email,
                    Message = request.Message,
                    SentDate = DateTime.Now
                };

                _context.ContactMessages.Add(contactMessage);
                await _context.SaveChangesAsync();

                // Başarı mesajı gösterilebilir
                TempData["Success"] = "Mesajınız iletildi!";
                return RedirectToAction("Contact");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Mesaj gönderilirken bir hata oluştu.");
                return View(request);
            }
        }

    }
}
