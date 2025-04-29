using System;
using System.ComponentModel.DataAnnotations;

namespace AspWebUygulama.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Ad ve soyadınızı girmek zorunludur!")]
        public string FullName { get; set; } = null!;
        [Required(ErrorMessage = "Telefonunuzu girmek zorunludur!")]
        [Phone][RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Geçerli bir telefon numarası girin!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber {  get; set; } = null!;
        [Required(ErrorMessage = "E postanızı girmek zorunludur!")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Departman adı girmek zorunludur!")]
        public string Department { get; set; } = null!;
        [Required(ErrorMessage = "Mesaj girmek zorunludur!")]
        public string Message { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
