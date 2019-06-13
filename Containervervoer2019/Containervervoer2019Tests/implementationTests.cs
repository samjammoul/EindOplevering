using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containervervoer2019;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019.Tests
{
    [TestClass()]
    public class implementationTests
    {
        [TestMethod()]
        public void AddContiners_AddContainerTolist_ContainersisAdded()
        {
            int CountBefore;
            int CountAfter;
            int ExceptedCount;
            implementation im = new implementation();

            CountBefore = im.ALLcontainers.Count;
            // Aantal : Waardevolle : 10 // Gekolde : 10 // N.Leege : 10 // N.Volle : 10
            im.AddContiners(10,10,10,10,10,10,10);
            CountAfter = im.ALLcontainers.Count;
            ExceptedCount = CountBefore + 10 + 10 + 10 + 10;

            Assert.AreEqual(ExceptedCount,CountAfter);

        }
    }
}