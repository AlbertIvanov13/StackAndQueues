
string expression = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
	if (expression[i].ToString() == "(")
	{
        stack.Push(i);
    }
	if (expression[i].ToString() == ")")
	{
		int opening = stack.Pop();
		string substring = expression.Substring(opening, i - opening + 1);
        Console.WriteLine(substring);
	}
}