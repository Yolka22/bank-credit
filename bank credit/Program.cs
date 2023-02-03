using System;

namespace bank_credit
{
    internal class Program
    {
        private class human
        {
            public human(int credit)
            { this.credit = credit; }

            private int credit;

            public int Credit
            {
                get { return credit; }
                set { credit = value; }
            }

            public void pay()
            {
                do
                {
                    Console.WriteLine("текущий кредит " + credit);

                    Console.WriteLine("сколько вносит человек за кредит?");
                    int pay = Convert.ToInt32(Console.ReadLine());

                    credit -= pay;
                } while (credit != 0);

                if (credit == 0)
                {
                    Console.WriteLine("кредит погашен");
                }
            }
        }

        private static void Main(string[] args)
        {
            human Human = new human(1000);

                Human.pay();

            Console.ReadLine();
        }
    }
}