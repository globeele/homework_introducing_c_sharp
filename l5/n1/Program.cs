//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomarray(array);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine("из " + array.Length + " чисел " + count + " четных");

void FillArrayRandomarray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100,1000);
            }
    }
void PrintArray(int[] array)
    {
        Console.Write("[ ");
        for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        Console.Write("]");
        Console.WriteLine();
    }