using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Media;

namespace Uplink2 {
    class Website {
        string name = "Test";
        string description = "Testingdesc";
        string subtitle = "Testingsub";
        string ip = "1.1.1.1";
        List<User> users = new List<User>();
        List<Log> logs = new List<Log>();
        LoginScreen loginScreen = new LoginScreen();
        private static Random random = new Random();
        List<Website> links = new List<Website>();
        bool userLoginSuccessful = false;
        Player pl = new Player();
        internal void addUser(User user) {
            users.Add(user);
        }
        void deleteLogs() {
            if (connectedUser.privileges.Contains(Privilege.Admin)) {
                switch (Player.deleteTool.level) {
                    case 1:
                        replaceAllLogsWithDeletedOnes();
                        break;
                    case 2:
                        replaceAllLogsWithScramOnes();
                        break;
                    case 3:
                        replaceAllLogsWithRoutedOnes();
                        break;
                    case 4:
                        removeAllLogs();
                        break;
                }
            }
        }

        private void replaceAllLogsWithRoutedOnes() {

            List<Log> aux = new List<Log>(logs.Count);
            for (int i = 0; i < logs.Count; i++)
                aux.Add(new Log { content = "Connected and routed " + RandomIP() + " to " + RandomIP(), deletionLevel = 3 });
            logs = aux;        }

        private void replaceAllLogsWithScramOnes() {

            List<Log> aux = new List<Log>(logs.Count);
            for (int i = 0; i < logs.Count; i++)
                aux.Add(new Log { content = RandomString(10), deletionLevel = 2 });
            logs = aux;
        }

        private void removeAllLogs() {
            logs = new List<Log>();
                }
        private void replaceAllLogsWithDeletedOnes() {
            List<Log>aux = new List<Log>(logs.Count);
            for (int i = 0;i< logs.Count;i++)
                aux.Add(new Log { content = "Log Deleted", deletionLevel = 1 });
            logs = aux;
        }

        User connectedUser;
        public static string RandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string randomNumberString(int length) {
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomIP() {
            return randomNumberString(3) + "." + randomNumberString(3) + "." + randomNumberString(3) + "." + randomNumberString(3);
        }
        public void connect(User usr) {
            connectedUser = usr;
        }
        public bool tryLogin(User usr) {
            if (users.Count > 0){ 
                userLoginSuccessful = users.Any(item => item.Equals(usr));
                return userLoginSuccessful; }
            else
                return false;
        }
        public List<Log> GetLogs() {
            List<Log> aux = new List<Log>();
            foreach (Log log in logs) {
                switch (log.deletionLevel) {
                    case 0:
                        aux.Append(log);
                        break;
                    case 1:
                        aux.Append(new Log { content = "Log Deleted", deletionLevel = 1 });
                        break;
                    case 2:
                        aux.Append(new Log { content = RandomString(10), deletionLevel = 2 });
                        break;
                    case 3:
                        aux.Append(new Log { content = "Connected and routed " + RandomIP() + " to " + RandomIP(), deletionLevel = 3 });
                        break;
                }
            }
            return aux;
        }
    }
}
