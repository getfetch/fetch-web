using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FetchDomain.Services;

namespace FetchDomain.Tests.Services
{
    [TestClass]
    public class DogServiceTests
    {
        [TestMethod]
        [TestProperty("Type", "Api")]
        public void FindDogsTest()
        {
            DogServices services = new DogServices();
            decimal lon = Decimal.Parse("-80.00");
            decimal lat = Decimal.Parse("40.40");
            var dogs = services.FindDogs(100, lat, lon);

            Assert.AreNotEqual(null, dogs);
            Assert.AreNotEqual(0, dogs.Count);
        }
    }
}
