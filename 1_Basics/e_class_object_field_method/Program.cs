namespace e_class_object_field_method;
#nullable disable
class Student
{
    int roll;
    String name;

    public void input()
    {
        Console.WriteLine("Enter roll:");
        roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
    }
    public void output()
    {
        Console.WriteLine("Roll = " + roll);
        Console.WriteLine("Name = " + name);
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.input();
        s1.output();
    }
}
