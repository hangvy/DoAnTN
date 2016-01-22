using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        public string id { get; set; }
        public string loginName { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public Account() { }
        public Account(string loginName, string password, string role)
        {
            this.loginName = loginName;
            this.password = password;
            this.role = role;
        }
    }
}
