using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Vs_Villan.LogicLayer
{
   public class ValidationLogic
    {
        public int Validate(int min, int max, string input)
        {
            int data;

            do
            {
                if (input.All(Char.IsDigit))
                {
                    int.TryParse(input, out data);
                    if (data >= min && data <= max)
                    {
                        return data;
                    }
                    else
                    {

                    }
                }
            } while (true);
           
            return 0;
        }

        public static void InvalidOption()
        {
            Console.WriteLine("Invalid option");
        }

        public static bool CheckDegit(string input)
        {
            bool results = false;
            if (input.All(Char.IsDigit)) { results = true; }
            return results;
        }


        public static void InvalidIpnut()
        {
            Console.WriteLine($"\n Ivalid input please enter valid value");
        }

        public static int ConvertValue(string input)
        {
            int data;
            int.TryParse(input, out data);
            return data;
        }

    }
}
