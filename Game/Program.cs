using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml;

public class players
{
    public static void Main()
    {
        ///////////////////////////////////////////первый игрок//////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Введите имя 1 игрока: ");
        string pers = Console.ReadLine();
        int agility = 0;
        int power = 0;
        int stamina = 0;
        ///////////////////////////////////////////первый игрок//////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Введите имя 2 игрока: ");
        string pers1 = Console.ReadLine();
        int agility1 = 0;
        int power1 = 0;
        int stamina1 = 0;
        try
        {
            Console.WriteLine("Введите характеристики персонажей, но учитывайте, что сумма всех характеристик не должна превышать 8! ");
            /////////////////////////////////////////первый игрок////////////////////////////////////////////////////////
            Console.WriteLine($"Введите ловкость {pers}: ");
            agility = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите силу {pers}: ");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите выносливость {pers}: ");
            stamina = Convert.ToInt32(Console.ReadLine());
            ///////////////////////////////////////Второй игрок///////////////////////////////////////////////////////////////
            Console.WriteLine($"Введите ловкость {pers1}: ");
            agility1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите силу {pers1}: ");
            power1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите выносливость {pers1}: ");
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
        if (agility <= 1 || stamina <= 1 || power <= 1 || agility1 <= 1 || stamina <= 1 || power1 <= 1)
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


        /// Мозги Бойцов ////

        /* agility - Ловкостть
           power - Сила
           stamina - Выносливость
        */

        //1.Удар в полную силу = наносит урон в зависимости от силы человека, который наносит удар, при этом теряя 1 стамину
        //2.Удар в пол силы = наносит половину урона от силы и теряет 0.5 стамины
        //3.Восстановление за один ранду восстанавливает 1 стамину
        //4.Защита не теряет ничего, но и не получает урон

        // Мозги первого бойца

        }

        
    }
}
class brains1
{
    public static void Main1()
    {
        string precessing = "0";

        switch (precessing)
        {

            case "1": // Удар в полную силу
                if (stamina >= 3)
                {
                    int hp;
                    stamina = stamina - 1;
                    hp = power;
                    healpoint1 = healpoint1 - hp;
                }
                else // Если меньше или равно 3 то регенирируем стамину
                {
                    stamina = stamina + 1;
                }
                break;

            case "2":

                if (stamina >= 3)
                {
                    int hp;
                    double stamina2 = (double)stamina;
                    stamina2 = stamina2 - 0.5; // Вычли пол силы
                    hp = power / 2;
                    healpoint = healpoint1 - hp;
                }
                else
                {
                    stamina = stamina + 1;
                }
                break;

            case "3":
                if (agility <= 3)
                {
                    stamina = stamina + 1;
                }
                break;

            case "4":
                Console.WriteLine("Игрок выставил защиту");
                break;
        }

    }
}



