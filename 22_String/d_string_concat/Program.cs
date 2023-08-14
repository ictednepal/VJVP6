namespace d_string_concat;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = "Hello ";
        Console.WriteLine(string.Concat(s2, s1));
    }
}
