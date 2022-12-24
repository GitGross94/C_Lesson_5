// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int size, int min, int max)
{
int[] randomNumbers = new int[size];
int SUMM = 0;
Console.Write("Числа, содержащиеся в массиве: ");

for (int i = 0; i <randomNumbers.Length; i++ )
{
randomNumbers[i] = new Random().Next(min, max);

Console.Write(randomNumbers[i] + " ");

if (i % 2 != 1)
{
SUMM = SUMM + randomNumbers[i];
}
}
return SUMM;
}

int randomNumbers = RandomNumbers(size, 1, 10);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}.");


