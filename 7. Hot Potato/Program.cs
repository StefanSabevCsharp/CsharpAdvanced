namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> children = new Queue<string>(names);
            int turns = int.Parse(Console.ReadLine());
            int count = 1;
            while (children.Count != 1)
            {
               string currentChildren = children.Peek();
                children.Dequeue();

                if (count == turns)
                {
                    
                    Console.WriteLine($"Removed {currentChildren}");
                    count = 1;
                    continue;
                }
                children.Enqueue(currentChildren);
                count++;
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}