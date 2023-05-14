namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                string command = input[0].ToLower();

                if (command == "end")
                {
                    break;
                }
                if (command == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);

                }
                else if (command == "remove")
                {
                    int numbersToRemove = int.Parse(input[1]);
                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (stack.Any())
            {
                Console.WriteLine($"Sum: {stack.Sum()}");
            }
            
        }
    }
}