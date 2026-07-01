using System;

int points = 75;
string rate;

if (points >= 90)
{
    rate = "A";
}
else if (points >= 75)
{
    rate = "B";
}
else if (points >= 60)
{
    rate = "C";
}
else if (points >= 50)
{
    rate = "D";
}
else
{
    rate = "F";
}

Console.WriteLine($"Your rate: {rate}");