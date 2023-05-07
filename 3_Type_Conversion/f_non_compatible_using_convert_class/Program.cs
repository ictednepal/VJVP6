namespace f_non_compatible_using_convert_class;
class Program
{
    static void Main(string[] args)
    {
        string a = "123";
        int b = Convert.ToInt32(a);
        Console.WriteLine(a); // prints string value
        Console.WriteLine(b); // prints integer value
    }
}

/* Convert Classes
ToByte()
TyInt16() = > short
TyInt32() = > int
TyInt64() = > long */
