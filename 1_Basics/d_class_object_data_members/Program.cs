namespace d_class_object_data_members;
#nullable disable
class Student
{
    int roll;
    String Name;
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 23;
        s1.Name = "Ram Thapa";
        Console.WriteLine("Roll = " + s1.roll);
        Console.WriteLine("Name = " + s1.Name);
    }
}
