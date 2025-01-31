
int foodQuantity = int.Parse(Console.ReadLine());

int[] ordersQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>(ordersQuantity);

Console.WriteLine(queue.Max());

while (queue.Count > 0)
{
    int nextClient = queue.Peek();
    if (nextClient <= foodQuantity)
    {
        queue.Dequeue();
        foodQuantity -= nextClient;
    }
    else if (nextClient > foodQuantity)
    {
        Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        break;
    }
}

if (queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}