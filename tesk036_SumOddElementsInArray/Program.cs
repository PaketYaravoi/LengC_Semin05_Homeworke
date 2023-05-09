//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// 1) напишем промпт , для ввода данных , чтобы функция была более уневерсальная 
// 2) напишем метод для генерации случайного массива 
// 3) и метод сложения , собсвенно говоря метод решения задачи 31
// 4) создадим переменные , длинну массива , минимальные значения и максимальные
// 5) Создадим наш массив, в который положим результат метода генерации массива
// 6) Распечатаем наш массив
// 7) вызовем метод для нашего массива с поиском суммы всех четных и нечетных элементов массива

int Prompt(string massage)
{
    System.Console.Write(massage);                          // выводим приглашение ко вводу
    string stringInput = System.Console.ReadLine()!;
    int result = int.Parse(stringInput);                    // парсим в число
    return result;                                          // возвращаем число, теперь можно рабоать.. 
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOddElemens(int[] array, bool odd = true)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(odd) sum += i % 2 != 0 ? array[i] : 0;
        else sum += i % 2 == 0? array[i] : 0;
    }
    return sum;
}


int Length = Prompt("Введите длинну массива: ");
int minValue = Prompt("Введите минимально-допустимое значение элемента в массиве: ");
int maxValue = Prompt("Введите максимально-допустимое значение элемента в массиве: ");
int[] array = GetRandomArray(Length, minValue, maxValue);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine("");
Console.WriteLine($"Сумма всех чисел стоящих на не четных позициях в массиве равна: {SumOddElemens(array, true)}");
Console.WriteLine("");
Console.WriteLine($"Сумма всех чисел стоящих на четных позициях в массиве равна: {SumOddElemens(array, false)}");
Console.WriteLine("");