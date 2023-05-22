namespace _9_Parameterized_constructor;

public class Student
{
    public int roll;
    public string name;
    public string address;

    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }

    public void display()
    {
        Console.WriteLine(name + " lives in " + address + " and roll number is " + roll + ".");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(12, "Ram Thapa", "Sanothimi");
        s1.display();
    }
}
