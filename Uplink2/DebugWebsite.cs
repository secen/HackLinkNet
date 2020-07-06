using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uplink2 {
    public class DebugWebsite :  Website {
        public DebugWebsite() {
            name = "Debug Website";
            users = new List<User>();
            User usr = new User {
                name = "debug",
                password = "pass",
                privileges = { Privilege.Admin }
            };
            users.Add(usr);
            this.loginScreen = new WebsiteLoginScreen(this);
        }
        override public bool tryLogin(User usr) {
            if (usr.name== users[0].name && usr.password == users[0].password) {
                Debug.WriteLine("Succesfull debug mode initiated");
                return true;
            }
            return false;
        }
    }
}
