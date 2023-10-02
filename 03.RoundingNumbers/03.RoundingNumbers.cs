
//  0.9 1.5 2.4 2.5 3.14


//Input
//Read an array of real numbers (space separated)
double[] numbers =Console.ReadLine().Split().Select(double.Parse).ToArray();
int[] roundedNumbers=new int[numbers.Length];

//Body
//round them in "away from 0"
for (int i=0; i<numbers.Length; i++)
{
    roundedNumbers[i] = (int)Math.Round(numbers[i],MidpointRounding.AwayFromZero);
}
//Output
//style and print the output as in the examples:
/*
 0.9 => 1 
 1.5 => 2
 2.4 => 2
 2.5 => 3
 3.14 => 3
 */
//Console.WriteLine(string.Join(" ", roundedNumbers));
for (int i=0;i<roundedNumbers.Length;i++)
{
    Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
}





