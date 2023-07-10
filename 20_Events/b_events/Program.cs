namespace b_events;
#nullable disable
delegate void OrderEventHandler();
class Order
{
    // declaring an event
    public event OrderEventHandler OnCreated;

    public void Create()
    {
        Console.WriteLine("Order created");

        // raising an event
        if (OnCreated != null)
        {
            OnCreated();
        }
    }
}
class Email
{
    public static void Send()
    {
        // @ is known as a verbatim identifier. If a string contains @ as a prefix followed by double quotes, then compiler identifies that string as a verbatim string and compile that string. The main advantage of @ symbol is to tell the string constructor to ignore escape characters and line breaks.
        Console.WriteLine($"Send an email");
    }
}
class SMS
{
    public static void Send()
    {
        Console.WriteLine($"Send an SMS");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // subscribing to an event
        var order = new Order();
        order.OnCreated += Email.Send;
        order.OnCreated += SMS.Send;
        order.Create();
    }
}