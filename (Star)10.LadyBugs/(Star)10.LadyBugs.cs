/*
 in:

3
0 1
0 right 1
2 right 1
end

out:

0 1 0

comment:

1 1 0 – initial field 
0 1 1 – field after "0 right 1" 
0 1 0 – field after "2 right 1"
-------------------------------------
in:

3
0 1 2
0 right 1
1 right 1
2 right 1
end

out:

0 0 0

 */
//Input:
//On the first line, you will receive an integer - the SIZE of the FIELD.
//(3)
int fieldLength=int.Parse(Console.ReadLine());
//On the second line, you will receive the initial indexes
//of all ladybugs separated by a blank space (where are the bugs at the start)
//(0 1)
int[]startBugsPoints=Console.ReadLine().Split().Select(int.Parse).ToArray();
int[]fieldLengthArr=new int[fieldLength];
for(int i=0;i<startBugsPoints.Length;i++)
{
    int bugPoint = startBugsPoints[i];
    if (bugPoint >= 0&&bugPoint<fieldLengthArr.Length)
    { fieldLengthArr[bugPoint] = 1; }
}
string commands = "";
//On the next lines, until you get the "end" command, you will receive commands in the format:
//"{ladybug index} {direction} {fly length}".   (0 right 1)
while((commands = Console.ReadLine()) != "end")
{
    string[] information = commands.Split();
    int bugPoint = int.Parse(information[0]);
    string direction = information[1];
    int flyLength = int.Parse(information[2]);
    //If we receive an initial index that does NOT CONTAIN a ladybug, NOTHING happens.
    //If you are given a ladybug index that is OUTSIDE OF THE FIELD, NOTHING happens
    if (   bugPoint > fieldLengthArr.Length - 1 
        || bugPoint < 0 
        || fieldLengthArr[bugPoint]==0   )
    { continue; }
    fieldLengthArr[bugPoint] = 0;
    //ladybug changes its position either
    //to its left or to its right by a given fly length
    /*
     * A movement description command looks like this:
     * "0 right 1".
     * This means that the little insect placed on index 0
     * should fly one index to its right.
     */if(direction=="right")
    {
        int landapoint = bugPoint + flyLength;
        //If the ladybug flies out of the field, it is gone!
        if (landapoint>fieldLengthArr.Length - 1)
        { continue; }
        //If the ladybug lands on another ladybug,
        //it continues to fly in the same direction repeating
        //the specified flight length
        if (fieldLengthArr[landapoint]==1)
        { while (fieldLengthArr[landapoint]==1)
            {
                landapoint += flyLength;
                if (landapoint>fieldLengthArr.Length-1)
                { break; }
            }
        }
        if(landapoint<=fieldLengthArr.Length - 1)
        { fieldLengthArr[landapoint] = 1; }
    }
    if (direction == "left")
    {
        int landapoint = bugPoint - flyLength;
        //If the ladybug flies out of the field, it is gone!
        if (landapoint <0)
        { continue; }
        //If the ladybug lands on another ladybug,
        //it continues to fly in the same direction repeating
        //the specified flight length
        if (fieldLengthArr[landapoint] == 1)
        {
            while (fieldLengthArr[landapoint] == 1)
            {
                landapoint -= flyLength;
                if (landapoint <0)
                { break; }
            }
        }
        if (landapoint >=0)
        { fieldLengthArr[landapoint] = 1; }
    }   
}
/*· Print all field cells in format: "{cell} {cell} … {cell}"
-> If a cell has a ladybug in it, print '1'.
-> If a cell is empty, print '0'.*/
Console.WriteLine(string.Join(" ",fieldLengthArr));
