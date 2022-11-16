//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Table(int number)
{
    int i = 1;
    while(i<=number)
    {
        double count = Math.Pow(i, 3);
        Console.Write(count + " ");
        i++;
    }
}

Console.WriteLine("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Table(res);
