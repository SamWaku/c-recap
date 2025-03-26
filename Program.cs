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

        }
    }
}