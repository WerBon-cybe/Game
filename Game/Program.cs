using System;
using System.Diagnostics;
using System.Globalization;

class players
{
    public static void Main(string[] args)
    {
        ///////////////////////////////////////////первый игрок////////////////////////////////////////////////
        Console.WriteLine("Введите имя игрока 1: ");
        string pers = Console.ReadLine();
        int agility = 0;
        int power = 0;
        int stamina = 0;
        ///////////////////////////////////////////первый игрок////////////////////////////////////////////////
        Console.WriteLine("Введите имя игрока 2: ");
        string pers1 = Console.ReadLine();
        int agility1 = 0;
        int power1 = 0;
        int stamina1 = 0;

        try
        {
            Console.WriteLine("Введите характеристики персонажей, но учитывайте, что сумма всех характеристик не должна превышать 8! ");
            /////////////////////////////////////////первый игрок////////////////////////////////////////////////////////
            Console.WriteLine($"Введите ловкость {pers}");
            agility = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите силу {pers}");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите выносливость {pers}");
            stamina = Convert.ToInt32(Console.ReadLine());
            ///////////////////////////////////////Второй игрок///////////////////////////////////////////////////////////////
            Console.WriteLine($"Введите ловкость {pers1}");
            agility1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите силу {pers1}");
            power1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите выносливость {pers1}");
            stamina1 = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("мимо вопрос");
        }

        /////////////// 1 бой ///////////////////////////
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
                if(monetka == 1)
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
        if(agility >= agility1)
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
                if(stamina < stamina1 ) {
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