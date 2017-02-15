using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_number
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // member variables
            // int userinputnumber;

            // checs if number is odd or even or zero

            Console.Write("Type number: ");
            int userinputnumber = Convert.ToInt32(Console.ReadLine());

            if (userinputnumber == 0) // is zero
            {
                Console.WriteLine("Number {0} is zero.", userinputnumber);
            }
            else
            if (userinputnumber != %2) // if not 
            {
                Console.WriteLine("Number {0} is odd.", userinputnumber);
            }
            else
            if (userinputnumber == %2) // 
            {
                Console.WriteLine("Number {0} is even.", userinputnumber);
            }
            else return;
            Console.ReadKey();
        }
    }
}
