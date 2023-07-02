namespace c_delegate;
delegate int NumberCalc(int n);

class Program
{
    static int num = 10;
    public static int AddNum(int a)
    {
        num += a;
        return num;
    }
    public static int MulNum(int b)
    {
        num *= b;
        return num;
    }
    public static int getNum()
    {
        return num;
    }
    static void Main(string[] args)
    {
        NumberCalc nc1 = new NumberCalc(AddNum);
        NumberCalc nc2 = new NumberCalc(MulNum);
        nc1(5);
        Console.WriteLine("The new value is {0}", getNum());
        nc2(25);
        Console.WriteLine("The new value is {0}", getNum());
    }
}
