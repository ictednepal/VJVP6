namespace c_generic_queue_t;
class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(78);
        nums.Enqueue(25);
        nums.Enqueue(3);
        nums.Enqueue(89);

        foreach (var id in nums)
            Console.WriteLine(id);



        // Contains() method checks whether an item exists in a queue or not
        Console.WriteLine(nums.Contains(3)); //true
        Console.WriteLine(nums.Contains(77)); //false
    }
}
