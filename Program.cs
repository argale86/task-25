// подать на вход числа А и Б и выдать результат возведения А в степень Б
int ReadNumber (string message)
{
    Console.WriteLine (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = ReadNumber("Введите положительное число А:");
int numberB = ReadNumber("Введите положительное число Б:");
if (numberB < 2)
{
    double stepn = numberA;
    Console.WriteLine ("Степень числа = " + numberA);
}
else
{
    double stepn = numberA;
    for (int count = 1; count < numberB; count++)
    {
        stepn = stepn * numberA;
    }
    Console.WriteLine ("Степень числа = " + stepn);
}

