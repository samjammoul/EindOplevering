using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinNew
{
    public class Wagon
    {
        private List<Animal> animalType_size = new List<Animal>();

        // Om List te gebruiken buiten de klass

        public List<Animal> gtanimals = new List<Animal>();

        public bool HasMeatEater { get; set; }

        public void AddAnimal(Animal animal)
        {
            gtanimals.Add(animal);
            
        }
        public List<Animal> GetallAnimals() { return gtanimals; }

        public void SetAnimals()
        {
            try
            {
                foreach (var i in gtanimals)
                {
                    animalType_size.Add(i);
                }
            }
            catch { }

        }


        public List<Animal> GetList()
        {
            return gtanimals;
        }
        public int capacity { get; set; }

        

        public int number { get; set; }
       
     

}
}
