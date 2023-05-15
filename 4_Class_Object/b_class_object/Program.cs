namespace b_class_object;
#nullable disable
class Student
{
    int roll;
    string name;
    public void HelloHi()
    {
        Console.WriteLine("Hello Sanothimi");
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 12;
        s1.name = "Ram";
        s1.HelloHi();
        Console.WriteLine("Roll number =" + s1.roll);
        Console.WriteLine("Name =" + s1.name);
    }
}
