using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Models
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        [Required]
        [DisplayName("Gebruikersnaam")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DisplayName("Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }  
        
        public Rank rank { get; set; }
        public UserViewModel(string name)
        {
            this.Username = name;
        }
        public UserViewModel()
        {

        }
    }
}
