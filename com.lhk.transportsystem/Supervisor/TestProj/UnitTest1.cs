using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility.Password;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPassword()
        {
            string key = "nhanvien2";
            string pass = "123456";
            string encrypt = PasswordServiceProvider.Encrypt(key, pass);
        }
    }
}
