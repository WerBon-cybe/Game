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

        /////////////// 1 бой ///////////////////////////
        string precessing = "0"; // Будут задаваться значения боя;
        /* 
         0 - Нет действий
         1 - Удар 100%
         2 - Удар 50%
         3 - Защита
         4 - Восстановление
         
         */

        switch (precessing)
        {
            case "0":
                //Console.WriteLine("Действий нету");
                break;

            case "1":
                if(stamina < stamina1 ) {
                    Console.WriteLine("Игрок 2 нанёс удар в полную силу");
                }
                else
                {
                    Console.WriteLine("Игрок 1 нанёс удар в полную силу");
                }
                break;
        }
    }
}