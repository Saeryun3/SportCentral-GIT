using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
   public  interface IUser
   {
        bool CreateUser(UserDTO user);
        bool UserExist(UserDTO userDTO);
        UserDTO GetUserByEmailAndPassword(string Email, string Password);
        bool UserExistsByEmailAndPassword(string Email, string Password);
        string GetUserByID(int ID);
   }
}
