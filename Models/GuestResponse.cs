using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse  //  Guest - гости  Response - отклик, ответ
    {
        [Required(ErrorMessage = "Please enter your name")]
        /*Requered - Specifies that a data field value is required - 
          Требуемый - Указывает, что требуется значение поля данных */
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a VALID email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("\\+.+", ErrorMessage = "Please enter a VALID phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; } 
    }
}
