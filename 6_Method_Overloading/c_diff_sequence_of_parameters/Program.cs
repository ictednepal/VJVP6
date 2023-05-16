namespace c_diff_sequence_of_parameters;

public class Student
{
    public void displaydetails(int roll, string name)
    {
        Console.WriteLine("Roll no: " + roll + " Name: " + name);
    }
    public void displaydetails(string name, int roll)
    {
        Console.WriteLine("Roll no: " + roll + " Name: " + name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();
        s1.displaydetails(1, "Ram");
        s1.displaydetails("Sita", 5);
    }
}
