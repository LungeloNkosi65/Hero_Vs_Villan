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
        public string Name { get; set; }
        public int Health { get; set; }
        public int Ability { get; set; }
        public int Strenght { get; set; }
        public int SuperPower { get; set; }
        public double TotalImpact { get; set; }
        public Character() { }
        public Character(int id,string name,int health,int ability,int strenght,int superPower)
        {
            Id = id;
            Name = name;
            Health = health;
            Ability = ability;
            Strenght = strenght;
            SuperPower = superPower;
        }
        public Character(int id, string name, int health, int ability, int strenght, int superPower,double totalImpact)
        {
            Id = id;
            Name = name;
            Health = health;
            Ability = ability;
            Strenght = strenght;
            SuperPower = superPower;
            TotalImpact = totalImpact;
        }
        public abstract double Attack();
        public abstract double Defend();
        public abstract double CalcImpact();

    }
}
