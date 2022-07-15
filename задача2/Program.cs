/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

double b1 = GetNumber("Введите координату точки b1");
double k1 = GetNumber("Введите координату точки k1");
double b2 = GetNumber("Введите координату точки b2");
double k2 = GetNumber("Введите координату точки k2");

double x = (b2-b1) / (k1 - k2);
double y = k1 * (b2-b1) / (k1 - k2) + b1;

Console.WriteLine($"Точка пересечения прямых: ({x}); ({y})");

