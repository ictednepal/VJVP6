// constructor overloading with differnt number of arguments
namespace a_cons_overloading_diff_no_of_argument;
public class Add
{
    int a, b;
    int x, y, z;

    // constructor one
    public Add(int m, int n)
    {
        a = m;
        b = n;
    }
    // constructor two
    public Add(int p, int q, int r)
    {
        x = p;
        y = q;
        z = r;
    }
    public void displayOne()
    {
        Console.WriteLine("The sum of int + int = {0}", (a + b));
    }
    public void displayTwo()
    {
        Console.WriteLine("The sum of int + int + int = {0}", (x + y + z));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Add a1 = new Add(10, 20);
        Add a2 = new Add(10, 20, 30);
        a1.displayOne();
        a2.displayTwo();
    }
}
