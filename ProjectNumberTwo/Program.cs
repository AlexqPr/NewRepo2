namespace ProjectNumberTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу, которую  хотите запустить");
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Закрыть программу");
            int vixod = Convert.ToInt32(Console.ReadLine());
            while (vixod != 4)
            {
                if (vixod == 1)
                {
                    Ugadai();
                }
                if (vixod == 2)
                {
                    Solution();
                }
                if (vixod == 3)
                {
                    Deliteli();
                }
                Console.WriteLine("Выберите программу, которую  хотите запустить");
                Console.WriteLine("1.Угадай число");
                Console.WriteLine("2.Таблица умножения");
                Console.WriteLine("3.Вывод делителей числа");
                Console.WriteLine("4.Закрыть программу");
                int new_vixod = Convert.ToInt32((Console.ReadLine()));
                vixod = new_vixod;
            }

        }
         static void Ugadai()
        {
            Console.WriteLine("Угадай число от 0 до 100!");
            int a = Convert.ToInt32(Console.ReadLine());// число  которое вводит пользователь
            Random rnd1 = new Random();
            int b = rnd1.Next(100);//рандомное число  

            while (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("Надо  меньше");
                }
                else
                {
                    Console.WriteLine("Надо больше");
                }
                int c = Convert.ToInt32(Console.ReadLine());
                a = c;
            }

            Console.WriteLine("Ты угадал!");
            Console.WriteLine("");
        }
        static void Solution()
        {
            int[,] tablica = new int[9, 9];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++) //Данный кусок кода добавляет в  нашу матрицу значения таблиц умножения, т.е в первую строчку и в первый столбик (0;0) он добавляет 1*1 (i*j)
                {
                    tablica[i - 1, j - 1] = i * j; //благодаря  данному блоку кода мы вносим значения таблицы умножения в нашу матрицу
                }
            }

            for (int f = 0; f < 9; f++)
            {
                for (int g = 0; g < 9; g++)   //данный блок кода выводит уже саму матрицу
                {
                    Console.Write(tablica[f, g] + " \t"); // знак \t  - это табуляция, он короче  выравнивает и делает таблицы.
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Deliteli()
        {
            Console.WriteLine("Введите число");

            int a = Convert.ToInt32(Console.ReadLine());
            List<int> deliteli = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if ((a % i) == 0) //оператор % выводит остаток от деления(что-то типо mod в Pascal)
                    deliteli.Add(i);
            }
            foreach (int vivod in deliteli)
            {
                Console.Write("   " + vivod);

            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

}