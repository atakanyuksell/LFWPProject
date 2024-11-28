using System.ComponentModel.DataAnnotations;

namespace LawFirmWebPage.Models
{
	public class LoginPerson
	{
		[Required(ErrorMessage = "İsim alanı boş olamaz.")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Şifre alanı boş olamaz.")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
	}
}
