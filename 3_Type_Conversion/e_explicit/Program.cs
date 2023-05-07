namespace e_explicit;
class Program
{
    static void Main(string[] args)
    {
        int a = 12;
        byte b = (byte)a;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

// where data is remain same cause of range (byte)
