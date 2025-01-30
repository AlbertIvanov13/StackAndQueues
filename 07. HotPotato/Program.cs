
string[] kids = Console.ReadLine().Split();
int throws = int.Parse(Console.ReadLine());

Queue<string> queue = new Queue<string>(kids);

int count = 0;
while (queue.Count > 1)
{
    string kid = queue.Dequeue();
    count++;
    if (count < throws)
    {
        queue.Enqueue(kid);
    }
    else if (count == throws)
    {
        Console.WriteLine($"Removed {kid}");
        count = 0;
    }
}

Console.WriteLine($"Last is {string.Join("", queue)}");