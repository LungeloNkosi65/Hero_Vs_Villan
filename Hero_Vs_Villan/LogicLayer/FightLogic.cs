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
        private string input = "";
        private  int input1;
        private int fighterId = 0;
        private int challengerId = 0;
        public static List<Character> Heros1;
        public static List<Character> Vilans1;
        SuperPowrLogic superPowr = new SuperPowrLogic();
        public FightLogic()
        {
            Heros1 = new List<Character>() {
                new SuperHero(1,"Logan",70,50,90,270,SuperPowrLogic.GetPowers()),
                new SuperHero(2,"Iron Man",70,50,80,340,SuperPowrLogic.GetPowers()),
                new SuperHero(3,"Wolverine",70,50,80,300,SuperPowrLogic.GetPowers()),
            };
            Vilans1 = new List<Character>() {
                new Vilan(1,"Jocker",70,50,90,200,SuperPowrLogic.GetVilanPowers()),
                new Vilan(2,"Thanos",70,50,80,500,SuperPowrLogic.GetVilanPowers()),
                new Vilan(3,"Sand Man",70,50,80,450,SuperPowrLogic.GetVilanPowers()),
            };

        }
        public void Start()
        {
            Console.WriteLine($"Who would you like to be \n (1) Vilan \n (2) SuperHero");
            do
            {
                input = Console.ReadLine();
                if (input.All(Char.IsDigit))
                {
                    input1 = ValidationLogic.ConvertValue(input);
                    break;
                }
                ValidationLogic.InvalidIpnut();
            } while (true);

            if (input1 == 1)
            {
                GetFigthers(Vilans1, Heros1);
            }
            else if (input1 == 2)
            {
                GetFigthers(Heros1, Vilans1);
            }
        }
        public static void ListCharacters(List<Character> character)
        {
            Console.WriteLine("Available Characters\n___________________________________________|-|__________________________________________");
            foreach (var item in character)
            {
                Console.WriteLine($" Id : {item.Id} \n Name : {item.Name} \n Total Power : {item.TotalImpact}  \n Powers : ");
                item.DisplayPowers();
                Console.WriteLine();
            }
        }
        public void GetFigthers(List<Character> fighter, List<Character>  challenger)
        {
            Console.WriteLine($"\n Select your fight to with from the following :");
            ListCharacters(fighter);
            do
            {
                input = ReadLines();
                if (ValidationLogic.CheckDegit(input))
                {
                    input1 = ValidationLogic.ConvertValue(input);
                    if (!(fighter.Find(x => x.Id == input1) == null))
                    {
                        fighterId = input1;
                        Console.WriteLine($"\n Select Oponent from the following To fight with");
                        ListCharacters(challenger);

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
                    if (!(challenger.Find(x => x.Id == input1) == null))
                    {
                        challengerId = input1;
                        //now fight can begit
                        if (GetStrenght(fighterId,fighter) < GetStrenght(challengerId,challenger))
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
        public double GetStrenght(int id, List<Character> characters)
        {
            var strenght = characters.Find(x => x.Id == id).TotalImpact;
            return strenght;
        }
        public string ReadLines()
        {
            string input = "";
            input = Console.ReadLine();
            return input;
        }
    }
}
