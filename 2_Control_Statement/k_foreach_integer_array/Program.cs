namespace k_foreach_integer_array;
class Program
{
    static void Main(string[] args)
    {
        int[] marks = { 34, 56, 78, 90, 55, 67 };
        foreach (var item in marks)
        {
            Console.Write(item + " ");
        }

    }
}
