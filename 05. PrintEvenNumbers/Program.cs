
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>(numbers);
Queue<int> newQueue = new Queue<int>();

while (queue.Count > 0)
{
    int number = queue.Dequeue();
    if (number % 2 == 0)
    {
        newQueue.Enqueue(number);
    }
}

Console.WriteLine(string.Join(", ", newQueue));