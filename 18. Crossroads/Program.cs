int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();
Queue<string> newCars = new Queue<string>();

int count = 0;
int timeLeft = 0;
int freeWindowLeft = 0;
string passingCar = "";
string hittedElement = "";
string crashedCar = "";
bool isCrashed = false;

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
                if (newQueue.Count == 0)
                {
                    count++;
                }
                else
                {
                    while (newQueue.Count <= freeWindowLeft)
                    {
                        if (newQueue.Count > 0)
                        {
                            newQueue.Dequeue();
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (newQueue.Count == 0)
                    {
                        count++;
                    }
                    else
                    {
                        while (newQueue.Count >= freeWindowLeft)
                        {
                            newQueue.Dequeue();
                        }
                        hittedElement = newQueue.Dequeue();
                        crashedCar = newCars.Dequeue();
                        isCrashed = true;

                    }
                }
                timeLeft -= passingCar.Length;
            }
        }
    }
    else
    {
        cars.Enqueue(input);
        newCars.Enqueue(input);
        timeLeft = greenLightDuration;
        freeWindowLeft = freeWindowDuration;
    }
    input = Console.ReadLine();
}

if (isCrashed)
{
    Console.WriteLine("A crash happened!");
    Console.WriteLine($"{crashedCar} was hit at {hittedElement}.");
}
else
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{count} total cars passed the crossroads.");
}