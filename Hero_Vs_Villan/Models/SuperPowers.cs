using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.Models
{
    public class SuperPower
    {
        public string Power { get; set; }
        public int Impact { get; set; }
        public SuperPower() { }
        public SuperPower(string power,int impact)
        {
            Power = power;
            Impact = impact;
        }
        
    }
}
