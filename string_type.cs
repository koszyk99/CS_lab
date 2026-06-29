using Internal;

// character string
string name = "Pawel";
string last_name = "Kowalski";

// string concatenation - three ways
string full1 = name + " " + last_name; // concatenation
string full2 = string.Concat(name, " ", last_name); // method
string full3 = $"{name} {last_name}"; // best way

// multiline string
string path = @"C:\Users\Pawel\Documents";

// single string
char letter = 'A'; // apostrophes, not quotation marks!

// useful string properties and methods
Console.WriteLine(name.Length); // 5
Console.WriteLine(name.ToUpper); // PAWEL
Console.WriteLine(name.Contains("we")); // True
Console.WriteLine(name.Replace("w", "e")); // paeel