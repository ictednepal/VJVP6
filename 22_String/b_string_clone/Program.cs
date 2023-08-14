namespace b_string_clone;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = (string)s1.Clone();
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
