namespace a_events;
public delegate string MyDel(string str);

class EventPro
{
    event MyDel MyEvent;

    public EventPro()
    {
        this.MyEvent += new MyDel(this.WelcomeUser);
    }
    public string WelcomeUser(string username)
    {
        return "Welcome " + username;
    }
    static void Main(string[] args)
    {
        EventPro obj1 = new EventPro();
        string result = obj1.MyEvent("Hello Sanothimi");
        Console.WriteLine(result);
    }
}
