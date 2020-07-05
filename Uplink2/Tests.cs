using System.Collections.Generic;
using System.Diagnostics;

namespace Uplink2 {
    class Tests {
        public bool websiteTests() {
            Website website = new Website();
            User user = new User { name = "asdf", password = "123", privileges = new List<Privilege>() };
            if (website.tryLogin(user))
                return false;
            website.addUser(user);
            if (!website.tryLogin(user))
                return false;
            return true;
        }
        public void Run() {
            bool allTestsPassed = true;
            List<bool> tests = new List<bool> {
                [0] = websiteTests()
            };
            if (tests[0]) {
                Debug.Print("Website Tests Passed!");
            }
            else {
                Debug.Print("Website Tests Failed!");
                allTestsPassed = false;
            }
            if (allTestsPassed) {
                Debug.Print("All tests passed!");
            }
            else {
                Debug.Print("Some of the tests failed!");
            }


        }
    }
}
