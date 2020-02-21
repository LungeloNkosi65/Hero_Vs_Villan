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
       
        public SuperPowrLogic()
        {
        }
        public static List<SuperPower> GetPowers()
        {
            var power = new List<SuperPower>() {
             new SuperPower("Super Kick",10),
             new SuperPower("Super Punch",20),
            new SuperPower("Khamyeya meya",100)
            };
            return power;
        }

        public static List<SuperPower> GetVilanPowers()
        {
            var power = new List<SuperPower>() {
             new SuperPower("Super Kick",10),
             new SuperPower("Super Punch",20),
            };
            return power;
        }


        public static SuperPower AcceptPowers()
        {
            SuperPower superPower = new SuperPower();
            Console.WriteLine("Enter super power");
            superPower.Power = Console.ReadLine();
            Console.WriteLine("Enter power impact");
            superPower.Impact = ValidationLogic.ConvertValue(Console.ReadLine());
            return superPower;
        }

    }
}
