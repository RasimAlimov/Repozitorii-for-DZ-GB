// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string inputfirst = Console.ReadLine();
int numberfirst = Convert.ToInt32(inputfirst);

Console.WriteLine("Введите второе число");
string inputsecond = Console.ReadLine();
int numbersecond = Convert.ToInt32(inputsecond);

Console.WriteLine("Введите третье число");
string inputthird = Console.ReadLine();
int numberthird = Convert.ToInt32(inputthird);

int max = numberfirst;

if (numbersecond>numberfirst) max = numbersecond;
if (numberthird>numbersecond) max = numberthird;

Console.WriteLine("Максимальное число " + max);