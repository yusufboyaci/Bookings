using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class UserVM
    {
        [MaxLength(50, ErrorMessage ="Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage ="Lütfen Boş bırakmayınız.")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string Surname { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string PhoneNumber { get; set; }
        public bool Confirmed { get; set; }
    }
}
