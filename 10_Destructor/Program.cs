namespace _10_Destructor;

public class Student
{
    public Student()
    {
        Console.WriteLine("Constructor called");
    }
    ~Student()
    {
        Console.WriteLine("Destructor called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
    }
}
