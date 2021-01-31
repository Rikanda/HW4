using System;

namespace Project3
{
    class Program
    {
        public enum Months
        {
            январь = 0b_000000000001,
            февраль = 0b_000000000010,
            март = 0b_000000000100,
            апрель = 0b_000000001000,
            май = 0b_000000010000,
            июнь = 0b_000000100000,
            июль = 0b_000001000000,
            август = 0b_000010000000,
            сентябрь = 0b_000100000000,
            октябрь =  0b_001000000000,
            ноябрь = 0b_010000000000,
            декабрь = 0b_100000000000


        }

        
         
       
        

        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int n = Convert.ToInt32(Console.ReadLine()) - 1;

            if (Verification(n, out string error))
            {
                Console.WriteLine("Выполняется расчет времени года");
                string nameseason = GetSeason(n);
                Console.WriteLine($"Сейчас {nameseason}");
            }
            else
            {
                Console.WriteLine(error);
            }
        }
        public static bool Verification(int n, out string error)
        {
            if (n < 0 || n > 11)
            {
                error = "Введите корректный номер месяца от 1 до 12!";
                return false;
            }

            error = "";
            return true;
        }

        public static string GetSeason(int n)
        {
            Months winter = Months.январь | Months.февраль | Months.декабрь;
            Months spring = Months.март | Months.апрель | Months.май;
            Months summer = Months.июнь | Months.июль | Months.август;
            Months autumn = Months.сентябрь | Months.октябрь | Months.ноябрь;
            string season = "";

            Months m = (Months)Enum.GetValues(typeof(Months)).GetValue(n);
            Months season1 = winter & m;
            Months season2 = spring & m;
            Months season3 = summer & m;
            Months season4 = autumn & m;

            bool s1 = season1 == m;
            bool s2 = season2 == m;
            bool s3 = season3 == m;
            bool s4 = season4 == m;

            if (s1)
            {
                season = "зима";
            }

            if (s2)
            {
                season = "весна";
            }

            if (s3)
            {
                season = "лето";
            }

            if (s4)
            {
                season = "осень";
            }

            return season;
        }

    }

    

    }
