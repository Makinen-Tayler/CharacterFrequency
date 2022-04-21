

using findCharAmount;
using System;

var findFreq = new FindFreq();
while (true)
{
    Console.Write("Enter your string : ");
    string input = Console.ReadLine();
    input = input.Trim();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Blank Entry");
    }
    else findFreq.getCharNum(input);
}

//var input = Console.ReadLine();
//var output = findFreq.getCharNum(input);
