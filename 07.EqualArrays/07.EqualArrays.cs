/*
10 20 30
10 20 30

1 2 3 4 5
1 2 4 3 5
 */
//Input
//Read two arrays
int[]cabinet1=Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] cabinet2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;
bool check=false;
//Body
//determine whether they are identical or not
//The arrays are identical, if all their elements are equal
for (int i = 0; i < cabinet1.Length; i++)
{
    //If the arrays are NOT identical
    if (cabinet1[i] != cabinet2[i])
    {
        //find the first index where the arrays differ
        //PRINT: 
        if (i == 0)
        { Console.WriteLine($"Arrays are not identical. Found difference at {i} index"); }
        else
        { Console.WriteLine($"Arrays are not identical. Found difference at {cabinet1[i - 1]} index"); }
        check = true;
        break;
    }
    else if(cabinet1[i] == cabinet2[i])
    {
        //If the arrays are identical
        //find the sum of the elements of one of them
        sum += cabinet1[i];
        
    }
}
//PRINT:
//"Arrays are identical. Sum: {sum}"
if (check!=true)
{ Console.WriteLine($"Arrays are identical. Sum: {sum}"); }