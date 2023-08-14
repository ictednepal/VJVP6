namespace g_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = string.Copy(s1);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
