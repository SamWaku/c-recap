public class MethodTest
{
    public int F(int x, int y) => x + y;

    public int FF (int x, int y) {
        return x + y;
    }
    public int F2(int x) => x + 1;
    public string F3(string name) => $"Hello {name}";


    public string F4(string name) {
        var firstLetter = name[0];
        var capitalizedFirstLetter = firstLetter.ToString().ToUpperInvariant();
        var combined = $"{capitalizedFirstLetter}{name.Substring(1, name.Length)}";
        return combined;
    }
}

public interface ITest
{
    
}