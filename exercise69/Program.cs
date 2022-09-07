//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)

//A = 2; B = 3 -> 8


System.Console.WriteLine("Введите A");
int A = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите B");
int B = int.Parse(Console.ReadLine()!);

int C = A;

for (int i = 1; i < B; i++)
{
    C*=A;
}
System.Console.WriteLine(C);








