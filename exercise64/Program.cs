//Задача 64: Задайте значения M и N. Напишите программу, которая найдет сумму чисел от M до N.

//M = 1; N = 5. -> 1, 2, 3, 4, 5

//M = 4; N = 8. -> 4, 6, 7, 8.

int a = 0;

System.Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine()!);

System.Console.Write("->");

for (int i = M; i <= N; i++)
{
    a+=i;
}

System.Console.WriteLine(a);










