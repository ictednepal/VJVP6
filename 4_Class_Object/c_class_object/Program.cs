namespace c_class_object;
#nullable disable
class Student
{
    public int roll;
    public string name;

    public void input( int r, string n)
    {
        roll = r;
        name = n;
    }
    public void output()
    {
        Console.WriteLine("Roll no: "+roll);
        Console.WriteLine("Name: "+name);
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();
        s1.input(12,"Ram Rai");
        s2.input(13,"Sita Thapa");
        s1.output();
        s2.output();
    }
}
