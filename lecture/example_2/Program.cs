int[] array = {1, 4, 5, 11, 15, 111, 19, 20, 111};
int n = array.Length;
int find = 111;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

