using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator
{
    internal class Program 
    { 
    static void Main(string[] args)
        {
          bool flag = true;
          while (flag != false)
          {
            Console.WriteLine("Добро пожаловать в блек джек");
                if (flag == true)
                {
                    Deck deck = new Deck();
                        Player player = new Player();
                        Dealer dealer = new Dealer();
                        player.Hand();
                        Console.Write("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        dealer.Hand();
                        Console.Write("1 карта дилера:");
                        dealer.ShowDealersFirstCard();
                        string flag1 = "";
                        while (flag1 != "no" && player.GetPlaersHandPrice() <=21)
                        {
                            Console.WriteLine("Введите yes , если xотите добрать карту, и no ,если не хотите");
                            flag1 = Console.ReadLine();
                            if (flag1 == "yes")
                            {
                                player.AddCard();
                                Console.Write("Ваша рука:");
                                player.ShowPlaersHandPrice();
                            }
                        }
                        if (player.GetPlaersHandPrice() > 21)
                        {
                            Console.WriteLine("Ваша рука:");
                            player.ShowPlaersHandPrice();
                            Console.Write("Рука дилера:");
                            dealer.ShowDealersHandPrice();
                            Console.WriteLine("Вы проиграли,ваша рука больше 21");

                        }
                        else if (player.GetPlaersHandPrice() < dealer.GetDealersHandPrice())
                        {
                            Console.WriteLine("Ваша рука:");
                            player.ShowPlaersHandPrice();
                            Console.Write("Рука дилера:");
                            dealer.ShowDealersHandPrice();
                            Console.WriteLine("Вы проиграли,рука дилера больше");
                        }
                        else if (player.GetPlaersHandPrice() > dealer.GetDealersHandPrice())
                        {
                            if (player.GetPlaersHandPrice() != 21)
                        {

                        }
                            else
                            Console.WriteLine("Ваша рука:");
                            player.ShowPlaersHandPrice();
                            Console.Write("Рука дилера:");
                            dealer.ShowDealersHandPrice();
                            Console.WriteLine("Вы Выиграли");

                        }
                        else
                        {
                            Console.WriteLine("Ваша рука:");
                            player.ShowPlaersHandPrice();
                            Console.Write("Рука дилера:");
                            dealer.ShowDealersHandPrice();
                            Console.WriteLine("Ничья");
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
        
    }
}
