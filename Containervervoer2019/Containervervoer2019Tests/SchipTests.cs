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
    public class SchipTests
    {

        /// <summary>
        /// Test of SetContainers Method
        /// </summary>
        [TestMethod()]
        public void SetContainersTest_addGekolde1_1_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Container container = new Container { ContainerType = "Gekolde", Gewicht = 30 };
            Schip schip = new Schip();

            schip.AddRijenVoorheleschip();
            Rij firstRij = schip.GetVoorkantListLinkerKant().First();

            
            CountOflistBeforeAddingContainer = firstRij.RijContainers().Count;
            schip.Set_MaxGewicht_linkerKant(60);
            schip.SetContainers(container);
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = firstRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);


            // MyClass result = schip.GetVoorkantListLinkerKant().Find(x => x.RijContainers().Count == "xy");


        }

        [TestMethod()]
        public void SetContainersTest_addGekolde1_2_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(1000);
            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
           schip.addRij_Voorkant_LinkerKant(new Rij { BaseContainer =  1 , TopVanRij = 1   });
            schip.addRij_Voorkant_LinkerKant(new Rij());
            schip.addRij_Voorkant_LinkerKant(new Rij());
            Rij SecondRij = schip.GetVoorkantListLinkerKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Gekolde", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);


            

        }

        [TestMethod()]
        public void SetContainersTest_addGekolde1_3_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(1000);
            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { BaseContainer = 1, TopVanRij = 1 , GewichtBovenDeBaseContainer = 120});
            schip.addRij_Voorkant_LinkerKant(new Rij { BaseContainer = 1, TopVanRij = 0 });
            schip.addRij_Voorkant_LinkerKant(new Rij());
            schip.addRij_Voorkant_LinkerKant(new Rij());
            Rij SecondRij = schip.GetVoorkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Gekolde", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);




        }


        [TestMethod()]
        public void SetContainersTest_addWaardevolle1_1_WaardeVolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(1000);
            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { });
        
            Rij SecondRij = schip.GetVoorkantListLinkerKant()[0];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Waardevolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }



        [TestMethod()]
        public void SetContainersTest_addWaardevolle1_2_WaardeVolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);
            
            schip.Set_MaxGewicht_Voorkant_Linkerkant(0);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 0 });
            schip.addRij_Achterkant_LinkerKant(new Rij { });

            Rij SecondRij = schip.GetAchterkantListLinkerKant()[0];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Waardevolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle1_1_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1 , BaseContainer = 1 , GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_LinkerKant(new Rij { });

            Rij SecondRij = schip.GetVoorkantListLinkerKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle1_2_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle1_3_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalleege1_1_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_LinkerKant(new Rij { });

            Rij SecondRij = schip.GetVoorkantListLinkerKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg_2_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg1_3_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Voorkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalleege1_4_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(0);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_LinkerKant(new Rij { });

            Rij SecondRij = schip.GetAchterkantListLinkerKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg1_5_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(100);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(0);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetAchterkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg1_6_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(1000);

            schip.Set_MaxGewicht_Voorkant_Linkerkant(0);
            schip.Set_MaxGewicht_Achterkant_LinkerRechter(100);
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_LinkerKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetAchterkantListLinkerKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }
        [TestMethod()]
        public void SetContainersTest_addGekolde2_1_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Container container = new Container { ContainerType = "Gekolde", Gewicht = 30 };
            Schip schip = new Schip();

            schip.AddRijenVoorheleschip();
            Rij firstRij = schip.GetVoorkantListRechterKant().First();


            CountOflistBeforeAddingContainer = firstRij.RijContainers().Count;
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);
            schip.SetContainers(container);
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = firstRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);


            // MyClass result = schip.GetVoorkantListLinkerKant().Find(x => x.RijContainers().Count == "xy");


        }

        [TestMethod()]
        public void SetContainersTest_addGekolde2_2_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(1000);
            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { BaseContainer = 1, TopVanRij = 1 });
            schip.addRij_Voorkant_RechterKant(new Rij());
            schip.addRij_Voorkant_RechterKant(new Rij());
            Rij SecondRij = schip.GetVoorkantListRechterKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Gekolde", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);




        }

        [TestMethod()]
        public void SetContainersTest_addGekolde2_3_GekoldeIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(1000);
            schip.Set_MaxGewicht_Voorkant_Linkerkant(100);
            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { BaseContainer = 1, TopVanRij = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_RechterKant(new Rij { BaseContainer = 1, TopVanRij = 0 });
            schip.addRij_Voorkant_RechterKant(new Rij());
            schip.addRij_Voorkant_RechterKant(new Rij());
            Rij SecondRij = schip.GetVoorkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Gekolde", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);




        }


        [TestMethod()]
        public void SetContainersTest_addWaardevolle2_1_WaardeVolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(1000);
            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { });

            Rij SecondRij = schip.GetVoorkantListRechterKant()[0];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Waardevolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }



        [TestMethod()]
        public void SetContainersTest_addWaardevolle2_2_WaardeVolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(0);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 0 });
            schip.addRij_Achterkant_RechterKant(new Rij { });

            Rij SecondRij = schip.GetAchterkantListRechterKant()[0];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Waardevolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle2_1_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Voorkant_RechterKant(new Rij { });

            Rij SecondRij = schip.GetVoorkantListRechterKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);


        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle2_2_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalvolle2_3_NormaalvolleIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "Normaalvolle", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalleege2_1_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();

            schip.Set_MaxGewicht_linkerKant(0);
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_RechterKant(new Rij { });

            Rij SecondRij = schip.GetVoorkantListRechterKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg2_2_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg2_3_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(100);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Voorkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetVoorkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalleege2_4_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(0);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_RechterKant(new Rij { });

            Rij SecondRij = schip.GetAchterkantListRechterKant().First();


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg2_5_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_RechterKant(100);

            schip.Set_MaxGewicht_Voorkant_RechterKant(0);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 0, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetAchterkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

        [TestMethod()]
        public void SetContainersTest_addNormaalLeeg2_6_NormaalLeegIsAdded()
        {
            int CountOflistBeforeAddingContainer = 0;
            int CountOflistAfterAddingContainer = 0;
            int ExpectedCount;
            Schip schip = new Schip();
            schip.Set_MaxGewicht_RechterKant(1000);

            schip.Set_MaxGewicht_Voorkant_RechterKant(0);
            schip.Set_MaxGewicht_Achterkant_RechterKant(100);
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 1, BaseContainer = 1, GewichtBovenDeBaseContainer = 120 });
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });
            schip.addRij_Achterkant_RechterKant(new Rij { TopVanRij = 0, BaseContainer = 1, GewichtBovenDeBaseContainer = 0 });

            Rij SecondRij = schip.GetAchterkantListRechterKant()[1];


            CountOflistBeforeAddingContainer = SecondRij.RijContainers().Count;

            schip.SetContainers(new Container { ContainerType = "NormaalLeeg", Gewicht = 30 });
            var list = schip.GetVoorkantListLinkerKant();
            CountOflistAfterAddingContainer = SecondRij.RijContainers().Count;
            ExpectedCount = CountOflistBeforeAddingContainer + 1;



            Assert.AreEqual(ExpectedCount, CountOflistAfterAddingContainer);



        }

       //////////////////////////////////////////////////   The End    ///////////////////////////////////////////////////////////////
























    }

}