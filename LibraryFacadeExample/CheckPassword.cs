using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacadeExample
{
    public class CheckPassword
    {
        private int _password = 1234;

        public int GetPassword()
        {
            return _password;
        }

        public bool PasswordCheck(int password)
        {
            if (password == GetPassword())
            {
                return true;
            }
            return false;
        }
    }
}