namespace b_diff_no_of_parameters;

public class myCalc
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        myCalc c1 = new myCalc();
        Console.WriteLine("The sum of two integers=" + c1.add(10, 20));
        Console.WriteLine("The sum of three integers=" + c1.add(10, 20, 30));
        Console.ReadLine();
    }
}
