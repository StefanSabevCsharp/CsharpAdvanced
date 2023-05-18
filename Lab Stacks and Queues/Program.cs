namespace Lab_Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> chars = new Stack<char> ();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                chars.Push(current);

            }
            foreach (char current in chars)
            {
                Console.Write(current);
            }
        }
    }
}