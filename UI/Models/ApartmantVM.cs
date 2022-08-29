using System;
using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class ApartmantVM
    {
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string Address { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string Postcode { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string City { get; set; }
        [MaxLength(50, ErrorMessage = "Lütfen 50 karakterden fazla değer girmeyiniz.")]
        [Required(ErrorMessage = "Lütfen Boş bırakmayınız.")]
        public string State { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Confirmed { get; set; }
    }
}
