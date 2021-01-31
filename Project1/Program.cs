using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите количество людей, для которых желаете ввести данные: ");
           int n = Convert.ToInt32(Console.ReadLine());
            string[] fio = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Укажите фамилию {i+1} человека: ");
                string firstName = Console.ReadLine();
                Console.Write($"Укажите имя {i+1} человека: ");
                string lastName = Console.ReadLine();
                Console.Write($"Укажите отчество {i+1} человека: ");
                string patronymic = Console.ReadLine();
                string fullname = GetFullName(firstName, lastName, patronymic);
                if (Check(fullname, fio, out string error))

                {
                    fio[i] = fullname;
                        }
                else
                {
                    Console.WriteLine(error);
                    i--; }
            }

            Console.WriteLine("Данные ФИО по людям: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fio[i]);
            }


        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullname = firstName +" " + lastName + " " + patronymic;
            return fullname;
        }

        public static bool Check (string fullname, string[] fio, out string error)
        {
            int count = 0;
            for (int i = 0; i < fio.Length; i++)
            {
                bool b = fullname ==  fio[i];
                if (b)
                {
                   
                    count += 1;

                } 
            }
            
            if (count>0)
            {
                error = "Такой человек уже внесен в базу, внесите другие ФИО";
                return false;
            }

            error = "";
            return true;
        }

          

    }
}
