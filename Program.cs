using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Drill_75
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Anonymous Income Comparison Program

            Console.WriteLine("Car Insurance Approval Program");

            ////User Input
            int age;
            string dui;
            int tickets;


            Console.WriteLine("What is your age?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");

            dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");

            tickets = Convert.ToInt32(Console.ReadLine());

            ////Insurance Approval Standard

            bool minimumage = 15 < age;
            bool duistatus = (dui == "no");
            bool amounttickets = 3 > tickets ;
            bool qualified;

            qualified =  (minimumage && duistatus && amounttickets);
            Console.WriteLine("Are You Qualified For Insurance: ");
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    
    }
}
