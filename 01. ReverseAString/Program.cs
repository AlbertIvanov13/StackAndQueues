﻿
string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();

for (int i = 0; i < input.Length; i++)
{
    stack.Push(input[i]);
}

while (stack.Count > 0)
{
    char symbol = stack.Pop();
    Console.Write(symbol);
}