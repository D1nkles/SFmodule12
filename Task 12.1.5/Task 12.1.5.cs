using System;
using Task_12_1_5;

class Program 
{
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

    static void Main(string[] args) 
    {
        List<User> usersList = new List<User>() 
        {
            new User { Login = "Tread", Name = "Анатолий", IsPremium = false},
            new User { Login = "Oeghet", Name = "Степан", IsPremium = true},
        };

        foreach (User user in usersList) 
        {
            Console.WriteLine($"Приветствуем, {user.Name}!");

            if (user.IsPremium) 
            {
                continue;
            }

            else 
            {
                ShowAds();
            }
        }
    }
}