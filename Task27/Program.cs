// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10

int GetNumber()
{
Console.WriteLine("Введите любое число: ");
return Convert.ToInt32(Console.ReadLine());
}

void Summ()
{
int i = GetNumber();    
int sum = 0;
while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("Cумма всех цифр в числе равна: " + sum);
}
Summ();