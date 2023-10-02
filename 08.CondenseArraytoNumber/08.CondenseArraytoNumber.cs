/*Example:
    we have 3 elements - {2, 10, 3}.
    sum the first two and the second two elements => {2 + 10, 10 + 3} = {12, 13},
    then sum all adjacent elements again.
    This results in {12 + 13} = {25}.
     */
//Input
//read an array of integers
int[]cabinet=Console.ReadLine().Split().Select(int.Parse).ToArray();
//Body
while (cabinet.Length-1 > 0)
{
    int[] newCabinet=new int[cabinet.Length-1];
    //condense all array elements by summing all adjacent couples of elements
    //until a single integer remains!
    for (int i = 0; i < newCabinet.Length; i++)
    {
        /*//Hint://
         While we have more than one element in the array nums[],
        repeat the following:
        · Allocate a new array condensed[] of size nums.length.
        · Sum the numbers from nums[] to condensed[].

        o condensed[i] = nums[i] + nums[i+1]
        · nums[] = condensed[]
         */
        newCabinet[i] = cabinet[i] + cabinet[i + 1];
    }
    cabinet = newCabinet;
}
Console.WriteLine(cabinet[0]);