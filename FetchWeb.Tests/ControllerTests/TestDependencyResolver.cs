using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchWeb.Objects;
using System.Web.Mvc;
using FetchDomain.Interfaces;
using Microsoft.Practices.Unity;

namespace FetchWeb.Tests
{
    public static class TestDependencyResolver
    {
        private static bool loaded { get; set; }
        public static void RegisterDependencies()
        {
            if (!loaded)
            {
                IUnityContainer container = new UnityContainer();
                container.RegisterType(typeof(IOrganization), typeof(TestOrganization));
                container.RegisterType(typeof(IDog), typeof(TestDog));
                container.RegisterType(typeof(IUser), typeof(TestUser));
                DependencyResolver.SetResolver(new UnityDependencyResolver(container));
                loaded = true;
            }
        }
    }
}
