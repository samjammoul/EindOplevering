using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019
{
    public class Kant
    {
       
        List<Rij> Rijen = new List<Rij>();

        public double MaxGewicht { get; set; }


        public double Gewichtlading { get; set; }


        public void addNewRij()
        {
            Rijen.Add(new Rij());
        }
      

        public List<Rij> GetRijen()
        {
            return Rijen;
        }
        public int ListCount()
        {
            return Rijen.Count();

        }
        public void AddContainer(int RijNummer, Container c)
        {
            Rijen[RijNummer].AddContainer(c);
        }


        /// <summary>
        /// This is a Unit test Helper
        ///
        /// </summary>
      
        public  void Set_MaxGewicht(double gewicht)
        {
            MaxGewicht = gewicht;
        }


        public void addRij(Rij rij)
        {
            Rijen.Add(rij);
        }





    }
}
