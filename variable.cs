// syntax: type name = value
int age = 27;
string name = "Krzysztof";
double temperature = 36.6;
bool is_true = true;

// you can declare without assignment - but it must be done before use
int number;
number = 27;

// var - the compiler infers the type itself
var country = "Poland";
var year = 2026;

Console.WriteLine($"Hi, {name}! You have {age} years old.");