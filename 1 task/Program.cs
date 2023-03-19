//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.//3, 5 -> 243 (3⁵)

System.Console.Write("Введите число:");
int firstnumber = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число:");
int secondnumber = int.Parse(Console.ReadLine());

int getsum(int first, int second)
{
    int result = firstnumber;
    for(int i=1;i<second;i++)
    {
        result = result*first;
    }
    return result;
}

int result = getsum(firstnumber,secondnumber);

System.Console.WriteLine(result);