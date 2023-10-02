/*
 1 2 3 4 5 6  => 3

Even: 2 + 4 + 6 = 12
Odd: 1 + 3 + 5 = 9
Result: 12 – 9 = 3
 */

//Input
//Read an array
int[]numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
int evenSum = 0;
int oddSum = 0;
//Body
for(int i=0; i<numbers.Length; i++)
{
    //Find :sum of the even &&  sum of the odd
    int currentNumber = numbers[i];
    if (currentNumber%2 == 0)
    {  evenSum+=currentNumber; }
    else
    { oddSum+=currentNumber; }
}
//calculate: the difference evenSum/oddSum
int diff=evenSum-oddSum;
//Print...=> the difference
Console.WriteLine(diff);