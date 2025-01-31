
int passingCars = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

Queue<string> cars = new Queue<string>();

int count = 0;
while (input != "end")
{
	if (input != "green")
	{
		cars.Enqueue(input);
	}
	else
	{
		if (cars.Count == 0)
		{
			break;
		}
		else
		{
			for (int i = 0; i < passingCars; i++)
			{
				if (cars.Count != 0)
				{
					string passedCar = cars.Dequeue();
					Console.WriteLine($"{passedCar} passed!");
					count++;
				}
				else
				{
					break;
				}
			}
		}
	}

    input = Console.ReadLine();
}

Console.WriteLine($"{count} cars passed the crossroads.");