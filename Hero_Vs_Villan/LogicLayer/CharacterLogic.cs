using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hero_Vs_Villan.Models;

namespace Hero_Vs_Villan.LogicLayer
{
    public class CharacterLogic
    {
        private string input = "";
        private int input1;
        private SuperHero superHero;
        private Vilan vilan;
        private SuperPower superPower;
        public static List<Character> characters { get; set; }

        public CharacterLogic()
        {
           
            characters = new List<Character>();
            superHero = new SuperHero();
            vilan = new Vilan();
            superPower = new SuperPower();
        }

        public void AddCharacter(Character character)
        {
           
            Console.WriteLine("Enter character name");
            character.Name = Console.ReadLine();
            Console.WriteLine("Eneter Health rarting from between 1 and 100");
            do
            {
                input = Console.ReadLine();
                if (ValidationLogic.CheckDegit(input))
                {
                    input1 = ValidationLogic.ConvertValue(input);
                    if (input1 > 0 && input1 <= 100)
                    {
                        character.Health = input1;
                        break;
                    }
                    else
                    {
                        ValidationLogic.InvalidIpnut();
                    }
                }
                ValidationLogic.InvalidIpnut();
            } while (true);
           

            Console.WriteLine("Eneter ability rarting from between 1 and 100");
            input = Console.ReadLine();
            if (input.All(Char.IsDigit))
            {
                int.TryParse(input, out input1);
                if (input1 > 0 && input1 <= 100)
                {
                    character.Ability = input1;
                }
            }

            Console.WriteLine("Eneter strength rarting from between 1 and 100");
            input = Console.ReadLine();
            if (input.All(Char.IsDigit))
            {
                int.TryParse(input, out input1);
                if (input1 > 0 && input1 <= 100)
                {
                    character.Strenght = input1;
                }
            }

            Console.WriteLine("Eneter 1 to add super power and 2 to finish");
            input = Console.ReadLine();
            input1 = ValidationLogic.ConvertValue(input);
            while (input1 != 2)
            {
                character.SuperPowers.Add(SuperPowrLogic.AcceptPowers());
                input1 = ValidationLogic.ConvertValue(Console.ReadLine());
                
            }

            if (ValidationLogic.CheckDegit(input))
            {
                input1 = ValidationLogic.ConvertValue(input);
                if (input1 >= 0 && input1 <= 100)
                {
                    character.Strenght = input1;
                }
            }
            Console.WriteLine($"\n Character created.....\n Overall Power : {character.CalcImpact()} \n Attack Power : {character.CalcImpact()}" +
                $"\n Defence Power : {character.Defend()} \n  Super Powers :");
            character.DisplayPowers();
            character.TotalImpact = character.CalcImpact();
            characters.Add(character);
        }
        public void CreateCharacter()
        {

            Console.WriteLine($"\n What type of character would you like to create \n (1) Super Hero \n (2) Vilan");
            
            do
            {
                input = Console.ReadLine();
                if (ValidationLogic.CheckDegit(input))
                {
                    input1 = ValidationLogic.ConvertValue(input);
                    if (input1 == 1)
                    {
                        AddCharacter(superHero);
                        break;
                    }
                    else if(input1==2)
                    {
                        AddCharacter(vilan);
                        break;
                    }
                    else
                    {
                        ValidationLogic.InvalidOption();

                    }
                }
                else
                {
                    ValidationLogic.InvalidIpnut();
                }
            } while (true);

            
        }
    }
}
