// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//4 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
string inputfirst = Console.ReadLine();
int number = Convert.ToInt32(inputfirst);

number = Math.Abs(number); //преобразователь введенного отрицательного числа в положительное

for (int i = 2; i<=number; i=i+2)
{
    Console.Write(i+ " ");
}

