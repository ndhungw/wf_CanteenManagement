using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_CanteenManagement.DTO
{
    public class Session
    {
        private string username;
        private string password;
        private string displayName;

        public Session(string username, string password, string displayName) {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
