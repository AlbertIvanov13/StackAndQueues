
using System.Data;

string[] numbers = Console.ReadLine().Split().ToArray();

Array.Reverse(numbers);

Stack<string> stack = new Stack<string>();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    stack.Push(numbers[i]);
}

int firstNumber = 0;
int secondNumber = 0;
bool first = true;
while (stack.Count > 0)
{
    string character = stack.Pop();
    if (character == "+")
    {
        int nextNumber = int.Parse(stack.Pop());
        sum += nextNumber;
    }
    else if (character == "-")
    {
        int nextNumber = int.Parse(stack.Pop());
        sum -= nextNumber;
    }
    else
    {
        sum += firstNumber = int.Parse(character.ToString());
    }
}

Console.WriteLine(sum);