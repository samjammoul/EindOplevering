using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019
{
    public class implementation
    {
        // list of all containers

        private List<Container> aLLcontainers = new List<Container>();


        public List<Container> ALLcontainers
        {
            get { return aLLcontainers; }
            set { aLLcontainers = value; }
        }



        List<Container> RestContainers { get; set; }

        Schip schp = new Schip();


        // Set the maximum  and minimum of the weight

        public void SetGewicht(double Maxgewicht, double Mingewicht)
        {
            schp.SchipMaxLadingGewicht = Maxgewicht;
            schp.SchipMinLadingGewicht = Mingewicht;
        }


        public void SetGewichtKanten(double rechter, double Linker)
        {
            schp.SetGewichtKanten(rechter, Linker);
        }

     
        // Add containers to the list

        public void AddContiners(double AantalWaardevolleContainer, double AantalNormaalvolleContainer, double AantalleegeContainer,
            double AantalGekoldeContainer, double GewichtVanWaardevolleContainer, double GewichtVanGekoldeContainer, double GewichtVanNormaalVolleContainer
            )
        {
            for (double i = 1; i <= AantalWaardevolleContainer; i++)
            {
                ALLcontainers.Add(new Container { ContainerType = "Waardevolle", Gewicht = GewichtVanWaardevolleContainer });
            }
            for (double i = 1; i <= AantalNormaalvolleContainer; i++)
            {
                ALLcontainers.Add(new Container { ContainerType = "Normaalvolle", Gewicht = GewichtVanNormaalVolleContainer });
            }
            for (double i = 1; i <= AantalleegeContainer; i++)
            {
                ALLcontainers.Add(new Container { ContainerType = "NormaalLeeg", Gewicht = 4.4 });
            }
            for (double i = 1; i <= AantalGekoldeContainer; i++)
            {
                ALLcontainers.Add(new Container { ContainerType = "Gekolde", Gewicht = GewichtVanGekoldeContainer });
            }
        }



        // Check if the sum of the containers is more than minimum weight

        public void checkSumVanContiners()
        {
            double sumVanGewicht = 0;
            foreach (Container Container in ALLcontainers)
            {
                sumVanGewicht += Container.Gewicht;
            }
            if (sumVanGewicht < schp.SchipMinLadingGewicht)
            {
                Console.WriteLine("The sum of weight containers is less than the minimum weight!");

            }

        }

        public void AddToRestContainers(Container Container)
        {
            RestContainers.Add(Container);
        }


        // Add containerrs to schip

        public void SetContainers()
        {
            foreach (Container Container in ALLcontainers)
            {
                schp.AddRijenVoorheleschip();
                schp.SetContainers(Container);
            }
        }

        public void ShowContainers()
        {

        }

    

     // show data aan user
       public void showdataRechter()
       {
         Console.WriteLine("=============================================================");
          Console.WriteLine("RechterKant");
           schp.ShowRechterkant();
       }


       public void showdataLinker()
       {

         Console.WriteLine("=============================================================");
         Console.WriteLine("LinkerKant");
         schp.ShowLinkerkant();

       }

        // Set the maximum of the voorkant and achterkant

        public void SetMaxGewicht_AchterEnVoorkant() => schp.SetMaxGewicht_AchterEnVoorkant();




    }
}
