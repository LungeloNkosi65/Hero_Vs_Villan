using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.Models
{
    public class SuperPower
    {
        public int Id { get; set; }
        public string Power { get; set; }
        public int Impact { get; set; }
        public SuperPower() { }
        public SuperPower(int id,string power,int impact)
        {
            Id = id;
            Power = power;
            Impact = impact;
        }
    }
}
