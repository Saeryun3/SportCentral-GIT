using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic.Helper
{
   public class UserConvertor
   {
        public static UserDTO ConvertoUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.UserID = user.UserID;
            userDTO.Username = user.Username;
            userDTO.Password = user.Password;
            userDTO.Email = user.Email;
            userDTO.Rank = (int)user.Rank;
            return userDTO;
        }
   }
}
