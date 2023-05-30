namespace d_abstract;
#nullable disable

public abstract class NetflixPlan
{
    protected double rate;
    public abstract void getRate();
    public void calculate(int units)
    {
        Console.WriteLine("The amount for {0} units is = {1}", units, units * rate);
    }
}
public class GoldUserPlan : NetflixPlan
{
    public override void getRate()
    {
        rate = 2.5;
    }
}
public class DiamondUserPlan : NetflixPlan
{
    public override void getRate()
    {
        rate = 5.0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        NetflixPlan user;
        Console.WriteLine("Gold User Plan");
        user = new GoldUserPlan();
        user.getRate();
        user.calculate(245);
        Console.WriteLine("----------------");
        Console.WriteLine("Diamond User Plan");
        user = new DiamondUserPlan();
        user.getRate();
        user.calculate(455);
    }
}
