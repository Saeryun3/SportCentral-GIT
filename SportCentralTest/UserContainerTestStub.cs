using SportCentralInterface;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralTest
{
    public class UserContainerTestStub : IUser
    {
        public List<UserDTO> users = new List<UserDTO>();

        public UserContainerTestStub()
        {
            UserDTO user1 = new UserDTO()
            {
                UserID = 1,
                Username = "PlaceName",
                Email = "Placeholder@gmail.com",
                Password = "PlacePassword",
                Rank = (int)Rank.User                
            };

            UserDTO user2 = new UserDTO()
            {
                UserID = 2,
                Username = "PlaceName2",
                Email = "Place@hotmail.com",
                Password = "PlacePassword2",
                Rank = (int)Rank.User
            };

            users.Add(user1);
            users.Add(user2);
        }

        public bool UserExist(UserDTO userDTO)
        {
            foreach (UserDTO user  in users)
            {
                if (user.Email == userDTO.Email)                
                    return true;                    
            }
            return false;
        }

        public bool CreateUser(UserDTO user)
        {
            users.Add(user);
            return true;
        }

        public UserDTO GetUserByEmailAndPassword(string Email, string Password)
        {
            foreach (UserDTO userDTO in users)
            {
                if (userDTO.Email == userDTO.Email && userDTO.Password == userDTO.Password)
                {
                    return userDTO;
                }
            }
            return null;
        }

        public bool UserExistsByEmailAndPassword(string Email, string Password)
        {
            foreach (UserDTO user in users)
            {
                if (user.Email == Email && user.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetUserByID(int ID)
        {
            foreach (UserDTO user in users)
            {
                if (user.UserID == ID)
                {
                    return user.Username;
                }
            }
            return null;
        }
    }
}
