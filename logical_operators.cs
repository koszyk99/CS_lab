using System.Runtime.ConstrainedExecution;

bool has_an_account = true;
bool of_age = true;
bool blocked = false;

// && - AND - must be true
bool can_enter = has_an_account && of_age; // true
Console.WriteLine(can_enter);

// || - OR - only one true
bool problem = !of_age || blocked; // false
Console.WriteLine(problem);

// ! - NOT: negation
bool free = !blocked; // true
Console.WriteLine(free);

// ternary operator: condition "?" value_if_true: value_if_false
string status = of_age ? "adult" : "minor";
Console.WriteLine(status);