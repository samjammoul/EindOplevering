using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinNew
{
    public class Implementation : Iimplementation
    {
        private List<Wagon> Wagons = new List<Wagon>();
        private List<Animal> Animals = new List<Animal>();

        
      
        public List<Wagon> GetWagons()
        {
            
            return Wagons;
        }


        public Wagon putAnimalInWagon(Animal incomingAnimal)
        {
            for (int i = 0; i < Wagons.Count-1; i++)
            {
                if (10 - Wagons[i].capacity >= incomingAnimal.punten) //wagon has enough spacce
                {
                    Animal LargestME = findLargestME(Wagons[i]); //find the largest Meat eater in the wagon
                    if (willSurvive(LargestME, incomingAnimal))  //if the incoming animal survive?
                    {
                        //put the incoming animal into that wagon
                        Wagons[i].AddAnimal(incomingAnimal);
                        return Wagons[i]; //fake return
                    }
                }
            }
            return null;
        }

        private bool willSurvive(Animal largestME, Animal incomingAnimal)
        {
            //TODO
            throw new NotImplementedException();
        }

        private Animal findLargestME(Wagon wagon)
        {
            //TODO
            throw new NotImplementedException();
        }

        public List<Animal> GetAnimal()
        {
            // simple files are always put in the bin folder
            using (StreamReader sr = new StreamReader("../../AnimalsEatingmeat.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Trim().Length > 0)
                    {
                        // normalize input --> all in lower case
                        Animals.Add(new Animal { AnimalSize = line.Trim().ToLower(), AnimalType = "MeatEater" });
                    }
                }
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\Sam\source\repos\CircustreinNew\CircustreinNew\AnimalsEatingplant.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Trim().Length > 0)
                    {
                        // normalize input --> all in lower case
                        Animals.Add(new Animal { AnimalSize = line.Trim().ToLower(), AnimalType = "PlantEater" });
                    }
                }
            }



            return Animals;
        }
        public void setpoints()
        {
            if ((Animals != null))
            {
                foreach (var i in Animals)
                {
                    if (i.AnimalSize == "l" && i.AnimalType == "PlantEater")
                    {
                        i.punten = 5;
                    }
                    else if (i.AnimalSize == "l" && i.AnimalType == "MeatEater")
                    {
                        i.punten = 10;
                    }
                    else if (i.AnimalSize == "m")
                    {
                        i.punten = 3;
                    }
                    else if (i.AnimalSize == "s")
                    {
                        i.punten = 1;
                    }
                }
            }
            else { Console.WriteLine("There is no Animals!!"); }

        }


        public void GetNewWagon()
        {
            Wagons.Add(new Wagon { number = Wagons.Count, capacity = 0 });
        }



        public void AddAnimal()
        {

            if (Animals == null)
            {
                Console.WriteLine("There is no Animals");
            }
            else
            {
                setpoints();
                GetNewWagon();
                foreach (Animal i in Animals)
                {
                    Setanimal(i);
                    GetNewWagon();

                }
                
                      
                  

              

            }
        }

        public void Setanimal(Animal animal)
        {
            foreach (Wagon w in Wagons)
            {
                if (animal.AnimalType == "MeatEater" && animal.AnimalSize == "l")
                {
                    if (w.capacity == 0)
                    {
                        w.AddAnimal(animal);
                        w.capacity = 10;
                        GetNewWagon();
                        break;
                    }
                }
                else if (animal.AnimalType == "MeatEater" && animal.AnimalSize == "m")
                {
                    int CheckM = w.GetallAnimals().FindIndex(x => x.AnimalSize == "m");
                    int CheckS = w.GetallAnimals().FindIndex(x => x.AnimalSize == "s");
                    int Check_Meateater = w.GetallAnimals().FindIndex(x => x.AnimalType == "MeatEater");
                    if (animal.punten + w.capacity <= 10 && CheckM < 0 && CheckS < 0 && Check_Meateater < 0)
                    {
                        w.AddAnimal(animal);

                        w.capacity += animal.punten;


                        GetNewWagon();

                        break;
                    }
                }
                else if (animal.AnimalType == "MeatEater" && animal.AnimalSize == "s")
                {

                    int CheckS = w.GetallAnimals().FindIndex(x => x.AnimalSize == "s");
                    int Check_Meateater = w.GetallAnimals().FindIndex(x => x.AnimalType == "MeatEater");
                    if (animal.punten + w.capacity <= 10 && Check_Meateater < 0)
                    {
                        w.AddAnimal(animal);

                        w.capacity += animal.punten;


                        GetNewWagon();

                        break;
                    }
                }
                else if (animal.AnimalType == "PlantEater" && animal.AnimalSize == "l")
                {

                    int CheckS = w.GetallAnimals().FindIndex(x => x.AnimalSize == "l" &&  x.AnimalSize== "MeatEater");
                    
                    if (animal.punten + w.capacity <= 10 && CheckS < 0)
                    {
                        w.AddAnimal(animal);

                        w.capacity += animal.punten;


                        GetNewWagon();

                        break;
                    }
                }
                else if (animal.AnimalType == "PlantEater" && animal.AnimalSize == "m")
                {
                    int CheckS = w.GetallAnimals().FindIndex(x => x.AnimalSize == "l" && x.AnimalSize == "MeatEater");
                    int Checkm = w.GetallAnimals().FindIndex(x => x.AnimalSize == "m" && x.AnimalSize == "MeatEater");
                    if (animal.punten + w.capacity <= 10 && CheckS < 0 && Checkm < 0)
                    {
                        w.AddAnimal(animal);

                        w.capacity += animal.punten;


                        GetNewWagon();

                        break;
                    }
                }
                else if (animal.AnimalType == "PlantEater" && animal.AnimalSize == "s")
                {
                    int Checkl = w.GetallAnimals().FindIndex(x => x.AnimalSize == "l" && x.AnimalSize == "MeatEater");
                    int Checkm = w.GetallAnimals().FindIndex(x => x.AnimalSize == "m" && x.AnimalSize == "MeatEater");
                    int CheckS = w.GetallAnimals().FindIndex(x => x.AnimalSize == "s" && x.AnimalSize == "MeatEater");
                    if (animal.punten + w.capacity <= 10 && CheckS < 0 && Checkm < 0 && Checkl < 0)
                    {
                        w.AddAnimal(animal);

                        w.capacity += animal.punten;


                        GetNewWagon();

                        break;
                    }
                }

            }
        }
            public void Setanimal2(Animal animal)
             {
            Animal Random = new Animal();
            bool chech = true;
       


            foreach (Wagon w in Wagons)
            {

                if (animal.AnimalType == "MeatEater")
                {
                    if (animal.AnimalSize == "L"  )
                    {
                        w.AddAnimal(animal);

                        w.capacity = 10;


                        GetNewWagon();

                        break;
                    }
                    else if (animal.AnimalSize == "m" && animal.punten + w.capacity <= 10)
                    {


                        foreach (Animal a in w.GetallAnimals())
                        {
                            if (a.AnimalSize == "m" || a.AnimalSize == "s")
                            {
                                chech = false;
                                break;
                            }



                        }
                        if (chech == true)
                        {

                            w.AddAnimal(animal);

                            w.capacity += animal.punten;


                            GetNewWagon();

                            break;



                        }




                    }
                    else if (animal.AnimalSize == "S" && animal.punten + w.capacity <= 10)
                    {


                        foreach (Animal a in w.GetallAnimals())
                        {
                            if (a.AnimalSize == "S")
                            {
                                chech = false;
                                break;
                            }



                        }
                        if (chech == true)
                        {

                            w.AddAnimal(animal);

                            w.capacity += animal.punten;


                            GetNewWagon();

                            break;



                        }
                        else { }
                    }
                }
                else if (animal.AnimalType == "PlantEater")
                {

                    if ((animal.punten + w.capacity) <= 10)
                   {
                        w.AddAnimal(animal);
                        w.capacity += animal.punten;
                        if (w.capacity > 6)
                        {
                            GetNewWagon();
                            break;

                        }
                        else
                        {

                            break;
                        }
                    }


                }   
          

            }

            

                
                
        }
           


      


    }
} 
