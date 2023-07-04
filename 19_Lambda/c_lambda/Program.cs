namespace c_lambda;

delegate void myDel(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) =>
        {
            Console.WriteLine("The result = " + (a * b));
            Console.WriteLine("End of the program");
        };
        d(23, 45);
    }
}
