using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagerApp
{
    public class Validate
    {
        public bool checkNumber(string number) {
            Regex regex = new Regex(@"^[0-9]");
            if (regex.IsMatch(number))
            {
                return true;
            }
            return false;
        }

        public bool checkString(string name)
        {
            Regex regex = new Regex(@"^[A-Z][a-z][1-9]");
            if (regex.IsMatch(name))
            {
                return true;
            }
            return false;
        }
    }
}
