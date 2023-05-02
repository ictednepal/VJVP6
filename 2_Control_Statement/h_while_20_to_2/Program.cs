namespace h_while_20_to_2;
class Program
{
    static void Main(string[] args)
    {
        int a = 20;
        while (a >= 2)
        {
            Console.WriteLine(a);
            a -= 2;  // a = a - 2;
        }
    }
}
