// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Write ("Введите число:");
int a = int.Parse (Console.ReadLine());

    
 Console.WriteLine(Sum(a));

 int Sum(int a){
  int s = 0;
    while (a > 0)
   {

    s = s + a % 10;
    a = a /10 ;
 
   }
   return s;

 }