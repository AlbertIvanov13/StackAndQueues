
using System.Reflection.Metadata;

int petrolPumpsCount = int.Parse(Console.ReadLine());

Queue<int> indexes = new Queue<int>();
Queue<(int, int)> queue = new Queue<(int, int)>();

for (int i = 0; i < petrolPumpsCount; i++)
{
    int[] petrolPumps = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int petrolLiters = int.Parse(petrolPumps[0].ToString());
    int kilometers = int.Parse(petrolPumps[1].ToString());
    queue.Enqueue((petrolLiters, kilometers));
    indexes.Enqueue(i);
}

int tankFill = 0;

int consumedPetrol = 0;
int newNumber = 0;
int startingPumpIndex = 0;
bool isFirst = true;

foreach (var item in queue.ToList())
{
    Tuple<int, int> dequeuedTuple = queue.Dequeue().ToTuple();
    int l = dequeuedTuple.Item1;
    int k = dequeuedTuple.Item2;
    tankFill = newNumber + l;
    consumedPetrol = tankFill - k;
    if (consumedPetrol < 0)
    {
        consumedPetrol = 0;
        isFirst = true;
        startingPumpIndex = indexes.Dequeue();
        indexes.Enqueue(startingPumpIndex);
    }
    else
    {
        newNumber = consumedPetrol;
        if (isFirst)
        {
            startingPumpIndex = indexes.Dequeue();
            indexes.Enqueue(startingPumpIndex);
            isFirst = false;
        }
        startingPumpIndex = indexes.Dequeue();
        indexes.Enqueue(startingPumpIndex);
    }
    queue.Enqueue((l, k));
}

//startingPump
Console.WriteLine(indexes.Dequeue());