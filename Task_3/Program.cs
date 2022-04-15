/* Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, 
которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:

data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1 */

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
int[] newData = new int[info.Length];
Breakdown(newData);
int[] info10 = new int[info.Length];
PrintConversion(Conversion(4));

void Breakdown(int[] newData)
{
    int k = 0;
    Console.Write("\nМассив data, разбитый на числа на основе массива info: {");
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
             Console.Write(data[k+j]);
        }
        k += info[i];
        Console.Write(", ");
    }
    Console.WriteLine("}\n");
}

int[] Conversion (int length)
{
    int[] data_conv = new int[length];
    int k = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            data_conv[i] += data[k+j] * (int)(Math.Pow(2, info[i] -1-j));
        }
        k += info[i];
    }
    return data_conv;
}


void PrintConversion(int[] data_conv)
{
    Console.Write("\nМассив десятичных представлений чисел массива data с учётом информации из массива info: {");
    foreach (int digit in data_conv)
    {
        Console.Write(digit);
        Console.Write(", ");
    }
    Console.WriteLine("}\n");
}



