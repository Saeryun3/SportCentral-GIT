using SportCentralInterface;
using SportCentralLibLogic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class UserContainer
    {
        private IUser User;
        public UserContainer(IUser iuser)
        {
            this.User = iuser;
        }
        public bool CreateUser(User user)
        {
            if (!CheckIfUserExist(user))
            {
                UserDTO userDTO = UserConvertor.ConvertoUserDTO(user);
                User.CreateUser(userDTO);
                return true;
            }
            return false;
        }
        public bool CheckIfUserExist(User user)
        {
            UserDTO userDTO = UserConvertor.ConvertoUserDTO(user);
            return User.CheckIfUserExist(userDTO);
        }

        public User GetUserByEmailAndPassword(string Email, string Password)
        {
            return new User (User.GetUserByEmailAndPassword(Email, Password));
        }
    }
}
