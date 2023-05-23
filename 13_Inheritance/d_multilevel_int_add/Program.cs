namespace d_multilevel_int_add;

public class A
{
    public int a = 45;
}
public class B : A
{
    public int b = 67;
}
public class C : B
{
    public int c = 78;
    public void add()
    {
        Console.WriteLine("The sum = " + (a + b + c));
    }
}
class Program
{
    static void Main(string[] args)
    {
        C c1 = new C();
        c1.add();
    }
}
