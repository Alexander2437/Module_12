using System;

namespace Module_12_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User("Jug", "Tom", false),
                new User("Lin", "Linda", true),
                new User("Whiskey", "Samuil", false),
                new User("Kill", "Bill", false)
            };

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("Привет, {0}", users[i].Name);

                if (users[i].IsPremium == false)
                {
                    ShowAds();
                }
                Console.WriteLine();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
