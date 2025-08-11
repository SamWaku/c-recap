using System;

// Console.WriteLine("Hi");
namespace Skeleton
{
    // class ClassDef
    // {

    // }

    // struct StructDef
    // {

    // }

    // interface IInterfaceDef
    // {

    // }

    // delegate int DelegateDef();

    // enum EnumDef
    // {

    // }

    // namespace NestedNameSpace
    // {
    //     struct NestedStruct
    //     {

    //     }
    // }

    // class Program{

    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello world!");
    //     }
    // }
    
}

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

        // string x = "Samuel";
        // string y = "Wakumelo";

        // SwapGeneric.Swap(ref x, ref y);
        // Console.WriteLine(x + y);

        // TestEnumeration testEnumeration = new TestEnumeration();
        // testEnumeration.Enumerate();

        // delegate int Transformer(int x)

        // int Square(int x){
        //     return X * X;
        // }

        // Transformer t = Square;