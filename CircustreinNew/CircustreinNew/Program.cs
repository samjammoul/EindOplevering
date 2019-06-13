
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> Pop = new List<Product>();

            //Pop.Add(new Product { Name = "sam" });
            //Pop.Add(new Product { Name = "sam" });
            //Pop.Add(new Product { Name = "sam" });
            //int index = Pop.FindIndex(x => x.Name == "dam");



            //    Console.WriteLine(Convert.ToString(index));





            // ==========================================================


            Wagon wagon = new Wagon();
            Implementation im = new Implementation();

            // Methodes:


            //showAnimal();
            im.GetAnimal();
            im.AddAnimal();
            showAnimal();
            //wagon.SetAnimals();
            //im.showAnimals();




            foreach (var i in wagon.GetList()) { Console.WriteLine(i); }
            Console.ReadKey();



            void showAnimal()
            {
                int wagonNummer = 0;
                foreach (Wagon i in im.GetWagons())
                {
                    if (i.capacity == 0)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Wagon:" + Convert.ToInt32(wagonNummer += 1));
                        foreach (Animal a in i.GetList())
                        {

                            Console.WriteLine(a.AnimalSize + "," + a.AnimalType);
                        }
                    }

                }

            }


        }
    }
}
