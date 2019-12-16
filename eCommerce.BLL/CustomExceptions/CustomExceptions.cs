using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.CustomExceptions
{
    public class MailCannotBeTheSame : Exception
    {
        string _username;
        public override string Message
        {
            get
            {
                return _username + " cannot be a member again with the same name !";
            }
        }

        public MailCannotBeTheSame(string username)
        {
            _username = username;
        }
    }

    public class UsernameNotFound : Exception
    {
        public override string Message
        {
            get
            {
                return "This username not found !";
            }
        }
    }

    public class WrongPassword : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter your correct password !";
            }
        }
    }
}
