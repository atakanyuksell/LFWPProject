using LawFirmWebPage.Models;
using LawFirmWebPage.ServiceContracts.DTO;

namespace LawFirmWebPage.ServiceContracts
{
    public interface IContactService
    {
        Task<bool> SendEmailAsync(ContactFormModel request);

    }
}
