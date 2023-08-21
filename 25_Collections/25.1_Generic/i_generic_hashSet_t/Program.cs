namespace i_hashSet_t;
class Program
{
    static void Main(string[] args)
    {
        HashSet<int> MyIntHash = new HashSet<int>() { 45, 89, 56, 78, 45, 12, 23 };
        Console.WriteLine("Elements of MyIntHash:");
        foreach (var value in MyIntHash)
        {
            Console.WriteLine(value);
        }
    }
}
