/*Example
 * in:
 3

13

24

8

out:
13 24 8
45
 */

//Input
//A train has N number of wagons (integer)
using System;
using System.Collections;

int input=int.Parse(Console.ReadLine());
int[] wagonsQty = new int[input];
int total = 0;

//For Loop
for (int i = 0; i < wagonsQty.Length; i++)
{   //On the next N lines, you will receive the number of people
    wagonsQty[i] = int.Parse(Console.ReadLine());
    //that are going to get on EACH wagon.
    total += wagonsQty[i];
}
//PRINT out the number of passengers in EACH wagon
string stringWagonsQty = string.Join(" ", wagonsQty);
Console.WriteLine(stringWagonsQty);
//followed by the TOTAL number of passengers on the train.
Console.WriteLine(total);
