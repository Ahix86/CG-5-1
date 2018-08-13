using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // ask user for first name and assign to variable
                Console.WriteLine("Please enter your first name");
                string FirstName = Console.ReadLine();


                // ask user for last name
                Console.WriteLine("Please enter your last name");
                string LastName = Console.ReadLine();

                //create variable that combine two use inputs into one 'item'
                string FullName = (FirstName + " " + LastName);

                // Put output together using the two item variable
                Console.WriteLine($"Hi, {FullName}! Nice to meet you!");
                Console.ReadLine();

            }
        }
        // setting the method to call on in the above output
        private static string FullName(string FirstName, string LastName)
        {
            string FullName = FirstName + " " + LastName;

            return FullName;
        }
    }
}