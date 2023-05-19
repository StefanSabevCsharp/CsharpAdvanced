int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] elements = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(elements);
for (int i = 0; i < numbers[1]; i++)
{
    queue.Dequeue();
}
if (queue.Contains(numbers[2]))
{
    Console.WriteLine("true");

}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
