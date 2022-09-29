// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumberA()
{
Console.WriteLine("Введите число A: ");
return Convert.ToInt32(Console.ReadLine());
}
int GetNumberB()
{
Console.WriteLine("Введите число B: ");
return Convert.ToInt32(Console.ReadLine());
}

int Stepen ()
{
    int a = GetNumberA();
    int b = GetNumberB();
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step = step * a;
    }
    return step;
}
int rezult = Stepen();
Console.WriteLine("A в степени B равно: " + rezult);
