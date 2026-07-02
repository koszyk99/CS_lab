using System;

string day = "Sunday";

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        Console.WriteLine("Work day");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Unknown day");
        break;
}

// modern version
/*
string type = day switch
{
    "Saturday" or "Sunday" => "Weekend",
    _ => "Work day"
};
*/

Console.WriteLine(day);