using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Uplink2 {
    static class baseConditions {
        public static bool deleteFile(Website website, SECFile file) {
            return !Website.SearchForFile(file);
        }
    }
    class Mission {
        public string name;
        public string description;
        public bool isTaken;
        public Func<bool> condition;
        public bool IsDone() {
            return condition();
        }
    }
}
