public delegate int AdditionDelegate(int number1, int number2);

public class DelegateMethodClass
{
    public delegate void Callback(string message);

    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
}
