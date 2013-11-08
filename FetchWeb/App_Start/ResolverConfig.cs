using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.Practices.Unity;
using FetchDomain.Interfaces;
using FetchDomain.Objects;
using FetchWeb.Objects;

namespace FetchWeb
{
    public static class ResolverConfig
    {
        public static void RegisterDependencies()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(IOrganization), typeof(Organization));
            container.RegisterType(typeof(IDog), typeof(Dog));
            container.RegisterType(typeof(IUser), typeof(User));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}