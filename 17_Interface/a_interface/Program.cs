namespace a_interface;

interface IStudent
{
    public void learn();
}
interface ITeacher
{
    public void teach();
}

public class College : IStudent, ITeacher
{
    public void learn()
    {
        Console.WriteLine("Student learns");
    }
    public void teach()
    {
        Console.WriteLine("Teacher teaches");
    }
}
class Program
{
    static void Main(string[] args)
    {
        College sanothimi = new College();
        sanothimi.learn();
        sanothimi.teach();
    }
}
