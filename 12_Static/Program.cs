namespace _12_Static;

public static class Num
{
    public static int roll = 45;
    public static int cube(int a)
    {
        return (a * a * a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Roll number is = " + Num.roll);
        Console.WriteLine("Cube  = " + Num.cube(5));
    }
}
