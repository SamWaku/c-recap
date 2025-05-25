using System;
using System.Runtime.InteropServices;
using System.Text;

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

        public string TerniaryOperators()
        {
            Console.WriteLine("Enter first name: ");
            string name1 = Console.ReadLine(); 

            Console.WriteLine("Enter second name: ");
            string name2 = Console.ReadLine(); 

            string response1 = "Names are the same";
            string response2 = "Names are not the same";

            Console.WriteLine($"You entered: {name1} and {name2}");

            string result = name1 == name2 ? response1 : response2;

            return result;
        }


    }
    
    public record RecordTest(string FirstName, string LastName, string Id)
    {
       public readonly string Id  = Id;
    }
    // basics
    public class ConstructorExpressionBodyMember
    {
        private string? name;

        public ConstructorExpressionBodyMember(string FirstName) => Name = FirstName;
        
            public string Name
            {
                get => name;
                set => name = value;
            }
        
    }

    public interface IDrive
    {
        //can contain bodyless methods... acts as a contract that every class that implementst it believes
        public void Drift();
    }
    public interface IDance
    {
        public void DubStep();
    }

    public class Sam : IDrive, IDance
    {
        public void Drift()
        {
            Console.WriteLine("I can drift!");
        }

        public void DubStep()
        {
            Console.WriteLine("I can dance");
        }
    }

    public class Car : IDrive
    {
        //store car
        public void StoreCar()
        {
            Console.WriteLine("Car has been added!");
        }

        //view car
        public void ViewCar()
        {
            Console.WriteLine("Can view car");
        }

        //delete car
        public void DeleteCar()
        {
            Console.WriteLine("Delete car!");
        }

        public void Drift()
        {
            Console.WriteLine("Drifted sideways");
        }
    }
    public interface ICook
    {
        //Things "I" can cook
        public void Nshima();
        public void Pasta();
        public void Goat();
        public void Rice();
        public string Beef();
        public void Chicken();
        public void Pork();
    }
    public class Pumulo : ICook
    {
        public string ReturnBeef(string? word)
        {
            Console.ReadLine();
            return word;
        }

        public string Beef()
        {
            throw new NotImplementedException();
        }

        public void Chicken()
        {
            Console.WriteLine("I can cook Chicken");
        }

        public void Goat()
        {
            Console.WriteLine("I can cook Goat Meat");
        }

        public void Nshima()
        {
            Console.WriteLine("I can cook Nshima");
        }

        public void Pasta()
        {
            Console.WriteLine("I can cook Pasta");
        }

        public void Pork()
        {
            Console.WriteLine("I can cook Pork");
        }

        public void Rice()
        {
            Console.WriteLine("I can cook Rice");
        }
    }
    public class Summation
    {

        public int AddingTwoNumbers(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
    }

    public class DelegateMethodClass
    {
        public delegate void Callback(string message);

        public string  DelegateMethod(string message)
        {
            return message;
        }

        public  void MethodWithCallback(string message, Callback callback)
        {
            callback("The word of the day is: " + message);
        }  
    }

    public class DateTimeConversion
    {

    }

    // public static class RefClass
    // {
    //     static string x = "Old Value";
    //     static ref
    // }

    public static class NormalClass
    {
        public static void Foo2(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
        public static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
    }

    public static class ReflClass
    {
        public static void Foo2(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
        public static void Foo(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
    }

    // Primary constructors
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

            // Basics basics = new Basics();
            // basics.TripleSum(2,2);
            // string result = basics.TerniaryOperators();
            // Console.WriteLine(result);
            // Console.WriteLine($"Optimized {basics.TripleSum(3,4)}");

            /*records*/
            // RecordTest recordTest = new RecordTest("Samuel", "Wakumelo", "123");
            // Console.WriteLine(recordTest.Id);

            /*primary constructors*/
            // PrimaryContructorClass<int> primaryContructorClass  = new PrimaryContructorClass<int>("My Box") {Contents = 123};
            // Console.WriteLine($"{primaryContructorClass.Contents} + {primaryContructorClass.Label}");

            // Sam sam = new Sam();
            // IDance dance = sam;
            // IDrive drive = sam;

            // dance.DubStep();
            // drive.Drift();

            // Summation summation = new Summation();
            // int sum = summation.AddingTwoNumbers(2, 5);
            // Console.WriteLine(sum);

            // Box box = new Box(2f, 4f);
            // IDemension demension = box;
            // Console.WriteLine($"Length: {demension.GetLength()}");
            // Console.WriteLine($"Width: {demension.GetWidth()}");

            //instiatiating an implicit interface
            // Box box = new Box(2f,3f);
            // Console.WriteLine($"Length: {box.GetLength()}");
            // Console.WriteLine($"Width: {box.GetWidth()}");
            // DelegateMethodClass delegateMethodClass = new DelegateMethodClass();
            // static void MyCallback(string msg)
            // {
            //     Console.WriteLine(msg);
            // }

            // var response = new DelegateMethodClass();
            // response.MethodWithCallback("hi", MyCallback);
            // Random random = new Random();
            // random.Next();

            // DateTime todaysYear = DateTime.UtcNow;


            // DateTime utcTime1 = new DateTime(DateTime.UtcNow.Year, 5, 15, 0, 0, 0);
            // utcTime1 = DateTime.SpecifyKind(utcTime1, DateTimeKind.Utc);
            // DateTimeOffset utcTime2 = utcTime1;
            // Console.WriteLine($"Converted: {utcTime1} {utcTime1.Kind} to a DateTimeOffset value of {utcTime2}");
            // }

            // Car car = new Car();
            // car.StoreCar();
            // car.ViewCar();
            // car.DeleteCar();
            // car.Drift();
            // Pumulo pumulo = new Pumulo();
            // pumulo.Nshima();
            // pumulo.Chicken();
            // pumulo.Beef();
            // pumulo.Pasta();
            // pumulo.Rice();
            // pumulo.Goat();
            // pumulo.Pork();
            // pumulo.ReturnBeef("Hello");

            int x = 8;
            NormalClass.Foo(x);
            Console.WriteLine(x);

            StringBuilder sb = new StringBuilder();
            NormalClass.Foo2(sb);
            Console.WriteLine(sb.ToString());

            //ref modifier
            int xref = 8;
            ReflClass.Foo(ref xref);
            Console.WriteLine(xref);
        }
    }
}