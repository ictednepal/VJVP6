namespace b_constructor;

public class Teacher
{
    public Teacher()
    {
        Console.WriteLine("Teacher is teaching");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher();
    }
}
