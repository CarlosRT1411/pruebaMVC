using System.ComponentModel.DataAnnotations;

namespace PrimerMVC.Models.ViewModels
{
	public class ContactoViewModel
	{
		[Required]
		[Display(Name = "nombre")]
		public string nombre { get; set; }
		[Required]
		[Display(Name = "telefono")]
		public string telefono { get; set; }
		[Required]
		[Display(Name = "correo electronico")]
		public string correo { get; set; }
	}
}
