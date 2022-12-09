// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа:");
int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());
Console.WriteLine("a^b = " + Math.Pow(a, b));

int i = Convert.ToInt32(Math.Pow(a, b));
