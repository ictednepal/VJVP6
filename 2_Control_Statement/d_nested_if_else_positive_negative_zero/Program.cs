namespace d_nested_if_else_positive_negative_zero;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num != 0)
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}