namespace a_single_inheritance;


class SuperClass{
    public void hi(){
        Console.WriteLine("Hi, this is super class");
    }
}
class SubClass : SuperClass{
    public void hello(){
        Console.WriteLine("Hello, this is sub class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        obj.hi();
        obj.hello();
    }
}
