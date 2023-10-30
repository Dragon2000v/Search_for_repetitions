using System;

var word = "Hello world!";
var characters = word.ToCharArray();

var charMap = new Dictionary<char, int>();
foreach (char ch in characters)
{
    if (charMap.ContainsKey(ch))
    {
        charMap[ch]++;
    }
    else
    {
        charMap[ch] = 1;
    }
}

Console.WriteLine($"Список повторяющихся символов в строке'{word}':");
foreach (var entry in charMap)
{
    if (entry.Value > 1)
    {
        Console.WriteLine($"{entry.Key} : {entry.Value}");
    }
}