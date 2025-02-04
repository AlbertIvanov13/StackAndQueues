
using System.Text;
using static System.Net.Mime.MediaTypeNames;

int operationsCount = int.Parse(Console.ReadLine());

Stack<string> undoes = new Stack<string>();
Stack<string> stack = new Stack<string>();

StringBuilder sb = new StringBuilder();
undoes.Push(sb.ToString());

for (int i = 0; i < operationsCount; i++)
{
    string[] commands = Console.ReadLine().Split();
    if (commands[0] == "1")
    {
        string text = commands[1];
        for (int j = 0; j < text.Length; j++)
        {
            sb.Append(text[j].ToString());
        }
        undoes.Push(sb.ToString());
        stack.Push("1");
    }
    else if (commands[0] == "2")
    {
        int eraseCount = int.Parse(commands[1]);
        sb.Remove(sb.Length - eraseCount, eraseCount);
        undoes.Push(sb.ToString());
        stack.Push("2");
    }
    else if (commands[0] == "3")
    {
        int index = int.Parse(commands[1]);
        for (int j = 0; j < sb.Length; j++)
        {
            if (index - 1 == j)
            {
                Console.WriteLine(sb[j]);
            }
        }
    }
    else if (commands[0] == "4")
    {
        if (undoes.Count > 0)
        {
            undoes.Pop();
        }
        if (undoes.Count > 0)
        {
            string text = undoes.Peek();
            sb.Remove(0, sb.Length);
            sb.Append(text);
        }
    }
}