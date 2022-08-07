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


