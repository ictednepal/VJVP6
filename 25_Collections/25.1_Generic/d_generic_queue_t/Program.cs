namespace d_generic_queue_t;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> MyChar = new Queue<string>();
        MyChar.Enqueue("S");
        MyChar.Enqueue("a");
        MyChar.Enqueue("n");
        MyChar.Enqueue("o");
        MyChar.Enqueue("t");
        MyChar.Enqueue("h");
        MyChar.Enqueue("i");
        MyChar.Enqueue("m");
        MyChar.Enqueue("i");

        Console.WriteLine("Total elements: {0}", MyChar.Count);

        // while (MyChar.Count > 0)
        //     Console.WriteLine(MyChar.Dequeue());




        if(MyChar.Count > 0){
            // Peek() method always returns the first item from a queue collection without removing it from the queue.
			Console.WriteLine(MyChar.Peek());
		}
        
        Console.WriteLine("Total elements: {0}", MyChar.Count);
    }
}
