namespace l_generic_sortedList_t;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        //SortedList of int keys, string values 
        SortedList<int, string> rollNames = new SortedList<int, string>();
        rollNames.Add(3, "Three");
        rollNames.Add(1, "One");
        rollNames.Add(2, "Two");
        rollNames.Add(4, null);
        rollNames.Add(10, "Ten");
        rollNames.Add(5, "Five");

        rollNames[2] = "TWO"; //updates value
        rollNames[4] = "Four"; //adds a new key-value if a key does not exists

        Console.WriteLine(rollNames[1]); //output: One
        Console.WriteLine(rollNames[2]); //output: Two
        Console.WriteLine(rollNames[3]); //output: Three
        Console.WriteLine(rollNames[4]); //output: Three

        

        // foreach (var item in rollNames)
        //     Console.WriteLine("Key:{0}, Value:{1}", item.Key, item.Value);

        //The following will throw exceptions
        //rollNames.Add("Three", 3); //Compile-time error: key must be int type
        //rollNames.Add(1, "One"); //Run-time exception: duplicate key
        //rollNames.Add(null, "Five");//Run-time exception: key cannot be null
    }
}
