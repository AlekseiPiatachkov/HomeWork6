/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество вводимых чисел: ");
int a = int.Parse(Console.ReadLine());
int[] arr = new int[a];

NameArray(arr);
ConsoleArray(arr);
MaxNumberNull(arr);

void NameArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"Введите число элемента {i} -> ");
        a[i] = int.Parse(Console.ReadLine());
    }
}

void ConsoleArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($" {a[i]} ");
    }
}

void MaxNumberNull(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < 0) count = count + 0;
        else  count = count + 1;
    }
    Console.Write($" -> {count}");
}


