using SportCentralInterface;
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

        public bool CreateUser()
        {
            return null;
        }
    }
}
