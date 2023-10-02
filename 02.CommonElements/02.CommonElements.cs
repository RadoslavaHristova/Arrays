/*
Hey hello 2 4
10 hey 4 hello

S of t un i
of i 10 un

i love to code
code i love to
 */
//Input
//two arrays
string[] cabinet1=Console.ReadLine().Split();
string[] cabinet2 = Console.ReadLine().Split();
//2 foreach loops
foreach(string elements2 in cabinet2) 
//compare the elements of the second array to the elements of the first.
{
    foreach (string elements1 in cabinet1)
    {
        //Print
        //all common elements in both
        if (elements1==elements2)
        { Console.Write($"{elements2} "); }
    }
}


