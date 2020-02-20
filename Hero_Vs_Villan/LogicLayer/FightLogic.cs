using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hero_Vs_Villan.Models;

namespace Hero_Vs_Villan.LogicLayer
{
    public class FightLogic
    {
        public static List<SuperHero> Heros;
        public static List<Vilan> Vilans;


        public FightLogic()
        {
            Heros = new List<SuperHero>() { 
                new SuperHero(1,"Logan",70,50,90,60,270),
                new SuperHero(2,"Iron Man",70,50,80,70,340),
                new SuperHero(3,"Wolverine",70,50,80,70,300),
            };
            Vilans = new List<Vilan>() {
                new Vilan(1,"Jocker",70,50,90,60,200),
                new Vilan(2,"Thanos",70,50,80,70,500),
                new Vilan(3,"Sand Man",70,50,80,70,450),
            };
        }
        public void Start()
        {
            string input = "";
            int input1;
            int fighterId = 0;
            int challengerId = 0;

            Console.WriteLine($"Who would you like to be \n (1) Vilan \n (2) SuperHero");
            do
            {
                input = Console.ReadLine();
                if (input.All(Char.IsDigit))
                {
                    int.TryParse(input, out input1);
                    break;
                }
                ValidationLogic.InvalidIpnut();
            } while (true);

            if (input1 == 1)
            {
                Console.WriteLine($"\n Select vilan to fight with from the following :\n");
                ListVilans();
                do
                {
                    input = ReadLines();
                    if (ValidationLogic.CheckDegit(input))
                    {
                        int.TryParse(input, out input1);
                        if ( ! (Vilans.Find(x => x.Id == input1) == null))
                        {
                            fighterId = input1;
                            Console.WriteLine($"\n Select Oponent from the following To fight with\n");
                            ListHeros();
                            break;
                        }
                        else
                        {
                            ValidationLogic.InvalidOption();
                        }
                    }
                    //ValidationLogic.InvalidIpnut();
                } while (true);
                //after selecting fighter and oponent

                do
                {
                    input = ReadLines();
                    if (ValidationLogic.CheckDegit(input))
                    {
                        input1 = ValidationLogic.ConvertValue(input);
                        if (!(Heros.Find(x => x.Id == input1) == null))
                        {
                            challengerId = input1;
                            //now fight can begit
                            if (getVilanStrength(fighterId) < getHeroStrength(challengerId))
                            {
                                Console.WriteLine("\n ---------------------------Game Over-----------------------------------------------------------------\n" +
                                    "Sorry you lost yuor challenger was more powerfull than you");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\n ---------------------------Game Over-----------------------------------------------------------------\n " +
                                    $"Congratulations you won!!!!!!!!!!!!");
                                break;
                            }
                            
                        }
                    }

                } while (true);
            }
            else if (input1 == 2)
            {
                Console.WriteLine("Super Heros are still coming............................");
            }

        }

      

        public void ListVilans()
        {
            Console.WriteLine("Available Vilans");
            foreach (var item in Vilans)
            {
                Console.WriteLine($"\n Id : {item.Id} \n Name : {item.Name} \n Total Power : {item.TotalImpact}");
            }
        }
        public void ListHeros()
        {
            Console.WriteLine("\n Available Super Heros \n");
            foreach (var item in Heros)
            {
                Console.WriteLine($"\n Id : {item.Id} \n Name : {item.Name} \n Total Power : {item.TotalImpact}");
            }
        }

        public double getVilanStrength(int id)
        {
            var strenght = Vilans.Find(x => x.Id == id).TotalImpact;
            return strenght;
        }


        public double getHeroStrength(int id)
        {
            var strenght = Heros.Find(x => x.Id == id).TotalImpact;
            return strenght;
        }
        public string ReadLines()
        {
            string input="";
            input=Console.ReadLine();
            return input;
        }
    }
}
