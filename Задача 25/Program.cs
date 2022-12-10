// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа:");
int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());
Console.WriteLine("a^b = " + Pow(a,b));
 
int Pow(int a, int b){
 int res = a;

    for (int i = 1; i < b; i++)
    {
        res = res * a;
    }

    return res;
}