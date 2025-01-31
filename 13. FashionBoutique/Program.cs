
int[] clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rackCapacity = int.Parse(Console.ReadLine());

Stack<int> clothes =  new Stack<int>(clothesInTheBox);

int sum = 0;
int racksCount = 1;

while (clothes.Count > 0)
{
    sum += clothes.Peek();
    if (sum > rackCapacity)
    {
        sum = 0;
        racksCount++;
    }
    else
    {
        clothes.Pop();
    }
}

Console.WriteLine(racksCount);