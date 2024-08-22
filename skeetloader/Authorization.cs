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

            // Input Validation
            if(string.IsNullOrWhiteSpace(this.username) && string.IsNullOrWhiteSpace(this.password))
            {
                return false;
            }

            return true;
        }

        public string GetUsername()
        {
            return username;
        }

        public int GetSubscription()
        {
            if (instance == null)
                return 0;

            return 30;
        }
    }
}
