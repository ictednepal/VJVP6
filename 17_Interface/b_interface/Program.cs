namespace b_interface;

class Program
{
    static void Main(string[] args)
    {
        IStudent Is1 = new College();
        Is1.exam();
        ITeacher It1 = new College();
        It1.exam();

    }
}

interface IStudent
{
    public void exam();
}
interface ITeacher
{
    public void exam();
}

public class College : IStudent, ITeacher
{
    void IStudent.exam()
    {
        Console.WriteLine("Hello Student");
    }
    void ITeacher.exam()
    {
        Console.WriteLine("Hello Teacher");
    }
}