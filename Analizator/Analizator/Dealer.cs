using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator
{
    public class Dealer : Deck
    {
        private string[] dealershand = { "", "" };
        private int dealershandprice;
        private int dealersfirstcard;
        public void Hand()
        {
            dealershand[0] = GiveCard();
            dealershand[1] = GiveCard();

            for (int i = 0; i < 2; i++)
            {
                int cardprice;
                if (int.TryParse(dealershand[i], out cardprice))
                {
                    dealershandprice += cardprice;
                }
                else
                {
                    if (dealershand[i] != "a")
                    {
                        dealershandprice += 10;
                    }
                    else
                    {
                        if (dealershandprice == 11)
                        {
                            dealershandprice = 2;
                        }
                        else
                        {
                            dealershandprice += 11;
                        }
                    }
                }
                if (i == 0)
                {
                    dealersfirstcard = cardprice;
                }
            }
        }
        public void ShowDealersFirstCard()
        {
            Console.WriteLine(dealersfirstcard);
        }
        public void ShowDealersHandPrice()
        {
            Console.WriteLine(dealershandprice);
        }
        public int GetDealersHandPrice()
        {
            return dealershandprice;
        }
    }
}
