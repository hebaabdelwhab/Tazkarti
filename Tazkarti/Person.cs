using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tazkarti
{
    public class Person
    {
        public string username;
        public string password;
        public bool isAdmin;
        public bool hasSSN;
        public bool hasCredit;
        public bool hasMobile;

        public Person(string username, string password, bool isAdmin, bool hasSSN, bool hasCredit, bool hasMobile)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
            this.hasSSN = hasSSN;
            this.hasCredit = hasCredit;
            this.hasMobile = hasMobile;
        }
    }
}
