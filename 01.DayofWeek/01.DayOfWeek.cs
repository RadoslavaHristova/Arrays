//Input
//Enter a number in range 1-7 
int input = int.Parse(Console.ReadLine());

//Body (array) days
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//Print
// the word representing it or "Invalid Day!".
if (input >= 1 && input <= 7)
    Console.WriteLine(days[input - 1]);
else
    Console.WriteLine("Invalid day!");


