
int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int count = 0;
int timeLeft = 0;
int adding = 0;
string passingCar = "";

string input = Console.ReadLine();

while (input != "END")
{
    if (input == "green")
    {
        while (cars.Count > 0)
        {
            passingCar = cars.Dequeue();
            Queue<string> queue = new Queue<string>();
            Queue<string> newQueue = new Queue<string>();
            foreach (var item in passingCar)
            {
                queue.Enqueue(item.ToString());
            }
            if (timeLeft > 0)
            {
                for (int i = 0; i < timeLeft; i++)
                {
                    if (passingCar.Length > i)
                    {
                        queue.Dequeue();
                    }
                }
                while (queue.Count > 0)
                {
                    newQueue.Enqueue(queue.Dequeue());
                }
                if (queue.Count == 0)
                {
                    count++;
                }
                timeLeft -= passingCar.Length;
            }
        }
    }
    else
    {
        cars.Enqueue(input);
        timeLeft = greenLightDuration;
    }
    input = Console.ReadLine();
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{count} total cars passed the crossroads.");