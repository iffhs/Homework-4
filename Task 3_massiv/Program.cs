// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции

void Prompt()
{
    int[] list = new int[8];
    for (int i = 0; i <= list.Length - 1; i++)
    {
        list[i] = new Random().Next();
        Console.WriteLine($"{list[i]}");
    }

}
Prompt();
