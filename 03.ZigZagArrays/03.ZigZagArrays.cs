
//Input
//You will be given an integer N
bool shouldTakeSecond = true;
int inputFormat = int.Parse(Console.ReadLine());
int[] firstArray = new int[inputFormat];
int[] secondArray = new int[inputFormat];
//. On the next n lines, you will get 2 integer
//Form 2 new arrays in a zig-zag pattern as shown below.
for (int i = 0; i < inputFormat; i++)
{
    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (shouldTakeSecond)
    {
        secondArray[i] = values[1];
        firstArray[i] = values[0];
    }
    else
    {
        secondArray[i] = values[0];
        firstArray[i] = values[1];
    }

    shouldTakeSecond = !shouldTakeSecond;
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));


/*
in:                  out:
4                    1 10 31 20
1 5                  5 9 81 41
9 10
31 81
41 20
 */



/*
4 
1 5 
9 10 
31 81 
41 20
 */




