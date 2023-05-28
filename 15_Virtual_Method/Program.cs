namespace _15_Virtual_Method;

public class SuperCalc
{
    public int a;
    public int b;
    public virtual int Add(int a, int b)
    {
        return (a + b);
    }
}

public class SubCalc : SuperCalc
{
    public override int Add(int a, int b)
    {
        return (a + b) * 5;
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubCalc c1 = new SubCalc();
        Console.WriteLine("The result is =" + c1.Add(10, 20));
    }
}
