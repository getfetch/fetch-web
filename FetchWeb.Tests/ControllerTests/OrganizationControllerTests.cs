using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FetchWeb.Controllers;
using System.Web.Mvc;
using System.Web;

namespace FetchWeb.Tests
{
    [TestClass]
    public class OrganizationControllerTests
    {
        private OrganizationController controller;

        [ClassInitialize]
        public static void InitiateClass(TestContext context)
        {
            TestDependencyResolver.RegisterDependencies();
        }

        [TestInitialize]
        public void InitializeTest()
        {
            controller = new OrganizationController();
        }

        [TestMethod]
        public void DetailsTestInvalidId()
        {
            RedirectToRouteResult result = (RedirectToRouteResult)controller.Details(0);
            Assert.IsTrue(result.RouteValues.ContainsKey("action"));
            Assert.IsTrue(result.RouteValues.ContainsKey("controller"));
            Assert.AreEqual("Index", result.RouteValues["action"].ToString());
            Assert.AreEqual("Home", result.RouteValues["controller"].ToString());
        }

        [TestMethod]
        public void DetailsTestValidId()
        {
            ViewResult result = (ViewResult)controller.Details(2);
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void CreateGetTest()
        {
            ViewResult result = (ViewResult)controller.Create();
            Assert.AreEqual("Create", result.ViewName);
        }

        //[TestMethod]
        //public void CreatePostTestError()
        //{
        //    IOrganizationCreateModel model = new IOrganizationCreateModel() { };
        //    ViewResult result = (ViewResult)controller.Create();
        //    Assert.AreEqual("Create", result.ViewName); 
        //}

        //[TestMethod]
        //public void CreatePostTest()
        //{
        //    IOrganizationCreateModel model = new IOrganizationCreateModel() { };
        //    RedirectToRouteResult result = (RedirectToRouteResult)controller.Create(model);
        //    Assert.IsTrue(result.RouteValues.ContainsKey("action"));
        //    Assert.IsTrue(result.RouteValues.ContainsKey("controller"));
        //    Assert.AreEqual("Details", result.RouteValues["action"].ToString());
        //    Assert.AreEqual("Organization", result.RouteValues["controller"].ToString());
        //}
    }
}
