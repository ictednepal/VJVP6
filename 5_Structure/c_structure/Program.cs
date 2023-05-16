namespace c_structure;
struct Students
{
    public string Name;
    public int Age;
    public string Address;

    public void input(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Address: " + Address);
    }
}

class Program
{
    public static void main(String[] args)
    {
        Students s1 = new Students();
        Students s2 = new Students();

        s1.input("Hari Thapa", 25, "Kathmandu");
        s2.input("Shyam Rai", 25, "Bhaktapur");

        s1.Display();
        s2.Display();
    }
}
