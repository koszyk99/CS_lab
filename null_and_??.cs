using System;

string? name = null; // ? mean that value can be null

// operator ?? - default value if something is null
// does not change variable
string display = name ?? "no name";
Console.WriteLine(display); // (no name)

// operator ??= assign if null
// change variable
name ??= "host";
Console.WriteLine(name); // host

// null-conditional ?. - safe method invocation
string? text = null;
int? lenght = text?.Length; // null - it will not display an exception