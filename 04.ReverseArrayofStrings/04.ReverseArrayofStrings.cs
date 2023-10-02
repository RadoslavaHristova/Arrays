/*   a b c d e  ->  e d c b a  */
//Input
//read an array of strings
//the input consists of a sequence of space-separated strings.
string[] elements = Console.ReadLine().Split().ToArray();
string[] mirror=new string[elements.Length];
//Body
//reverses the input array
for (int i=0; i<elements.Length; i++)
{
    mirror[elements.Length-1-i] = elements[i];
    
}
//Output
//print the elements
////Print on a single line (space separated).
Console.WriteLine(string.Join(" ", mirror));
