//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11

System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int getsum(int number)
{
    int result = 0;
    while(number>0)
    {
        result = result + number % 10;
        number = number / 10;
    }   
    
    return result;
}

int result = getsum(number);
System.Console.WriteLine(result);
