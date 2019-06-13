using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019
{
    public class Half
    {
        List<Container> Containers = new List<Container>();


        public double MaxGewicht { get; set; }


        public double Gewichtlading { get; set; }


        List<Container> allContainer = new List<Container>();

        Kant VoorKant = new Kant();


        Kant AchterKant = new Kant();

        public void AddRijenVoorHeleKanten()
        {
            VoorKant.addNewRij();
            AchterKant.addNewRij();
        }

        public List<Rij> GetVoorkantRijen() => VoorKant.GetRijen();

        public List<Rij> GetAchterkantRijen() => AchterKant.GetRijen();

        public void SetMaxGewichtVoorkant(double MaxGewicht)
        {
            VoorKant.MaxGewicht = MaxGewicht;
        }

        public void SetMaxGewichtAchterkant(double MaxGewicht)
        {
           AchterKant.MaxGewicht = MaxGewicht;
        }

        public double VoorkantMaxgewicht()
        {
            return VoorKant.MaxGewicht;

        }

        public double AchterkantMaxgewicht()
        {
            return AchterKant.MaxGewicht;

        }

        public void  AddGewichtVoorkant(double containerGewicht)
        {
            VoorKant.Gewichtlading += containerGewicht;
        }

        public void AddGewichtAcherkant(double containerGewicht)
        {
            AchterKant.Gewichtlading += containerGewicht;
        }

        public double VoorkantLandingGewicht()
        {
            return VoorKant.Gewichtlading;

        }

        public double AchterkantLandingGewicht()
        {
            return AchterKant.Gewichtlading;

        }


        // Helper voor unit test :

        public void Set_MaxGewicht(double gewicht)
        {
            MaxGewicht = gewicht;
        }

        public void Set_MaxGewicht_Voorkant(double gewicht) => VoorKant.Set_MaxGewicht(gewicht);

        public void addRij_Voorkant(Rij rij) => VoorKant.addRij(rij);

        public void Set_MaxGewicht_Achterkant(double gewicht) => AchterKant.Set_MaxGewicht(gewicht);

        public void addRij_Achterkant(Rij rij) => AchterKant.addRij(rij);

    }
}
