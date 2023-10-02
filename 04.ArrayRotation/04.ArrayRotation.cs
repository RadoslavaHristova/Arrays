var arr = Console.ReadLine().Split().ToArray();
int rotation = int.Parse(Console.ReadLine());
for (int i = 0; i < rotation; i++)
{
    var end = arr[0];
    for (var j = 0; j < arr.Length - 1; j++)
    {
        arr[j] = arr[j + 1];
    }
    arr[arr.Length - 1] = end;
}
Console.WriteLine(string.Join(" ", arr));