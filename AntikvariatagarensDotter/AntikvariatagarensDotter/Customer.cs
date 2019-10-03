using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatagarensDotter
{
    class Customer
    {
        string name;
        int age;
        float gender; //om 0 så är man man och 1 så är man kvinna och allt där imellan
        int money;
        int oppinionOfStore = 0;
        Random random = new Random();
        List<string> namelist = new List<string> { "ulf", "åsa", "sven" };

        public Customer()
        {
            gender = (float)random.Next(100) / 100;
            age = random.Next(5, 100);
            money = random.Next(100, 1000);
            name = namelist[random.Next(namelist.Count - 1)];
        }

        public void TalkWith()//ökar Customers goda åsikt om afären
        {
            oppinionOfStore = oppinionOfStore + random.Next(5, 10);
        }

        public bool TryToSell(Book book) // säljer en bok om man har tillräckligt med pengar och bra åsikt om afären
        {
            if (book.price == 0)//uppskattar pris om inte redan uppskattat
            {
                Console.WriteLine("let me first appraise that for you");
                book.Evaluate();
            }
            if (money < book.price)

            {
                Console.WriteLine(name + " does not have enough money, please exit the game");
            }


            return money >= book.price && oppinionOfStore >= (float)random.Next(20) - 10;
        }


    }




}
