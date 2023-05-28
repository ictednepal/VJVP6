namespace _14_Encapsulation;

public class Cuboid
{
    private double length;
    private double breadth;
    private double height;

    public void inputData()
    {
        Console.WriteLine("Enter the length :");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the breadth :");
        breadth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height :");
        height = Convert.ToDouble(Console.ReadLine());
    }
    public double vol()
    {
        return (length * breadth * height);
    }


    public void displayVol()
    {
        Console.WriteLine("Volume of the cuboid is : " + vol());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cuboid c1 = new Cuboid();
        c1.inputData();
        c1.displayVol();
    }
}
