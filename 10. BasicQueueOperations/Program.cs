
int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToEnqueue = operations[0];
int elementsToDequeue = operations[1];
int elementsToPeek = operations[2];

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>();

for (int i = 0; i < elementsToEnqueue; i++)
{
    queue.Enqueue(numbers[i]);
}

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    if (queue.Contains(elementsToPeek))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}