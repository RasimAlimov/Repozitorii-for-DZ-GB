// SНапишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
    number = (number/10);

int GetThirdDigitofNumber(int number)
{
    int thirdDigit = number %10;
    return thirdDigit;
}

int thirdnumber = GetThirdDigitofNumber(number);

if (number < 99)
    Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра введенного числа: {thirdnumber}");


