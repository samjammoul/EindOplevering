using System;
using System.Collections.Generic;

namespace Containervervoer2019
{
    class Program
    {
       
        static void Main(string[] args)
        {
            implementation im = new implementation();
            Cal cal = new Cal();

            double getMaxGewicht ;
            double percentage;
            double LinkerGewicht;
            double RechterGewicht;


            // Gewicht of containers

            double GewichtVanWaardevolleContainer = 0;
            double GewichtVanGekoldeContainer = 0;
            double GewichtVanNormaalVolleContainer = 0;
           



            // Aantal of the containers

            double AantalWaardevolleContainer;
            double AantalNormaalvolleContainer;
            double AantalleegeContainer;
            double AantalGekoldeContainer;




            //GEt the Maximun Gewicht
            GetMaGewicht();



            //GEt the Percentage
            GetPerecentage();


            ////Calculate the Percentage
            CalPerecentage();




            //Get the Containers:

            //1-Get the count and then the weight:

            //1-  Waarde volle Container
            Console.WriteLine("How many waardevolle do you want to add?");

            AantalWaardevolleContainer = Convert.ToInt32(Console.ReadLine());

            

            if (AantalWaardevolleContainer>0)
            {
                Console.WriteLine("What is the Weight of waardevolle Containers?");

                GewichtVanWaardevolleContainer = Convert.ToInt32(Console.ReadLine());
            }


            //2-  Gekolde Container
            Console.WriteLine("How many gekoeld  do you want to add?");

            AantalGekoldeContainer = Convert.ToInt32(Console.ReadLine());

            if (AantalGekoldeContainer > 0)
            {
                Console.WriteLine("What is the Weight of gekoeld Containers?");

                GewichtVanGekoldeContainer = Convert.ToInt32(Console.ReadLine());
            }

            //3-  Normaal Volle Container

            Console.WriteLine("How many Normaal volle  do you want to add?");

            AantalNormaalvolleContainer = Convert.ToInt32(Console.ReadLine());

            if (AantalNormaalvolleContainer > 0)
            {

                Console.WriteLine("What is the Weight of Normaal volle Containers?");

                GewichtVanNormaalVolleContainer = Convert.ToInt32(Console.ReadLine());

            }

            //4-  Normaal Leege Container

            Console.WriteLine("How many leege  do you want to add?");

            AantalleegeContainer = Convert.ToInt32(Console.ReadLine());

         

            //Add the Containers to All Containers list of schip

            im.AddContiners(AantalWaardevolleContainer, AantalNormaalvolleContainer, AantalleegeContainer, AantalGekoldeContainer 
                ,GewichtVanWaardevolleContainer,  GewichtVanGekoldeContainer,  GewichtVanNormaalVolleContainer);


            // check if the sum of containerrs weight

            im.checkSumVanContiners();


            // Set the maximmum weight of Voorkant and achterkant

            im.SetMaxGewicht_AchterEnVoorkant();


            // Set the containers in the schip

            im.SetContainers();

          
            // Show the containers

            im.showdataRechter();
            im.showdataLinker();

            

            Console.ReadKey();


            //Methodes


            // Get the maximum weight of the schip

            void GetMaGewicht()
            {
                Console.WriteLine("Enter Maximum gewicht van de lading (ton):");

                getMaxGewicht = Convert.ToInt32(Console.ReadLine());

                cal.CalMinGwicht(getMaxGewicht);

                im.SetGewicht(getMaxGewicht, cal.CalMinGwicht(getMaxGewicht));
            }



            // chose the perecentage

            void GetPerecentage()
            {
                Console.WriteLine("Chose of it :");
                Console.WriteLine("1 - 60 % right and 40 % left");
                Console.WriteLine("2 - 60 % left and 40 % right");
                Console.WriteLine("Please enter 1 or 2 !!");
                percentage = Convert.ToInt32(Console.ReadLine());
            }



             
            // Calculate the weight of the kanten

            void CalPerecentage()
            {
                if (percentage == 1)
                {
                    LinkerGewicht = (getMaxGewicht * 40) / 100;
                    RechterGewicht = (getMaxGewicht * 60) / 100;
                    im.SetGewichtKanten(RechterGewicht, LinkerGewicht);
                }
                else if (percentage == 2)
                {
                    LinkerGewicht = (getMaxGewicht * 60) / 100;
                    RechterGewicht = (getMaxGewicht * 40) / 100;
                    im.SetGewichtKanten(RechterGewicht, LinkerGewicht);
                }
            }

            
              
            


        }





    }
}
