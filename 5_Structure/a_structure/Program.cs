namespace a_structure;
struct Student
{
    public int roll;

    public void getRoll(int roll)
    {
        Console.WriteLine("The roll number is = " + roll);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        s1.roll = 101;
        s1.getRoll(s1.roll);
    }
}
