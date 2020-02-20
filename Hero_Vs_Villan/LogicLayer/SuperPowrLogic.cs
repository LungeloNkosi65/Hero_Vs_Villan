using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hero_Vs_Villan.Models;

namespace Hero_Vs_Villan.LogicLayer
{
   public class SuperPowrLogic
    {
        public static List<SuperPower> superPowers;
        public SuperPowrLogic()
        {
            superPowers = new List<SuperPower>() {
            new SuperPower(1,"Super Kick",10),
                new SuperPower(2,"Super Punch",20),
                new SuperPower(3,"Khamyeya meya",100)
            };
        }


        public static int GetImpact(int id)
        {
            foreach (var item in superPowers)
            {
                if (item.Id == id)
                {
                    return id;
                }
            }
            return 0;
        }
    }
}
