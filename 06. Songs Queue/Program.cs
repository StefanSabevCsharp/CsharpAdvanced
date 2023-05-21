string[] songs = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Queue<string> playlist = new Queue<string>(songs);

string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

while (playlist.Any())
{
    string info = command[0];
    switch (info)
    {
        case "Play":
            playlist.Dequeue();
            break;
        case "Add":
            string songToAdd = string.Join(" ", command.Skip(1));
            if (!playlist.Contains(songToAdd))
            {
                playlist.Enqueue(songToAdd);
            }
            else
            {
                Console.WriteLine($"{songToAdd} is already contained!");
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ",playlist));
            break;
        default:
            break;
    }
    if (playlist.Count == 0)
    {
        Console.WriteLine("No more songs!");
        break;
    }

    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
