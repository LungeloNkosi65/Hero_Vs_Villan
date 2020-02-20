using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.Models
{
    public class SuperHero : Character
    {
        public SuperHero() { }
        public SuperHero(int id,string name, int health, int ability, int strenght, int superPower,double totalImpact) :base(id,name,health,ability,strenght, superPower,totalImpact)
        { }
        public override double Attack()
        {
            return (CalcImpact() * 0.7);
        }

        public override double CalcImpact()
        {
            return ((Health + Ability + Strenght + SuperPower) * 2);
        }

        public override double Defend()
        {
            return CalcImpact() *0.6;
        }
    }
}
