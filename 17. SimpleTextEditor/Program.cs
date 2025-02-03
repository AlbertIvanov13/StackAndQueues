
int operationsCount = int.Parse(Console.ReadLine());

Stack<string> stack = new Stack<string>();
Queue<string> queue = new Queue<string>();

for (int i = 0; i < operationsCount; i++)
{
    string[] operations = Console.ReadLine().Split();

	if (operations[0] == "1")
	{
		string text = operations[1];
		foreach (var symbol in text)
		{
			stack.Push(symbol.ToString());
			queue.Enqueue(symbol.ToString());
		}
	}
	else if (operations[0] == "2")
    {
		int eraseCount = int.Parse(operations[1]);

		for (int j = 0; j < eraseCount; j++)
		{
			stack.Pop();
		}
    }
	else if (operations[0] == "3")
	{
		int index = int.Parse(operations[1]);

		for (int j = 0; j < index; j++)
		{
			string symbol = queue.Dequeue();
			if (j == index - 1)
			{
                Console.WriteLine(symbol);
			}
			queue.Enqueue(symbol);
		}
	}
	else if (operations[0] == "4")
	{

	}
}