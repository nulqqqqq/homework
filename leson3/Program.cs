Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
firstValue = firstValue + secondValue;
secondValue = firstValue - secondValue;
firstValue = firstValue - secondValue;
Console.WriteLine($"Первое число равно:{firstValue},второе число равно:{secondValue}");

