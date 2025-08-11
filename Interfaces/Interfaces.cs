// namespace CSharpBasics.Interfaces;
// interface ICustomer{
//     int CustomerId { get; set; }

//     void ApplyLoyaltyDiscount(){
//         Console.WriteLine("Apply discount");
//     }
// }

// class VIPCustomer : ICustomer
// {
//     public int CustomerId { get; set; }

//     void ICustomer.ApplyLoyaltyDiscount()
//     {
//        Console.WriteLine($"10% discount for {CustomerId}");
//     }
// }

// public class Car : IEquatable<Car>
// {
//     public bool Equals(Car obj)
//     {
//         throw new NotImplementedException();
//     }
// }

// public interface IDrive
// {
//     //can contain bodyless methods... acts as a contract that every class that implementst it believes
//     public string Drift();
// }

// public interface IDance
// {
//     public string DubStep();
// }

// public class Sam : IDrive, IDance
// {
//     public string Drift()
//     {
//         string? response = "I can drift!";
//         return  response;
//     }

//     public string DubStep()
//     {
//         string? response = "I can dance";
//         return response;
//     }

//     string dance;
//     string drive;

//     public Sam(string drivecar, string dancefast)
//     {
//         drive = drivecar;
//         dance = dancefast;
//     }

//     string IDance.DubStep()
//     {
//         return drive;
//     }

//     string IDrive.Drift()
//     {
//         return dance;
//     }
    
// }

// //An interface member that is explicitly implemented cannot be accessed from a class instance
//         interface IDemension
//         {
//             float GetLength();
//             float GetWidth();
//         }
//             class Box : IDemension
//         {
//         float _lengthInches;
//         float _widthInches; 

//         public Box(float length, float width)
//         {
//             _lengthInches = length;
//             _widthInches = width;
//         }

//         float IDemension.GetLength()
//         {
//             return _lengthInches;
//         }

//         float IDemension.GetWidth()
//         {
//             return _widthInches;
//         }
        
//     }

//     interface IDemensionImplict
//     {
//         float GetLength();

//         float GetWidth();
//     }

//     class BoxImplicit : IDemension
//     {

//         float _length;
//         float _width;


//         public BoxImplicit(float length, float width)
//         {
//             _length = length;
//             _width = width;
//         }
//         public float GetLength()
//         {
//             return _length;
//         }

//         public float GetWidth()
//         {
//             return _width;
//         }
//     }




// // public class Program
// // {
// //     public static void Main(string[] args)
// //     {
// //         Sam sam = new Sam();
// //         IDance dance = sam;
// //         IDrive drive = sam;
        
// //         dance.DubStep();
// //         drive.Drift();
// //     }
// // }