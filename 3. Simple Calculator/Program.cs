namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    10 - 2 - 1
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());
            int sum = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {

                string opperand = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                if (opperand == "+")
                {
                    sum+= secondNum;

                }
                else if (opperand == "-")
                {
                    
                    sum -= secondNum;
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}