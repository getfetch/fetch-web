using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FetchWeb.Tests
{
    [TestClass]
    public class AccountControllerTests
    {
        [TestInitialize]
        public void InitiateTest()
        {
            TestDependencyResolver.RegisterDependencies();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
