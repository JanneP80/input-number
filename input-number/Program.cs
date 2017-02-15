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
            
            // checs if number is odd or even or zero
            int inputnumber=0;
            string message = string.Empty;
            Console.Write("This program checks is typed number is odd/even or zero. \nType number: ");
            bool result = int.TryParse(Console.ReadLine(), out inputnumber);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }
            else if (inputnumber == 0) // is zero
            {
                message = string.Format("You typed number {0}, it is zero.", inputnumber);
            }
            else if (inputnumber % 2 == 0) //divided, true, is even
            {
                message = string.Format("You typed number {0} and it is even.", inputnumber);
            }
            else // else odd
            {
                message = string.Format("You typed number {0} and it is odd.", inputnumber);
            }
            Console.WriteLine(message);
            Console.ReadKey();

            // poikki tästä
            /*
            Console.Write("Type number: ");
            bool userinputnumber = Convert.ToInt32(Console.ReadLine(), out number);
			if (!userinputnumber) 
			{
				Console.WriteLine("Not a number {0}, try again.", userinputnumber);
			}

            if (userinputnumber == 0) // is zero
            {
                Console.WriteLine("Number {0} is zero.", userinputnumber);
            }
            else
				if(num % 2 == 0) //divided, true
			{
			// number is even.
			Console.WriteLine("Number {0} is even.", userinputnumber);
			
			}
			else
			{
			// number is odd.
			Console.WriteLine("Number {0} is odd.", userinputnumber);
			}
			/*  if (userinputnumber != %2) // if not 
            {
                Console.WriteLine("Number {0} is odd.", userinputnumber);
            }
            else
            if (userinputnumber == %2) // 
            {
                Console.WriteLine("Number {0} is even.", userinputnumber);
            }*/ 
            /*
            else return;
            Console.ReadKey(); */
        }
    }
}
