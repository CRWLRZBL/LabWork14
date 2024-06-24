using System.Text.RegularExpressions;

Console.WriteLine("Number matcher");
Console.WriteLine();

Console.WriteLine("Number needs to match form of Russian Federation (Example: +7(9хх)ххх-хх-хх or 8(9хх)ххх-хх-хх)");
Console.WriteLine("Input number");
string userInput = Console.ReadLine();

string pattern = @"^(8|\+7)\(9\d{2}\)\d{3}(-\d{2}){2}$";

Regex regex = new(pattern, RegexOptions.IgnoreCase);
Match match = regex.Match(userInput);

if (match.Success)
    Console.WriteLine("Congrats, it's match");
else
    Console.WriteLine("Doesn't match");
