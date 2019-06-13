using System;
using System.Collections.Generic;

namespace Containervervoer2019
{
    public class Schip
    {

        public double SchipMaxLadingGewicht { get; set; }
        public double SchipMinLadingGewicht { get; set; }
        List<Container> SchipContiners = new List<Container>();

        public double LadingGewicht { get; set; }

        Half LinkerKant = new Half();
        Half RechterKant = new Half();

        public void SetLadingGewicht(double LadingGewicht, double RechterLadingGewicht, double LinkerLadingGewicht)
        {
            this.LadingGewicht = LadingGewicht;
            RechterLadingGewicht = RechterKant.Gewichtlading;
            LinkerLadingGewicht = LinkerKant.Gewichtlading;
        }


        public void SetGewichtKanten(double rechter, double Linker)
        {
            LinkerKant.MaxGewicht = rechter;
            RechterKant.MaxGewicht = Linker;
        }


        //Add Rij to all the sides
        public void AddRijenVoorheleschip()
        {
            LinkerKant.AddRijenVoorHeleKanten();
            RechterKant.AddRijenVoorHeleKanten();

        }


        public void SetContainers(Container container)
        {
            
            SetLadingGewicht(0, 0, 0);

            if ((LinkerKant.Gewichtlading + container.Gewicht) <= LinkerKant.MaxGewicht)
            {
                if (container.ContainerType == "Gekolde")
                {
                    foreach (Rij r in LinkerKant.GetVoorkantRijen())
                    {
                        if (r.BaseContainer == 0)
                        {
                            container.ContainerPlek = "BaseContainer";
                            r.BaseContainer = 1;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            LinkerKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                        else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                        {
                            r.GewichtBovenDeBaseContainer += container.Gewicht;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            LinkerKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                        else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                        {
                            container.ContainerPlek = "TopVanRij";
                            r.TopVanRij = 1;
                            r.GewichtBovenDeBaseContainer += container.Gewicht;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            LinkerKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                    }
                }
                else if (container.ContainerType == "Waardevolle")
                {

                    if ((LinkerKant.VoorkantLandingGewicht() + container.Gewicht) <= LinkerKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in LinkerKant.GetVoorkantRijen())
                        {

                            if (r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                LinkerKant.Gewichtlading += container.Gewicht;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                break;
                            }
                        }
                    }
                    else if ((LinkerKant.AchterkantLandingGewicht() + container.Gewicht) <= LinkerKant.AchterkantMaxgewicht())
                    {
                        foreach (Rij r in LinkerKant.GetAchterkantRijen())
                        {

                            if (r.TopVanRij == 0)

                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.Gewichtlading += container.Gewicht;
                                LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                        }
                    }

                       
                }
                else if (container.ContainerType == "Normaalvolle")
                {
                    if ((LinkerKant.VoorkantLandingGewicht() + container.Gewicht) <= LinkerKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in LinkerKant.GetVoorkantRijen())
                        {

                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;
                            }

                        }
                    }
                    else if ((LinkerKant.AchterkantLandingGewicht() + container.Gewicht) <= LinkerKant.AchterkantMaxgewicht())
                    {

                        foreach (Rij r in LinkerKant.GetAchterkantRijen())
                        {
                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.Gewichtlading += container.Gewicht;
                                LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.Gewichtlading += container.Gewicht;
                                LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.Gewichtlading += container.Gewicht;
                                LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                        }
                    }
                        }
                else if (container.ContainerType == "NormaalLeeg")
                {
                    if ((LinkerKant.VoorkantLandingGewicht() + container.Gewicht) <= LinkerKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in LinkerKant.GetVoorkantRijen())
                        {

                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;

                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                LinkerKant.AddGewichtVoorkant(container.Gewicht);
                                LinkerKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                        }
                    }
                    else if ((LinkerKant.AchterkantLandingGewicht() + container.Gewicht) <= LinkerKant.AchterkantMaxgewicht())
                    {
                        
                            foreach (Rij r in LinkerKant.GetAchterkantRijen())
                            {
                                if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                                {
                                    r.GewichtBovenDeBaseContainer += container.Gewicht;
                                    r.AddContainer(container);
                                    AddRijenVoorheleschip();
                                    LinkerKant.Gewichtlading += container.Gewicht;
                                    LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                    break;
                                }
                                else if (r.BaseContainer == 0)
                                {
                                    container.ContainerPlek = "BaseContainer";
                                    r.BaseContainer = 1;
                                    r.AddContainer(container);
                                    AddRijenVoorheleschip();
                                    LinkerKant.Gewichtlading += container.Gewicht;
                                    LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                    break;
                                }
                                else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                                {
                                    container.ContainerPlek = "TopVanRij";
                                    r.TopVanRij = 1;
                                    r.GewichtBovenDeBaseContainer += container.Gewicht;
                                    r.AddContainer(container);
                                    AddRijenVoorheleschip();
                                    LinkerKant.Gewichtlading += container.Gewicht;
                                    LinkerKant.AddGewichtAcherkant(container.Gewicht);
                                    break;
                                }
                            }
                        
                    }
                }
            }
            else if (RechterKant.Gewichtlading + container.Gewicht <= RechterKant.MaxGewicht)
            {
                if (container.ContainerType == "Gekolde")
                {
                    foreach (Rij r in RechterKant.GetVoorkantRijen())
                    {
                        if (r.BaseContainer == 0)
                        {
                            container.ContainerPlek = "BaseContainer";
                            r.BaseContainer = 1;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            RechterKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                        else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                        {
                            r.GewichtBovenDeBaseContainer += container.Gewicht;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            RechterKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                        else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                        {
                            container.ContainerPlek = "TopVanRij";
                            r.TopVanRij = 1;
                            r.GewichtBovenDeBaseContainer += container.Gewicht;
                            r.AddContainer(container);
                            AddRijenVoorheleschip();
                            RechterKant.Gewichtlading += container.Gewicht;
                            break;
                        }
                    }
                }
                else if (container.ContainerType == "Waardevolle")
                {

                    if ((RechterKant.VoorkantLandingGewicht() + container.Gewicht) <= RechterKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in RechterKant.GetVoorkantRijen())
                        {

                            if (r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                RechterKant.Gewichtlading += container.Gewicht;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                break;
                            }
                        }
                    }
                    else if ((RechterKant.AchterkantLandingGewicht() + container.Gewicht) <= RechterKant.AchterkantMaxgewicht())
                    {
                        foreach (Rij r in RechterKant.GetAchterkantRijen())
                        {

                            if (r.TopVanRij == 0)

                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                        }
                    }


                }
                else if (container.ContainerType == "Normaalvolle")
                {
                    if ((RechterKant.VoorkantLandingGewicht() + container.Gewicht) <= RechterKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in RechterKant.GetVoorkantRijen())
                        {

                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;
                            }

                        }
                    }
                    else if ((RechterKant.AchterkantLandingGewicht() + container.Gewicht) <= RechterKant.AchterkantMaxgewicht())
                    {

                        foreach (Rij r in RechterKant.GetAchterkantRijen())
                        {
                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                        }
                    }
                }
                else if (container.ContainerType == "NormaalLeeg")
                {
                    if ((RechterKant.VoorkantLandingGewicht() + container.Gewicht) <= RechterKant.VoorkantMaxgewicht())
                    {
                        foreach (Rij r in RechterKant.GetVoorkantRijen())
                        {

                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;

                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.AddGewichtVoorkant(container.Gewicht);
                                RechterKant.Gewichtlading += container.Gewicht;
                                break;
                            }
                        }
                    }
                    else if ((RechterKant.AchterkantLandingGewicht() + container.Gewicht) <= RechterKant.AchterkantMaxgewicht())
                    {

                        foreach (Rij r in RechterKant.GetAchterkantRijen())
                        {
                            if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 1)
                            {
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 0)
                            {
                                container.ContainerPlek = "BaseContainer";
                                r.BaseContainer = 1;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                            else if (r.BaseContainer == 1 && container.Gewicht + r.GewichtBovenDeBaseContainer <= 120 && r.TopVanRij == 0)
                            {
                                container.ContainerPlek = "TopVanRij";
                                r.TopVanRij = 1;
                                r.GewichtBovenDeBaseContainer += container.Gewicht;
                                r.AddContainer(container);
                                AddRijenVoorheleschip();
                                RechterKant.Gewichtlading += container.Gewicht;
                                RechterKant.AddGewichtAcherkant(container.Gewicht);
                                break;
                            }
                        }

                    }
                }
            }





       }



        public void ShowLinkerkant()
        {
            Console.WriteLine("VoorKant:");
            foreach (Rij r in LinkerKant.GetVoorkantRijen())
            {
                if (r.RijContainers().Count > 0)
                {
                    Console.WriteLine("Rij:");
                    foreach (Container c in r.RijContainers())
                    {
                        Console.WriteLine(c.ContainerType + ":" + c.ContainerPlek);
                    }
                }
                else { }
            }
            Console.WriteLine("AchterKant:");
            foreach (Rij r in LinkerKant.GetAchterkantRijen())
            {
                if (r.RijContainers().Count > 0)
                {
                    Console.WriteLine("Rij:");
                    foreach (Container c in r.RijContainers())
                    {
                        Console.WriteLine(c.ContainerType + ":" + c.ContainerPlek);
                    }
                }
                else { }
            }
        }


        public void ShowRechterkant()
        {
            Console.WriteLine("VoorKant:");
            foreach (Rij r in RechterKant.GetVoorkantRijen())
            {
                if (r.RijContainers().Count > 0)
                {
                    Console.WriteLine("Rij:");
                    foreach (Container c in r.RijContainers())
                    {

                        Console.WriteLine(c.ContainerType + ":" + c.ContainerPlek);
                    }
                }
                else { }

            }
            Console.WriteLine("AchterKant:");
            foreach (Rij r in RechterKant.GetAchterkantRijen())
            {
                if (r.RijContainers().Count > 0)

                {
                    Console.WriteLine("Rij:");
                    foreach (Container c in r.RijContainers())
                    {
                        Console.WriteLine(c.ContainerType + ":" + c.ContainerPlek);
                    }
                }
                else { }

            }
        }

        public void SetMaxGewicht_AchterEnVoorkant()
        {
            double Max;

            Max = (LinkerKant.MaxGewicht * 50) / 100;
            LinkerKant.SetMaxGewichtAchterkant(Max);
            LinkerKant.SetMaxGewichtVoorkant(Max);

            Max = (RechterKant.MaxGewicht * 50) / 100;
            RechterKant.SetMaxGewichtAchterkant(Max);
            RechterKant.SetMaxGewichtVoorkant(Max);

        }

        public List<Rij> GetVoorkantListLinkerKant() => LinkerKant.GetVoorkantRijen();

        public List<Rij> GetAchterkantListLinkerKant() => LinkerKant.GetAchterkantRijen();

        public List<Rij> GetVoorkantListRechterKant() => RechterKant.GetVoorkantRijen();

        public List<Rij> GetAchterkantListRechterKant() => RechterKant.GetAchterkantRijen();



        public void Set_MaxGewicht_linkerKant(double gewicht) => LinkerKant.Set_MaxGewicht(gewicht);

        public void Set_MaxGewicht_RechterKant(double gewicht) => RechterKant.Set_MaxGewicht(gewicht);



        public void Set_MaxGewicht_Voorkant_Linkerkant(double gewicht) => LinkerKant.Set_MaxGewicht_Voorkant(gewicht);

        public void Set_MaxGewicht_Achterkant_LinkerRechter(double gewicht) => LinkerKant.Set_MaxGewicht_Achterkant(gewicht);


        public void Set_MaxGewicht_Voorkant_RechterKant(double gewicht) => RechterKant.Set_MaxGewicht_Voorkant(gewicht);

        public void Set_MaxGewicht_Achterkant_RechterKant(double gewicht) => RechterKant.Set_MaxGewicht_Achterkant(gewicht);



        public void addRij_Voorkant_LinkerKant(Rij rij) => LinkerKant.addRij_Voorkant(rij);

        public void addRij_Voorkant_RechterKant(Rij rij) => RechterKant.addRij_Voorkant(rij); 



   



       // public void Set_MaxGewicht_Achterkant_Rechterkant(double gewicht) => RechterKant.Set_MaxGewicht_Achterkant(gewicht);


        public void addRij_Achterkant_LinkerKant(Rij rij) => LinkerKant.addRij_Achterkant(rij);

        public void addRij_Achterkant_RechterKant(Rij rij) => RechterKant.addRij_Achterkant(rij);










    }
}
