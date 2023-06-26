namespace d_interface;

interface ICalc1
{
    int add(int a, int b);
}
interface ICalc2
{
    int sub(int m, int n);
}
interface ICalc3
{
    int mul(int x, int y);
}
interface ICalc4
{
    int div(int i, int j);
}

class Calculations : ICalc1, ICalc2, ICalc3, ICalc4
{
    public int result1;
    public int add(int a, int b)
    {
        return result1 = a + b;
    }

    public int result2;
    public int sub(int m, int n)
    {
        return result2 = m - n;
    }

    public int result3;
    public int mul(int x, int y)
    {
        return result3 = x * y;
    }


    public int result4;
    public int div(int i, int j)
    {
        return result4 = i / j;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Calculations c = new Calculations();
        c.add(12, 3);
        c.sub(12, 3);
        c.mul(12, 3);
        c.div(12, 3);
        Console.WriteLine("The addition value is " + c.result1);
        Console.WriteLine("The subtraction value is " + c.result2);
        Console.WriteLine("The multiplication value is " + c.result3);
        Console.WriteLine("The division value is " + c.result4);

    }
}
