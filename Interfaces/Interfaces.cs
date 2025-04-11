namespace CSharpBasics.Interfaces;
interface ICustomer{
    int CustomerId { get; set; }

    void ApplyLoyaltyDiscount(){
        Console.WriteLine("Apply discount");
    }
}

class VIPCustomer : ICustomer
{
    public int CustomerId { get; set; }

    void ICustomer.ApplyLoyaltyDiscount()
    {
       Console.WriteLine($"10% discount for {CustomerId}");
    }
}

public class Car : IEquatable<Car>
{
    public bool Equals(Car obj)
    {
        throw new NotImplementedException();
    }
}

public interface IDrive
{
    //can contain bodyless methods... acts as a contract that every class that implementst it believes
    public string Drift();
}

public interface IDance
{
    public string DubStep();
}

public class Sam : IDrive, IDance
{
    public string Drift()
    {
        string? response = "I can drift!";
        return  response;
    }

    public string DubStep()
    {
        string? response = "I can dance";
        return response;
    }

    string dance;
    string drive;

    public Sam(string drivecar, string dancefast)
    {
        drive = drivecar;
        dance = dancefast;
    }

    string IDance.DubStep()
    {
        return drive;
    }

    string IDrive.Drift()
    {
        return dance;
    }
    
}





// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Sam sam = new Sam();
//         IDance dance = sam;
//         IDrive drive = sam;
        
//         dance.DubStep();
//         drive.Drift();
//     }
// }