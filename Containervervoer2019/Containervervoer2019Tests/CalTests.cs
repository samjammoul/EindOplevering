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
    public class CalTests
    {
        [TestMethod()]
        public void CalMinGwichtTest()
        {
            // arrange
            double InPutGewicht = 100;
            double expected = 50;
            Cal cal = new Cal();
            // act
            
            double actual = cal.CalMinGwicht(InPutGewicht);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}