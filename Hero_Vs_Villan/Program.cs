using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hero_Vs_Villan.LogicLayer;
using Hero_Vs_Villan.Models;


namespace Hero_Vs_Villan
{
    class Program
    {
        static void Main(string[] args)
        {
            var fight = new FightLogic();
            var addCharacter = new CharacterLogic();
            //fight.Start();
            addCharacter.CreateCharacter();
            Console.ReadKey();
        }
    }
}
