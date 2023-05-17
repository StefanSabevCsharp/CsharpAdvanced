namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = queue.Dequeue();
                if (currentNum % 2 == 0)
                {
                    list.Add(currentNum);
                }
            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}