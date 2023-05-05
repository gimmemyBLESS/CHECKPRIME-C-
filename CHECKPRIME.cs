using System;
public class CheckPrime
{
    public static int Check_Prime(int number)
    {//user define function 
        int i;
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                return 0;
            }
        }
        if (i == number)
        {
            return 1;
        }
        return 0;

    }
    public static void Main(string[] args)
    {
        Console.Write("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int res = Check_Prime(number);
        if (res == 0)
        {
            Console.WriteLine("{0} не простое число", number);
        }
        else
        {
            Console.WriteLine("{0} является простым числом", number);
        }

    }
}
