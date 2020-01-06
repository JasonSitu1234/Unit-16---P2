//The system is where the code is
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CL_Calculator

    //All the code is done inside the class program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("C# Calculator");
            Console.WriteLine("");

            while (true)

                //This is where you type your first number on the system
            {  
                Console.Write("Input First Number: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());


                //This is where you type your first number on the system
                Console.Write("Input Second Number: ");
                decimal secondNum = Convert.ToDecimal(Console.ReadLine());


                //This is for adding, subtracting, multiplying and dividing 
                Console.WriteLine("");
                Console.WriteLine("Input '1' to add the numbers");
                Console.WriteLine("Input '2' to subtract the numbers");
                Console.WriteLine("Input '3' to multiply the numbers");
                Console.WriteLine("Input '4' to divide the numbers");
                Console.WriteLine("");


                //This will convert a bas data type
                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {

                 //Add the numbers
                    case 1:
                        double addNumbers = Convert.ToDouble(firstNum + secondNum);
                        Console.WriteLine("\nYour answer is: " + (addNumbers));
                        break;

                 //Subtract the numbers
                    case 2:
                        double subNumbers = Convert.ToDouble(firstNum - secondNum);
                        Console.WriteLine("\nYour answer is: " + (subNumbers));
                        break;
                 //Multiple the numbers
                    case 3:
                        double multiNumbers = Convert.ToDouble(firstNum * secondNum);
                        Console.WriteLine("\nYour answer is: " + (multiNumbers));
                        break;
                 //Divide the numbers
                    case 4:
                        double divNumbers = Convert.ToDouble(firstNum + secondNum);
                        Console.WriteLine("\nYour answer is: " + (divNumbers));
                        break;
                }

                //If they did not put 1-4 then it will print out "Press any key to restart the calculator"
                Console.WriteLine("");
                Console.WriteLine("Press any key to restart the calculator");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadKey();


            }


        }
    }
}
