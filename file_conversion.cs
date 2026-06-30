using System;

// implicit - safe, does not lose data
int i = 42;
long l = i; // OK - int fits into long
double d = i; // OK - int -> double

// expplicit casting - possible data loss
double pi = 3.14;
int x = (int)pi; // x = 3 - fractional part truncated

// Parse - from string to int
string txt = "123";
int num = int.Parse(txt);

// TryParse - safety version
bool success = int.TryParse("abc", out int result);
Console.WriteLine(success); // False - "abc" isn't number

// ToString - conversion to string
int n = 99;
string s = n.ToString(); // "99"