using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            int mySecondInt = 10;

            if (myInt < mySecondInt)
            {
                myInt += 10;
            }

            Console.WriteLine(myInt);

            string myCar = "audi";
            string myCapitalizedCar = "Audi2";

            if(myCar == myCapitalizedCar){
                Console.WriteLine("Equal");
            }
            else if( myCar == myCapitalizedCar.ToLower())
            {
                Console.WriteLine("Equal without case sensitivity");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            switch(myCar)
            {
                case "audi":
                    Console.WriteLine("Lowercase");
                case "Audi":
                    Console.WriteLine("Uppercase");
                default:
                    Console.WriteLine("");
            }
        }
    }
}