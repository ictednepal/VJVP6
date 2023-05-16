namespace a_diff_data_types;
public class myClac
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public double add(double a, double b)
    {
        return (a + b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        myClac c1 = new myClac();
        Console.WriteLine("The sum of integers = " + c1.add(10, 20));
        Console.WriteLine("The sum double numbers = " + c1.add(10.30, 20.40));
    }
}
