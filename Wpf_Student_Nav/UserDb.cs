using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Student_Nav
{
    internal class UserDb
    {
        public User CheckByNameAndPass(string username, string password)
        {
            return new User { FName = "Moshe", IsAdmin = true, LName = "Cohen", UserName = username, Password = password };
        }
    }
}
