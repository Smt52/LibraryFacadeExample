using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeExample
{
    public class UserNameCheck
    {
        private string _userName = "Lquuu";

        public string GetUserName()
        {
            return _userName;
        }

        public bool CheckUserName(string userName)
        {
            if (userName == GetUserName())
            {
                return true;
            }
            return false;
        }
    }
}