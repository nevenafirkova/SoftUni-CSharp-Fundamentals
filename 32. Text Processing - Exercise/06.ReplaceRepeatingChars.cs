﻿//INPUT
string input = Console.ReadLine();

//ACTION
List<char> notRepeatedChars = new List<char>();

for (int i = 0; i < input.Length; i++)
{
	if (i == 0)
	{
        notRepeatedChars.Add(input[i]);
    }
	else
	{
		if (input[i] != input[i - 1])
		{
            notRepeatedChars.Add(input[i]);
        }
	}
}

//OUTPUT
foreach (var character in notRepeatedChars)
{
	Console.Write(character);
}