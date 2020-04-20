using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tazkarti
{
    class Constraints
    {
        public bool checkSSN(string ssn)
        {
            if (Regex.IsMatch(ssn, "\\A[0-9]{14}\\z"))
                return true;
            return false;
        }
        public bool checkEmail(string email)
        {
            var addr = new System.Net.Mail.MailAddress(email);
            if (email != addr.Address)
                return false;
            return true;
        }
        public bool checkCredit(string credit)
        {
            if (Regex.IsMatch(credit, "\\A[0-9]{11}\\z"))
                return true;
            return false;
        }
        public bool checkMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, "\\A[0-9]{11}\\z") && mobile[0] == '0' || mobile[1] == '1')
                return true;
            return false;
        }
    }
}
