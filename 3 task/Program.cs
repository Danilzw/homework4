//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] randomarray = new int [8];

for(int i =0;i<8;i++)
{
    randomarray[i] = new Random().Next(1,9);
    System.Console.Write(randomarray[i]);
}