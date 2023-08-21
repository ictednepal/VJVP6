namespace j_dictionary_t;
class Program
{
    static void Main(string[] args)
    {
        IDictionary<int, string> rollNames = new Dictionary<int, string>();
        rollNames.Add(1, "Ram");
        rollNames.Add(3, "Sita");
        rollNames.Add(2, "Hari");

        foreach (KeyValuePair<int, string> kvp in rollNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
}
