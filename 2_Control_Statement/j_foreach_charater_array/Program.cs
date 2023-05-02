namespace j_foreach_charater_array;
class Program
{
    static void Main(string[] args)
    {
        char[] clz = { 'S', 'a', 'n', 'o', 't', 'h', 'i', 'm', 'i' };
        foreach (var item in clz)
        {
            Console.WriteLine(item);
        }
    }
}
