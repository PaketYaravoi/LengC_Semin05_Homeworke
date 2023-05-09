// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
1) напишем метод Prompt для ввода данных , чтобы код был более универсальным
2) метод генерации случайного массива 
3) метод подсчета четных чисел в массиве , он будет универсальный как для четных элементов так и для нечетных
4) переменные для хранения длинны массива, а также самого массива
5) печать массива через Join
6) печать резульата метода , на поиск суммы четных и не четных .
      
                   пока я писал вдруг вспомнил , что необходимо выполнить совсем иное , пишу метод для подсчета чентых и не четных елементов

*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    string stringInput = System.Console.ReadLine()!;
    int result = int.Parse(stringInput);
    return result;
}

int[] GetRandomArray(int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int SumEvenNumbers(int[] array, bool even = true)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(even) sum += array[i] % 2 == 0? array[i] : 0;
        else sum += array[i] % 2 != 0? array[i] : 0; 
    }
    return sum;
}

int CountEvenNumbers(int[] array, bool even = true)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(even) count += array[i] % 2 == 0? 1 : 0;
        else count += array[i] % 2 != 0? 1 : 0; 
    }
    return count;
}



int length = Prompt("Введите длину массива: ");
Console.WriteLine("");
int[] array = GetRandomArray(length);
int count = CountEvenNumbers(array);

Console.WriteLine(string.Join(",", array));
Console.WriteLine("");
Console.WriteLine($"Сумма всех четных чисел массива = {SumEvenNumbers(array, true)}");
Console.WriteLine("");
Console.WriteLine($"Сумма всех нечетных чисел массива = {SumEvenNumbers(array, false)}");
Console.WriteLine("");
Console.WriteLine($"Колличество четных чисел массива = {CountEvenNumbers(array, true)}");
Console.WriteLine("");
Console.WriteLine($"Колличество нечетных чисел массива = {CountEvenNumbers(array, false)}");
Console.WriteLine("");
