using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int userNumber = int.Parse(Console.ReadLine());
            //save user-entered integer as variable
            while (true)
            {
                if (userNumber%3 == 0)
                {
                    Console.WriteLine("You won!");
                    break;
                    //if integer is evenly divided by 3, user wins and loop stops
                }
                Console.WriteLine("You lost. Please enter another number.");
                userNumber = int.Parse(Console.ReadLine());
                //if integer is not evenly divided by 3, loop continues with another number
            }
            Console.ReadKey();
        }
    }
}
