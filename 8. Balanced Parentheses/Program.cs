char[] chars = Console.ReadLine().ToCharArray();
Stack<char> stack = new Stack<char>();

for (int i = 0; i < chars.Length; i++)
{
    char current = chars[i];

    switch (current)

    {
        case '(':
        case '[':
        case '{':
            stack.Push(current);
            break;
        case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
           break;
        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;

            
        default:
            break;
    }

}

 Console.WriteLine("YES");
