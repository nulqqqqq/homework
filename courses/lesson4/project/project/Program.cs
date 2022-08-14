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

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] < array[j + 1])
        {
            int t = array[j + 1];
            array[j + 1] = array[j];
            array[j] = t;
        }
    }

}

Console.WriteLine("Отсортированный массив:");
foreach (int i in array)
{
    Console.WriteLine(i);
}

//3 задание*
Console.WriteLine("введите размер двумерного массива:");
int sizeOfSecondArrayValue1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй размер:");
int sizeOfSecondArrayValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Размер массива:{sizeOfSecondArrayValue1},{sizeOfSecondArrayValue2}");
int[,] arrayTwoDimensional = new int[sizeOfSecondArrayValue1, sizeOfSecondArrayValue2];
Random rand1 = new Random();

for (int i = 0; i < sizeOfSecondArrayValue1; i++)
{
    for (int j = 0; j < sizeOfSecondArrayValue2; j++)
    {
        arrayTwoDimensional[i, j] = rand.Next(-10, 10);
        Console.Write(arrayTwoDimensional[i, j] + " ");
    }
    Console.WriteLine();
}

int minValueOfArrayTwoDimensional = arrayTwoDimensional[0, 0];
foreach (int i  in arrayTwoDimensional)
{
    if(i < minValueOfArrayTwoDimensional)
    {
        minValueOfArrayTwoDimensional = i;
    }
}
Console.WriteLine($"Минимальное значение двумерного массива:{minValueOfArrayTwoDimensional}");

int maxValueOfArrayTwoDimensional = arrayTwoDimensional[0, 0];
foreach (int i  in arrayTwoDimensional)
{
    if (i > maxValueOfArrayTwoDimensional)
    {
        maxValueOfArrayTwoDimensional = i;
    }
}
Console.WriteLine($"Максимальное значение двумерного массива:{maxValueOfArrayTwoDimensional}");

int sumOfArrayTwoDimensional = 0;
foreach (int i  in arrayTwoDimensional)
{
    sumOfArrayTwoDimensional += i;
}
Console.WriteLine($"Сумма всех элементов двумерного массива:{sumOfArrayTwoDimensional}");

int averageValueOfarrayTwoDimensional = sumOfArrayTwoDimensional / (sizeOfSecondArrayValue1 * sizeOfSecondArrayValue2);
Console.WriteLine($"Среднее арифметическое двумерного массива:{averageValueOfarrayTwoDimensional}");
//с сортировкой не справился:(
//4 задание словарь
Console.WriteLine("Введите слово для перевода:");
string wordToTranslate = Console.ReadLine();
string valueToTranslate = "";
Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("Hello", "Привет");
dictionary.Add("Message", "Сообщение");
dictionary.Add("Value", "Значение");
dictionary.Add("Monday", "Понедельник");
dictionary.Add("Standart", "Стандарт");
dictionary.Add("Bye", "Пока");
dictionary.Add("Forget", "Забыть");
dictionary.Add("Word", "Слово");
dictionary.Add("Translation", "Перевод");
dictionary.Add("Television", "Телевизор");

if (dictionary.ContainsKey(wordToTranslate))
{
    dictionary.TryGetValue(wordToTranslate, out valueToTranslate);
    Console.WriteLine($"Перевод:{wordToTranslate}");
}
else
{
    Console.WriteLine($"Значение по ключу: {wordToTranslate} не найдено");
}
Console.ReadLine();