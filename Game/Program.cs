using System;
using System.Diagnostics;
using System.Globalization;

class players
{
    public static void Main()
    {
        ///////////////////////////////////////////первый игрок//////////////////////////////////////////////////////////////////////////////////
        string pers = "Alex";
        int agility = 0;
        int power = 0;
        int stamina = 0;
        ///////////////////////////////////////////первый игрок//////////////////////////////////////////////////////////////////////////////////
        string pers1 = "Bob";
        int agility1 = 0;
        int power1 = 0;
        int stamina1 = 0;
        try
        {
            Console.WriteLine("Введите характеристики персонажей, но учитывайте, что сумма всех характеристик не должна превышать 8! ");
            /////////////////////////////////////////первый игрок////////////////////////////////////////////////////////
            Console.WriteLine("Введите ловкость Alex: ");
            agility = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите силу Alex: ");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите выносливость Alex: ");
            stamina = Convert.ToInt32(Console.ReadLine());
            ///////////////////////////////////////Второй игрок///////////////////////////////////////////////////////////////
            Console.WriteLine("Введите ловкость Bob: ");
            agility1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите силу Bob: ");
            power1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите выносливость Bob: ");
            stamina1 = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("мимо вопрос");
        }
        ////////////////////////////Общая сумма//////////////////////////////////////////
        int obshak = agility + power + stamina;
        int obshak1 = agility1 + power1 + stamina1;
        ////////////////////////////проверка, чтобы не меньше двух////////////////////////////////////////////////
        if (agility <= 1 || stamina <= 1 || power <= 1 || agility1 <= 1 || stamina1 <= 1 || power1 <= 1)
        {
            Console.WriteLine("Я же просил не меньше двух!!!!");
            players.Main();
        }
        ////////////////////////////Проверка не больше восьми//////////////////////////////////////////
        if (obshak > 8 || obshak1 > 8)
        {
            Console.WriteLine("Я же сказал не больше 8!!");
            players.Main();
        }
        ////////////////////////////проверка не меньше восьми//////////////////////////////////////////
        if (obshak < 8 || obshak1 < 8)
        {
            Console.WriteLine("Я же сказал чтобы было  8!!");
            players.Main();
        }
        string precessing = "0"; // Будут задаваться значения боя;
        /* 
         0 - Нет действий
         1 - Удар 100%
         2 - Удар 50%
         3 - Защита
         4 - Восстановление
         
         */

        //// Система монетки ////
        Random rnd = new Random();
        int monetka = rnd.Next(1, 2);

        int healpoint = 8; // Игрок 1
        int healpoint1 = 8; // Игрок 2

        if (agility == agility1)
        {
            monetka = rnd.Next(1, 2);
            if (monetka == 1)
            {
                precessing = "1";
                healpoint1 = healpoint1 - 2;
                Console.WriteLine($"HealPoint's {pers1} = {healpoint1}");
                stamina1 = stamina1 - 1;
            }
            else
            {
                precessing = "1";
                healpoint = healpoint - 2;
                Console.WriteLine($"HealPoint's {pers} = {healpoint}");
                stamina = stamina - 1;
            }
        }
        if (agility >= agility1)
        {
            precessing = "1";
            healpoint1 = healpoint1 - 2;
            Console.WriteLine($"HealPoint's {pers1} = {healpoint1}");
            stamina = stamina - 1;
        }
        else
        {
            precessing = "1";
            healpoint = healpoint - 2;
            Console.WriteLine($"HealPoint's {pers} = {healpoint}");
            stamina1 = stamina1 - 1;
        }

        switch (precessing)
        {
            case "0":
                Console.WriteLine("Действий нету");
                break;

            case "1":
                if (stamina < stamina1)
                {
                    Console.WriteLine($"В первом бою победил {pers}");
                    Console.WriteLine($"{pers} нанёс удар в полную силу");
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"Вынсливость игрока {pers}: {stamina}");
                    Console.WriteLine($"HealPoint's игрока {pers}: {healpoint}");
                    Console.WriteLine($"Сила игрока {pers}: {power}");
                    Console.WriteLine($"Ловкость игрока {pers}: {agility}");
                }
                else
                {
                    Console.WriteLine($"В первом бою победил {pers1}");
                    Console.WriteLine($"{pers1} нанёс удар в полную силу");
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"Вынсливость игрока {pers1}: {stamina1}");
                    Console.WriteLine($"HealPoint's игрока {pers1}: {healpoint1}");
                    Console.WriteLine($"Сила игрока {pers1}: {power1}");
                    Console.WriteLine($"Ловкость игрока {pers1}: {agility1}");

                }
                break;
        }
    }
}
class battle
{
    public static void Main1()
    {

    }
}
class battle2
{
    public static void Main2()
    {

    }
}
class battle3
{
    public static void Main3()
    {

    }
}


