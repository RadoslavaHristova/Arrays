//Input
//Read an array from the console
int[]number=Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;
//Body
//sum only its even values
for (int i = 0;i < number.Length;i++)
{
    int currentNumber = number[i];
    if(currentNumber%2 == 0)
    { sum += currentNumber; }
}
//Print ->  Sum
Console.WriteLine(sum);
