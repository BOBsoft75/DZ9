// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string Numbers(int a, int b)
{
    if (a == b) return Convert.ToString(a);
    if (a > b) return a + " " + Numbers(a - 1, b);
    else return a + " " + Numbers(a + 1, b);
}
Console.Write(Numbers(num1,num2));