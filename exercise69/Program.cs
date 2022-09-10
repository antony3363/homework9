//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)

//A = 2; B = 3 -> 8


int square(int A, int B)
{
    int C = 1;
    for (int i = 0; i < B; i+=1)
    {
        C*=A;
    }
    return C;
}   
System.Console.WriteLine("Введите A");
int A = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите B");
int B = int.Parse(Console.ReadLine()!);

int c = square(A, B); 

System.Console.WriteLine(c);








