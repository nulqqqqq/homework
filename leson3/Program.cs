//задание 1
Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
firstValue = firstValue + secondValue;
secondValue = firstValue - secondValue;
firstValue = firstValue - secondValue;
Console.WriteLine($"Первое число равно:{firstValue},второе число равно:{secondValue}");
//задание 2
void numberСomparison()
{
    Console.WriteLine("Введите первое число:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первое число больше второго");
        numberСomparison();
    }
    if (firstNumber == secondNumber)
    {
        Console.WriteLine("Введенные числа равны");
        numberСomparison();
    }
    if (firstNumber < secondNumber)
    {
        Console.WriteLine("Первое число меньше второго");
        numberСomparison();
    }
}
numberСomparison();
//задание 3
bool isPalindrom(char[] arr, char[] arr2)
{
    Array.Reverse(arr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != arr2[i])
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine("Введите число для определения палиндрома:");
int value = Convert.ToInt32(Console.ReadLine());
string a = value.ToString();
char[] array = a.ToCharArray();
char[] array2 = a.ToCharArray();
if (isPalindrom(array, array2))
{
    Console.WriteLine("число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}



