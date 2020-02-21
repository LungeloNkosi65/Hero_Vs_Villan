using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.Models
{
    public enum CharacterTypes
    {
        Vilan,
        SuperHero
    }
   public abstract class Character 
    {
        public int Id { get; set; }
        private static int AccumilatedID { get; set; } = 0;
        public string Name { get; set; }
        public int Health { get; set; }
        public int Ability { get; set; }
        public int Strenght { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
        public double TotalImpact { get; set; }
        public Character() {
            AccumilatedID++;
            SuperPowers = new List<SuperPower>();

        }
        public Character(int id,string name,int health,int ability,int strenght)
        {
            Id = AccumilatedID;
            Name = name;
            Health = health;
            Ability = ability;
            Strenght = strenght;
        }
        public Character(int id, string name, int health, int ability, int strenght,double totalImpact, List<SuperPower> superPowers)
        {
            Id = id;
            Name = name;
            Health = health;
            Ability = ability;
            Strenght = strenght;
            TotalImpact = totalImpact;
            SuperPowers = superPowers;
        }
        public abstract double Attack();
        public abstract double Defend();
        public abstract double CalcImpact();
        public void DisplayPowers() {
            foreach (var item in SuperPowers)
            {
                Console.Write($"\n{item.Power}");
            }
            Console.WriteLine();
        }
    }
}
