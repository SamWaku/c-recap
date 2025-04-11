// namespace CSharpBasics;


public class PrimaryContructorClass<T>(string label)
{
    public string Label {get;} = label;
    public T? Contents { get; init; }

    // //old way
    // public string Label {get;}
    // public T? Contents { get; init;}

    // public PrimaryContructorClass(string label)
    // {
    //     Label = label;
    // }
}


public class ConstructorExample{
    private string first;
    private string last;
    ConstructorExample(string FirstName, string LastName)
    {
        first = FirstName;
        last = LastName;
    }
}

class Program
{
    
}
