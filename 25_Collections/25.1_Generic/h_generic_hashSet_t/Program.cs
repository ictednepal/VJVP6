namespace h_hashSet_t;
class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Ram");
        names.Add("Sita");
        names.Add("Hari");
        names.Add("Gita");
        names.Add("Nita");
        names.Add("Ram");
        names.Add("sita");


        /* // Using Remove method
        myhash.Remove("Ruby");

        // Using Clear method
        myhash.Clear(); */

        foreach (var val in names)
        {
            Console.WriteLine(val);
        }
    }
}
