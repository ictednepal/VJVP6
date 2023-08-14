namespace f_string_contains;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = "thimi";
        string s3 = "sano";
        string s4 = "thulo";
        Console.WriteLine(s1.Contains(s2));
        Console.WriteLine(s1.Contains(s3));
        Console.WriteLine(s1.Contains(s4));
    }
}
