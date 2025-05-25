using System.Text;

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
        public static void Foo2(ref StringBuilder fooSB)
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