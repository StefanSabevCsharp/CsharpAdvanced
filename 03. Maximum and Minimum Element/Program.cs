int count = int.Parse(Console.ReadLine());

Stack<int> elements = new Stack<int>();

for (int i = 0; i < count; i++)
{
    int[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    int action = command[0];
    switch (action)
    {
        case 1:
            int numberToPush = command[1];
            elements.Push(numberToPush);
            break;
        case 2:
            elements.Pop();
            break;
        case 3:

            Console.WriteLine(elements.Max());
            break;
        case 4:
            Console.WriteLine(elements.Min());
            break;
        default:
            break;
    }

}
Console.WriteLine(string.Join(", ", elements));