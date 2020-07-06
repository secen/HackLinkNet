using System.Collections.Generic;

namespace Uplink2 {
    public enum Privilege {
        ModifyFiles,
        ViewLogs,
        Admin,
        ViewLinks,
        None,
        Forums,
    }
    public class User {
        public string name="";
        public string password="";
        public List<Privilege> privileges = new List<Privilege>();
        public User() {

        }
    }
}
