
int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();
Queue<string> possibleCrash = new Queue<string>();

string input = Console.ReadLine();

int timeLeft = 0;
int freeWindowLeft = 0;
int totalCarsPassed = 0;
string crashedSymbol = "";
string crashedCar = "";

while (input != "END")
{
    if (input == "green")
    {
        while (cars.Count > 0)
        {
            string passingCar = cars.Dequeue();

            Queue<string> pass = new Queue<string>();

            if (timeLeft > 0)
            {
                foreach (var item in passingCar)
                {
                    pass.Enqueue(item.ToString());
                }

                for (int i = 0; i < timeLeft; i++)
                {
                    if (pass.Count > 0)
                    {
                        pass.Dequeue();
                    }
                }

                if (pass.Count == 0)
                {
                    totalCarsPassed++;
                    possibleCrash.Dequeue();
                }

                if (pass.Count > 0 && pass.Count <= freeWindowLeft)
                {
                    freeWindowLeft -= pass.Count;
                    totalCarsPassed++;
                }
                else
                {
                    while (pass.Count > 0 && pass.Count >= freeWindowLeft)
                    {
                        pass.Dequeue();
                    }

                    if (pass.Count > 0)
                    {
                        crashedCar = possibleCrash.Dequeue();
                        crashedSymbol = pass.Dequeue();
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{crashedCar} was hit at {crashedSymbol}.");
                        return;
                    }
                }
                timeLeft -= passingCar.Length;
            }
        }
    }
    else
    {
        cars.Enqueue(input);
        possibleCrash.Enqueue(input);
        timeLeft = greenLightDuration;
        freeWindowLeft = freeWindowDuration;
    }

    input = Console.ReadLine();
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");