

int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string[] queries = Console.ReadLine().Split();
    if (queries[0] == "1")
    {
        int numberToPush = int.Parse(queries[1]);
        stack.Push(numberToPush);
    }
    else if (queries[0] == "2")
    {
        stack.Pop();
    }
    else if (queries[0] == "3")
    {
        if (stack.Count == 0)
        {
            continue;
        }
        Console.WriteLine(stack.Max());
    }
    else if(queries[0] == "4")
    {
        if(stack.Count == 0)
        {
            continue;
        }
        Console.WriteLine(stack.Min());
    }
}

Console.WriteLine(string.Join(", ", stack));