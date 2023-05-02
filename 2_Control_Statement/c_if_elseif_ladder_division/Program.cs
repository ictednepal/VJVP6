namespace c_if_elseif_ladder_division;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks in Nepali :");
        int nepali = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in English :");
        int english = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Math :");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Science :");
        int science = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks in Social :");
        int social = Convert.ToInt32(Console.ReadLine());

        int total = nepali + english + math + science + social;

        int percentage = total / 5;

        Console.WriteLine("Total marks : " + total);
        Console.WriteLine("Percentage : " + percentage);

        if (percentage >= 80)
        {
            Console.WriteLine("Distinction");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("First");
        }
        else if (percentage >= 45)
        {
            Console.WriteLine("Second");
        }
        else if (percentage >= 32)
        {
            Console.WriteLine("Third");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
