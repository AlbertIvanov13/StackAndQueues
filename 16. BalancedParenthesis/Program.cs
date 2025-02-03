string parentheses = Console.ReadLine();

Stack<string> stack = new Stack<string>();
Queue<string> queue = new Queue<string>();
Dictionary<string, string> dict = new Dictionary<string, string>()
{
    ["("] = ")",
    ["{"] = "}",
    ["["] = "]",
};

for (int i = 0; i < parentheses.Length; i++)
{
    if (parentheses[i].ToString() == "(")
    {
        stack.Push("(");
    }
    else if (parentheses[i].ToString() == "{")
    {
        stack.Push("{");
    }
    else if (parentheses[i].ToString() == "[")
    {
        stack.Push("[");
    }

    if (parentheses[i].ToString() == ")")
    {
        queue.Enqueue(")");
    }
    else if (parentheses[i].ToString() == "}")
    {
        queue.Enqueue("}");
    }
    else if (parentheses[i].ToString() == "]")
    {
        queue.Enqueue("]");
    }
}

bool isTrue = false;
for (int i = 0; i < parentheses.Length; i++)
{
    foreach (var sym in dict)
    {
        if (stack.Count > 0 && queue.Count > 0)
        {
            if (queue.Peek() == sym.Value)
            {
                stack.Pop();
                queue.Dequeue();
                isTrue = true;
                break;
            }
            else
            {
                if (!isTrue)
                {
                    queue.Dequeue();
                    isTrue = true;
                }
            }
        }
        else
        {
            break;
        }
    }
}

if (stack.Count == 0 && queue.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}