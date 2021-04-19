using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DutchTreat.models
{
    public class ContactModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required] 
        [MaxLength(250)]
        public string Message { get; set; }
    }
}