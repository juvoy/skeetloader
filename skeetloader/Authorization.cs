using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skeetloader
{
    class Authorization
    {
        public Authorization instance;

        private string username, password;

        public Authorization(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // Add your own user Authorization with this
        public bool Login()
        {
            instance = this;
            return true;
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
