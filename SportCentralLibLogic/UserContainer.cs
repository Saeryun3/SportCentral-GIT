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
            if (!UserExist(user))
            {
                UserDTO userDTO = UserConvertor.ConvertoUserDTO(user);
                User.CreateUser(userDTO);
                return true;
            }
            return false;
        }
        public bool UserExist(User user)
        {
            UserDTO userDTO = UserConvertor.ConvertoUserDTO(user);
            return User.UserExist(userDTO);
        }

        public bool UserExistsByEmailAndPassword(User user)
        {
            return User.UserExistsByEmailAndPassword(user.Email, user.Password);
        }

        public User GetUser(User user)
        {
            return new User(User.GetUserByEmailAndPassword(user.Email, user.Password));
        }
        public string GetUserByID(int ID)
        {
            return User.GetUserByID(ID);
        }
    }
}
