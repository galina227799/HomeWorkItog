Console.Clear();
string[] arr = new string[4];
Console.Write("Введите строку 1: ");
arr[0] = Console.ReadLine();
Console.Write("Введите строку 2: ");
arr[1] = Console.ReadLine();
Console.Write("Введите строку 3: ");
arr[2] = Console.ReadLine();
Console.Write("Введите строку 4: ");
arr[3] = Console.ReadLine();
int QE = CountElement(arr);
if(QE==0) Console.WriteLine("Пустой массив(.Нечего выводить(");
else PrintArray(NewArray(arr,QE));


int CountElement(string[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    { if(arr[i].Length < 4) res++;}
    return res;

}

string[] NewArray(string[] arr, int res)

{
    string[] newarr = new string[res];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newarr[j] = arr[i];
            j++;
        }


    }
    return newarr;
}

    void PrintArray(string[] inArray)
    {
        for (int i = 0; i < inArray.Length; i++)
        {

            Console.Write($"{inArray[i]} ");

        }
    }