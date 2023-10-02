//Input
//Read n numbers
int inputQty=int.Parse(Console.ReadLine());
int[] numbers=new int[inputQty];

for (int i = 0;i<inputQty;i++)
{
    int nextNumber=int.Parse(Console.ReadLine()) ;
    numbers[i]=nextNumber;
}
//print 
//print them in reverse order, separated by a single space.
for(int i=numbers.Length-1;i>=0;i--)
{
    Console.Write(numbers[i]+" ");
}
