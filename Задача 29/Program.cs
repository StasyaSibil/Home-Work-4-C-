// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран

int[] randomArray = new int[8];
string str = "[";
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = GetNumber();
    str = str + randomArray[i];
}
str = str+"]";

Console.WriteLine(str);

int GetNumber(){
    return new Random().Next(1,9);
}