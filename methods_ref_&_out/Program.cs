// using System.Text;

// public static class NormalClass
//     {
//         public static void Foo2(StringBuilder fooSB)
//         {
//             fooSB.Append("test");
//             fooSB = null;
//         }
//         public static void Foo(int p)
//         {
//             p = p + 1;
//             Console.WriteLine(p);
//         }
//     }

//     public static class ReflClass
//     {
//         public static void Foo2(ref StringBuilder fooSB)
//         {
//             fooSB.Append("test");
//             fooSB = null;
//         }
//         public static void Foo(ref int p)
//         {
//             p = p + 1;
//             Console.WriteLine(p);
//         }
//     }

// public class Test
// {
//     // int x = 8;
//     // NormalClass.Foo(x);
//     // Console.WriteLine(x);

//     // StringBuilder sb = new StringBuilder();
//     // NormalClass.Foo2(sb);
//     // Console.WriteLine(sb.ToString());

//     // //ref modifier
//     // int xref = 8;
//     // ReflClass.Foo(ref xref);
//     // Console.WriteLine(xref);

//     // StringBuilder sbref = new StringBuilder();
//     // NormalClass.Foo2(sbref);
//     // Console.WriteLine(sbref.ToString());
// }