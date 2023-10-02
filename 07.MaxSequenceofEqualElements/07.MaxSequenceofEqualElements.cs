//Input
//array of integers
string[]symbols=Console.ReadLine().Split().ToArray();
int bestCount = 0; string bestCountSymbol = "";

//Body
//finds the longest sequence of equal elements in an array of integers
//If several equal sequences are present in the array, print out the leftmost one.
for (int i = symbols.Length - 1; i >= 0; i--)
{
    int count = 1;
    for (int j = i - 1; j >= 0; j--)
    {
        if (symbols[i] == symbols[j])
        {
            count++;
            if (bestCount <= count)
            {
                bestCount = count;
                bestCountSymbol = symbols[i];
            }
        }
        else
        {
            break;
        }
    }
}
//print
//the longest sequence of equal elements
for (int i = 0; i < bestCount; i++)
{
    Console.Write($"{bestCountSymbol} ");
}