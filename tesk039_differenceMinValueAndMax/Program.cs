// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
 
// 1) Напишем метод для генерации случайного массива 
// 2) Метод поиска Min or Max , c дополнительным булевым аргументом(чтобы сразу искать оба значения) 
// 3) Создам переменные для хранения массива/ и разницы
// 4) Напечатаю наш массив
// 5) Напечатаю результат метода поиска Max adn Min значения из массива
// 6) Напечатаю разницу между этими значениями

double[] GetRandomArray(int length = 10)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 100); 
    }
    return array;
}

double GetMinMaxElementArray(double[] array, bool max = true)
{
    double minMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max) minMax = minMax <= array[i]? array[i] : minMax;
        else minMax = minMax >= array[i]? array[i] : minMax;
    }
    return minMax;
}


double[] array = GetRandomArray();
double result = GetMinMaxElementArray(array, true) - GetMinMaxElementArray(array, false);

Console.WriteLine("");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("");
Console.WriteLine($"Максимальное число в массиве: {GetMinMaxElementArray(array, true)}");
Console.WriteLine("");
Console.WriteLine($"Минимальное число в массиве: {GetMinMaxElementArray(array, false)}");
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным и минимальным значением в массиве: {result}");
Console.WriteLine("");
