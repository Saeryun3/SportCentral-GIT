using SportCentral.Models;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Helper
{
    public class UserConvertorr
    {
        public static User ConvertToUser(UserViewModel uvm)
        {
            User user = new User();
            user.UserID = uvm.UserID;
            user.Username = uvm.Username;
            user.Email = uvm.Email;
            user.Password = uvm.Password;
            user.Rank = uvm.rank;
            return user;
        }
    }
}
