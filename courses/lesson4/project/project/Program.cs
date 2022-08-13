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

//3 задание
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
    dictionary.TryGetValue(wordToTranslate,out valueToTranslate);
    Console.WriteLine($"Перевод:{wordToTranslate}");
}
else
{
    Console.WriteLine($"Значение по ключу: {wordToTranslate} не найдено");
}
Console.ReadLine();