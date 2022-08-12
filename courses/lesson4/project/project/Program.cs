// задание 1
Console.WriteLine("введите размер массива");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Размер массива:{sizeOfArray}");
int[] array = new int[sizeOfArray];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
    Console.WriteLine(array[i]);
}
int minValue = array[0];
foreach (int i in array)
{
    if (i < minValue)
    {
        minValue = i;
    }
}
Console.WriteLine($"Минимальное значение в массиве:{minValue}.");
int maxValue = array[0];
foreach (int i in array)
{
    if (i > maxValue)
    {
        maxValue = i;
    }
}
Console.WriteLine($"Максимальное значение в массиве:{maxValue}.");
int sumOfArray = 0;
foreach (int i in array)
{
    sumOfArray += i;
}
Console.WriteLine($"Сумма всех чисел массива:{sumOfArray}.");
int averageValue = sumOfArray / sizeOfArray;
Console.WriteLine($"Среднее арифметическое массива: {averageValue}");
Console.ReadLine();
//задание со звездочкой
