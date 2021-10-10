using System;

namespace Lesson8Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент
    //кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн.Клиент должен
    //выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по
    //300 и 400 грн.закрыть весь долг.
    //Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную
    //экономистом банка.Метод выводит на экран информацию о состоянии кредита (сумма задолженности,
    //сумма переплаты, сообщение об отсутствии долга).

    class Program
    {

        static double debt = -1000;
        static int countOfTransactioins = 7;
        

        static void AccountState(double ammount)
        {
            debt = debt + ammount;

            if (debt == 0)
            {
                Console.WriteLine($"Account state is {debt}. Debt was paid");
            }
            else if (debt < 0)
            {
                Console.WriteLine($"Account state is {debt}. You have to pay.");
            }
            else if (debt > 0)
            {
                Console.WriteLine($"Amount outstanding is {debt}. You have some money on your account.");
            }

        }

        static void Main(string[] args)
        {

            for (int i = 0; i<countOfTransactioins; i++)
            {
                AccountState(300+i*23);
                if (i==countOfTransactioins-1 && debt<0)
                {
                    Console.WriteLine($"It was the last chance. State of your account is {debt}. You will live on the street.");
                }
            }
        }
    }
}
