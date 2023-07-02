namespace b_delegate;
public delegate void myDel(int num);

class MyNum
{
    public static void sqr(int num)
    {
        Console.WriteLine("The square = " + (num * num));
    }
    public static void cube(int num)
    {
        Console.WriteLine("The cube = " + (num * num * num));
    }
}

class Program : MyNum
{
    static void Main(string[] args)
    {
        myDel md1 = sqr;
        md1.Invoke(5);
        md1 = cube;
        md1(3);
    }
}
