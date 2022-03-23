// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

int[] array = new int[9] { 12, 523, 42, 53, 31, 32, 51, 112, 7 };
BubbleSort(array);

void BubbleSort(int[] arr)
{
    int iterationCount = array.Length;
    while (iterationCount > 0)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                Swap(ref array[i], ref array[i + 1]);
            }
        }
        iterationCount--;
    }
}

string json = JsonConvert.SerializeObject(array);
Console.WriteLine(json);

void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}