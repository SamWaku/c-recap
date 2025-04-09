using System;

namespace CSharpBasics
{
    public class FirstLastCharacter
    {
        public void SwapFirstLastCharacter(string name)
        {
            Console.WriteLine("Enter word");
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char first = input[0];
                string firstletter = input[0].ToString();
                // string firstword = input
                Console.WriteLine($"Hi {first}");
            }

            else
            {
                Console.WriteLine("No input provided!");
            }
            
            // string wordindex = temp.Length.ToString();
            // string[] firstletter = wordindex[0];
        }
    }
    public class SwapNumbers
    {
        public void SwapTwoNumbers(int input1, int input2)
        {
            Console.WriteLine($"Original numbers \n number1: {input1}, number2: {input2}");

        int temp = input1;
        input1 = input2;
        input2 = temp;

        Console.WriteLine($"Swapped numbers \n number1: {input1}, number2: {input2}");
        }
    }
    public class WeatherLoop
    {
        static string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        private int number = 5;
        static int carindex = 0;

        public static void ForEachLoop()
        {
            foreach (string car in cars)
            {
                
                Console.WriteLine(car);
                if(carindex != cars.Length -1)
                {
                    carindex++;
                    Console.WriteLine("You are almost there");
                    continue;
                }
                Console.WriteLine($"This is your last car {carindex.ToString(car)}");
                carindex++;
                
            }
            Console.WriteLine("ForEach Loop \n");
        }
        public static void ForLoop()
        {
            for (int i = 5; i <= 10; i++)
            {
                
                Console.WriteLine($"Outer {i++}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"Innter {j++}");
                }
            }
            Console.WriteLine("For Loop\n");
        }

        

        public void WhileLoop()
        {
            while(number <= 10)
            {
                Console.WriteLine(number);
                number++;
                
            }
            Console.WriteLine("While loop\n");
        }

        public void DoWhileLoop()
        {
            do
            {
                Console.WriteLine($"{number}");
                number++;
            }
            while(number <= 10);
            Console.WriteLine("DoWhile loop\n");
        }
    }
    public class Weather
    {
        static int number = 1;
        public static void DisplayWeather()
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Summer");
                    break;
                case 2:
                    Console.WriteLine("Cold");
                   break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
    public class OddOrEven
    {
        public int[] evenNumbers = {2, 4, 6, 8, 10};
        public int[] oddNumbers = {0, 3, 5, 7, 9, 11};

        int number = 7;

        public void DetermineOddOrEven()
        {
           
            if (evenNumbers.Contains(number))
            {
                Console.WriteLine($"{number} is an Even number");
            }
            else if (oddNumbers.Contains(number))
            {
                Console.WriteLine($"{number} is and Odd number");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }

        
    }
    class Conditionals
    {
        public static int age = 30;
        int voterage = 16;
        // int enterAge = Console.ReadLine("Enter Age: {0}", age);
        public  void FinalCondition(int age)
        {
            if(age > voterage)
            {
                Console.WriteLine("Candidate can vote");
            } else{
                Console.WriteLine("Canditage must be above 18");
            }
        }
    }
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    public class Person
    {
        public required string FirstName { get; set;}
        public required string LastName { get; set;}
        // public void DisplayNames(string FirstName, string LastName)
        // {
        //     FirstName = FirstName;
        //     LastName = LastName;
        // }
    }

    public class Container
    {
        public int _capacity = 10;//set it to public
    }
    public class Basics
    {
        // public static void Display()
        // {

        //     Console.WriteLine("Variables: {0}, {1}", name1, age);
        // }

        // static method is not an instance but regarded as part of the class
        // public void Display()
        // {

        //     Console.WriteLine("Variables: {0}, {1}", name1, age);
        // }

        // static string name1 = "Samuel";
        // static int age = 23;

        public int TripleSum(int number1, int number2 )
        {
           if(number1 == number2)
           {
            int sum = number1 + number2;
            int triple = sum * 3;
            Console.WriteLine($"Value of triple: {triple}");
           }
           else
           {
            int sum = number1 + number2;
            Console.WriteLine($"Value of normal sum: {sum}");
           }
            int optimized = number1 == number2 ? (number1 + number2) * 3 : number1 + number2;
            
           return optimized;
        }

    }
    
    public class Program
    {
        static void Main(string[] args)
        {
        // calling a static method
        //    Basics.Display();

        // // object as a reference of a class
        // Basics basics= new Basics();

        // //new object referenceing the previous object
        // Basics basics1 = basics;
        // basics.Display();

        // Container container= new Container();
        // Console.WriteLine(container._capacity);

        // Person person= new Person(){
        //     FirstName = "Samuel",
        //     LastName = "Wakumelo"
        //    };

        //    Console.WriteLine($"{person.FirstName}, {person.LastName}"); //why cant you pass to arguments here
        
        // //Condtionals
        // Conditionals conditionals= new Conditionals();
        // conditionals.FinalCondition(10);
        // Console.WriteLine($"Conditional Age: {Conditionals.age}");

        // OddOrEven oddOrEven = new OddOrEven();
        // oddOrEven.DetermineOddOrEven();

        // Weather.DisplayWeather();


        // WeatherLoop.ForEachLoop();         
        // WeatherLoop.ForLoop();
        // WeatherLoop whileloop = new WeatherLoop();
        // whileloop.WhileLoop();

        // WeatherLoop dowhileloop = new WeatherLoop();
        // dowhileloop.DoWhileLoop();

        // SwapNumbers swapNumbers = new SwapNumbers();
        // swapNumbers.SwapTwoNumbers(3,4);
       
        // FirstLastCharacter firstLastCharacter = new FirstLastCharacter();
        // firstLastCharacter.SwapFirstLastCharacter("Samuel");

        // Basics basics = new Basics();
        // basics.Addition(2, 5);

        Basics basics = new Basics();
        basics.TripleSum(2,2);
        Console.WriteLine($"Optimized {basics.TripleSum(3,4)}");
        }
    }
}