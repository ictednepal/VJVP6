namespace a_string;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Sanothimi";
        char[] ch1 = { 'S', 'A', 'N', 'O', 'T', 'H', 'I', 'M', 'I' };
        string str2 = new string(ch1);
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}
