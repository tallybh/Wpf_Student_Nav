using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Student_Nav
{
    public static class Session
    {
        public static User User { get; set; }

        public static bool IsAdmin { get; set; }
    }
}
