/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(
    -99, 100);
}

return arr;
}

void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}

void Positive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        
            positive ++;
        
    }
    Console.WriteLine($"Количество чисел больше 0: {positive}");
}

Console.WriteLine("Введите число элементов массива: ");
int positive = int.Parse(Console.ReadLine());
int[] array = GetArray(positive);
PrintArray(array);
Console.WriteLine();
Positive(array);