using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace Uplink2 {
    public class UnitTest1 {
        [TestCase]
        public void WebsiteTests() {
            Website website = new Website();
            User user = new User { name = "asdf", password = "123", privileges = new List<Privilege>() };
            Assert.IsFalse(website.tryLogin(user));
            website.addUser(user);
            Assert.IsTrue(website.tryLogin(user));
        }
        public void TestMethod1() {
        }
    }
}
