﻿//INPUT
int n = int.Parse(Console.ReadLine());

//ACTION
string output = string.Empty;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int digit = int.Parse(input[0].ToString());

    if (digit >= 8 && digit <= 9)
    {
        digit = digit * 3 + 1;
    }
    else
    {
        digit *= 3;
    }

    digit += 91 + input.Length - 1;
    char letter = (char)digit;

    if (digit == 91)
    {
        output += " ";
    }
    else
    {
        output += letter;
    }
}
Console.WriteLine(output);