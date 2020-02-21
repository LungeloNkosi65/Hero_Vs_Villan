﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.Models
{
    public class Vilan:Character
    {
        public Vilan() { }
        public Vilan(int id,string name, int health, int ability, int strenght, double totalImpact, List<SuperPower> superPowers) : base(id,name, health, ability, strenght, totalImpact,superPowers)
        { }
        public override double Attack()
        {
            Console.WriteLine("This guy attacked");
            return CalcImpact()*0.3;
        }

        public override double CalcImpact()
        {
           
            return ((Health + Ability + Strenght));
        }

        public override double Defend()
        {
            return (CalcImpact()*0.2);
        }
    }
}
