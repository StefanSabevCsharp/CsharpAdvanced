int countOfCommands = int.Parse(Console.ReadLine());

string text = string.Empty;
Stack<string> stack = new Stack<string>(); // moje bi trqbva da ima null purvonachalno

for (int i = 0; i < countOfCommands; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string info = command[0];
    switch (info)
    {
        case "1":
            stack.Push(text);
            text += command[1];
            break;
        case "2":
            stack.Push(text);
            int countToErase = int.Parse(command[1]);
            for (int j = 0; j < countToErase; j++)
            {
                text = text.Remove(text.Length - 1);
            }
            break;
        case "3":
            int indexToShow = int.Parse(command[1]) - 1;
            Console.WriteLine(text[indexToShow]);
            break;
        case "4":
            text = stack.Pop();
            break;
        default:
            break;
    }

}