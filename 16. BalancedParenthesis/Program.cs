
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

while (queue.Count > 0)
{
    foreach (var item in dict)
    {
        if (stack.Count > 0)
        {
            string stackSymbol = stack.Peek();
            string queueSymbol = queue.Peek();
            if (stackSymbol == item.Key)
            {
                if (item.Value == queueSymbol)
                {
                    stack.Pop();
                    queue.Dequeue();
                }
            }
            queue.Dequeue();
        }
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}