using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend_Practice_081917
{
    class Program
    {
        static void Main(string[] args)
        {// If/Than Conditionals: Age restriction 
         //int userAge;
         //Console.WriteLine("Please enter Your age");
         //userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 17)
            //{ Console.WriteLine("you are " + userAge + ", and are old enough to see this movie."); }
            //else
            //{ Console.WriteLine("you are " + userAge + ", and are not old enough to see this movie."); }

            //Donation Tracker Redo

            //User input of computer requests
            Console.WriteLine("What is your full name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ". Please enter your address.");
            string userAddress = Console.ReadLine();
            Console.WriteLine("Please enter your email address.");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Please enter the fiscal year.");
            string year = Console.ReadLine();
            Console.WriteLine("How many $5 bills are you donating?");
            int numberOfFives = int.Parse(Console.ReadLine());
            Console.WriteLine("How many $10 bills are you donating?");
            int numberOfTens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many $20 bills are you donating?");
            int numberOfTwenties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many $50 bills are you donating?");
            int numberOfFifties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many $100 are you donating?");
            int numberOfHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("How many $0.25 are you donatining?");
            int numberOfQuarters = int.Parse(Console.ReadLine());

            //Donation Formula
            float totalDonation = (numberOfFives * 5) + (numberOfTens * 10) + (numberOfTwenties  * 20) + (numberOfFifties * 50) + 
                (numberOfHundreds * 100) + (numberOfQuarters * .25f);

            //Receipt Print out
            Console.WriteLine("Here is your receipt");
            Console.WriteLine(userName);
            Console.WriteLine(userAddress);
            Console.WriteLine(userEmail);
            Console.WriteLine(year);
            Console.WriteLine("You donated: $" + totalDonation);
            Console.WriteLine("Thank you for your donation.");

            
                         






        }
    }
}
