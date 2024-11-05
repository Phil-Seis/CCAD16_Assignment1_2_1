using System.ComponentModel;

namespace CCAD16_Assignment1_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            //If statement to compare 2 parameters

            Console.WriteLine("------------------------");
            Console.WriteLine("|--COMPARISON PROGRAM--|");
            Console.WriteLine("------------------------");
            Console.WriteLine("Input 1st number: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Input 2nd number:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("You entered the following numbers: " + value1 + " and " + value2);

            if (value1 != value2)
            {
                Console.WriteLine("Sorry, your values are NOT equal to each other");
            }
            else
            {
                Console.WriteLine("Congratulations, your values ARE equal to each other!");
            }
        }
    }
}
