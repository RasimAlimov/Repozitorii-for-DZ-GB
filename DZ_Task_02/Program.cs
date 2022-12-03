// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string inputfirst = Console.ReadLine();
int numberfirst = Convert.ToInt32(inputfirst);

Console.WriteLine("Введите второе число");
string inputsecond = Console.ReadLine();
int numbersecond = Convert.ToInt32(inputsecond);

if (numberfirst > numbersecond)
    Console.WriteLine("Первое число больше второго");
else
    Console.WriteLine("Второе число больше первого");
