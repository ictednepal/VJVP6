namespace a_class_object;
class Student
{
    int roll;
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 101;
        Console.WriteLine("Roll number =" + s1.roll);
    }
}
