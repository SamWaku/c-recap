class DerivedClass
{
    public virtual int Add(int number1, int number2) => number1 + number2;
}

class BasicsClass : DerivedClass
{
    public override int Add(int number1, int number2)
    {
        return number1 + number2 + 3;
    }
}