
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
bool isFirst = false;
int newIndex = 0;


for (int i = 0 ; i < petrolPumpsCount; i++)
{
    Tuple<int, int> dequeuedTuple = queue.Dequeue().ToTuple();
    int l = dequeuedTuple.Item1;
    int k = dequeuedTuple.Item2;
    tankFill += l;
    consumedPetrol = tankFill - k;
    newNumber = consumedPetrol;
    queue.Enqueue((l, k));
    if (consumedPetrol < 0)
    {
        tankFill = 0;
        isFirst = true;
        int index = indexes.Dequeue();
        indexes.Enqueue(index);
    }
    else
    {
        if (isFirst)
        {
            newIndex = indexes.Dequeue();
            isFirst = false;
        }
        else
        {
            int index = indexes.Dequeue();
            indexes.Enqueue(index);
        }
        tankFill = consumedPetrol;
    }
}

Console.WriteLine(newIndex);