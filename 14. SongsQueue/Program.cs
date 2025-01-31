
using System.Collections;

string[] songs = Console.ReadLine().Split(", ");

Queue<string> queue = new Queue<string>(songs);

while (queue.Count > 0)
{
    string[] commands = Console.ReadLine().Split(new[] { " " },2,StringSplitOptions.None);
	if (commands[0] == "Add")
	{
		string songName = commands[1];
		if (queue.Contains(songName))
		{
            Console.WriteLine($"{songName} is already contained!");
		}
		else
		{
			queue.Enqueue(songName);
		}
	}
	else if (commands[0] == "Play")
	{
		queue.Dequeue();
	}
	else if (commands[0] == "Show")
	{
        Console.WriteLine(string.Join(", ", queue));
	}
}

Console.WriteLine("No more songs!");