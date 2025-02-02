
string parentheses = Console.ReadLine();

Stack<string> stack = new Stack<string>();
Dictionary<string, string> dict = new Dictionary<string, string>()
{
	["("] = ")",
	["["] = "]",
	["{"] = "}",
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
    else if (parentheses[i].ToString() == ")")
    {
        stack.Push(")");
    }
    else if (parentheses[i].ToString() == "}")
    {
        stack.Push("}");
    }
    else if (parentheses[i].ToString() == "]")
    {
        stack.Push("]");
    }
}

bool isTrue = false;
while (stack.Count > 0)
{
	string symbol = stack.Pop();
	foreach (var item in dict)
	{
		if (item.Value == symbol)
		{
			isTrue = true;
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