using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class User 
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Rank Rank{ get; set; }

        public User (UserDTO userDTO)
        {
            this.UserID = userDTO.UserID;
            this.Username = userDTO.Username;
            this.Email = userDTO.Email;
            this.Password = userDTO.Password;
            this.Rank = (Rank)userDTO.Rank;
        }
    }
}
