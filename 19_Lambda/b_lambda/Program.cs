namespace b_lambda;
delegate int myDel(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) => a * b;
        int result = d(23, 45);
        Console.WriteLine("The result =" + result);
    }
}
