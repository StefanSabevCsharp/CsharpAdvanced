namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //         1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for(int i = 0;i < input.Length;i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    int startIndex = i;
                    stack.Push(startIndex);
                    

                }
                else if (c == ')')
                {
                    int endIndex = i;
                    int startIndex = stack.Pop();
                    string subString = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}