using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for user input
            Console.WriteLine("Please input a string.");

            string userInput = Console.ReadLine();


            //Create a object of MethodCall Class

            MethodCall methodCall = new MethodCall();

            //call method from MethodCall class and store in a Variable
            string subString = methodCall.getFirstBetweenBraces(userInput);

            //display the returned string to the console
            Console.WriteLine(subString);

        }
    }
}
