//Create a program, which prints all unique pairs in an array of integers
//whose sum is equal to a given number

/*
 in:
1 7 6 2 19 23
8

out:
1 7 6 2
...............
in:
14 20 60 13 7 19 8
27

out:
14 13 20 7 19 8
 */

int[]numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
int specialNum=int.Parse(Console.ReadLine());

for(int i=0;i<numbers.Length;i++)
{
    for (int j=i+1;j<numbers.Length;j++)
    {
        if (numbers[i] + numbers[j] == specialNum)
            Console.WriteLine($"{numbers[i]} {numbers[j]}");

    }
}