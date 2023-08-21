namespace a_generic_list_t;
#nullable disable
public class Program
{
    static void Main(string[] args)
    {

        // List<int> nums = new List<int>();
        // var nums = new List<int>();
        var nums = new List<int>(){23,45,67,89,90,21,43,56};
        // nums.Add(12);
        // nums.Add(34);
        // nums.Add(56);
        // nums.Add(78);
        // nums.Add(1);
        // nums.Add(902);

        nums.Insert(3,678);

        // Console.WriteLine(nums[0]);
        // Console.WriteLine(nums[1]);
        // Console.WriteLine(nums[2]);
        // Console.WriteLine(nums[3]);
        // Console.WriteLine(nums[4]);
        // Console.WriteLine(nums[5]);

        // nums.ForEach(num=>Console.WriteLine(num));

        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }


    }
}

