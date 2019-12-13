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
        private int iDNhanVien;

        public Session(string username, string password, string displayName, int iDNhanVien) {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
            this.iDNhanVien = iDNhanVien;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
    }
}
