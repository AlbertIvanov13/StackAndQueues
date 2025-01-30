
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>(numbers);

string[] commands = Console.ReadLine().ToLower().Split();

while (commands[0] != "end")
{
    if (commands[0] == "add")
    {
        int firstNumber = int.Parse(commands[1]);
        int secondNumber = int.Parse(commands[2]);

        stack.Push(firstNumber);
        stack.Push(secondNumber);
    }
    if (commands[0] == "remove")
    {
        int count = int.Parse(commands[1]);

        for (int i = 0; i < count; i++)
        {
            if (stack.Count >= count)
            {
                stack.Pop();
            }
            else
            {
                break;
            }
        }
    }

    commands = Console.ReadLine().ToLower().Split();
}

Console.WriteLine($"Sum: {stack.Sum()}");