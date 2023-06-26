// derived interfaces
namespace c_interface;

interface IOne
{
    void One();
}
interface ITwo
{
    void Two();
}
interface IThree : IOne, ITwo
{
    void Three();
}

class Program : IThree
{
    void IOne.One()
    {
        Console.WriteLine("Method One");
    }
    void ITwo.Two()
    {
        Console.WriteLine("Method Two");
    }
    void IThree.Three()
    {
        Console.WriteLine("Method Three");
    }
    static void Main(string[] args)
    {
        IThree i1 = new Program();
        i1.One();
        i1.Two();
        i1.Three();
    }
}
