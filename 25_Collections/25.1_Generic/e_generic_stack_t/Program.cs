namespace e_stack_t;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums = new Stack<int>();
        nums.Push(78);
        nums.Push(45);
        nums.Push(3);
        nums.Push(15);

        foreach (var item in nums)
            Console.WriteLine(item);
    }
}
