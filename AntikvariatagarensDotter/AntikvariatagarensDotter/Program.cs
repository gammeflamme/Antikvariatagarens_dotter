using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatagarensDotter
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Customer customer1 = new Customer();
            bool bookSold = false;

            Console.WriteLine("you see a customer what do you want to do");
            Console.WriteLine("1.try to sell");
            Console.WriteLine("2.talk with");

            while (!bookSold) // loopar tills man har sålt boken
            {

                int choise;
                bool correctInput = false;
                correctInput = int.TryParse(Console.ReadLine(), out choise);// tar användarens input



                while (!correctInput || choise > 2 || choise < 1)//kollar så att användaren skrev in ett korrekt svar
                {
                    Console.WriteLine("please write only one number and no letters");
                    int.TryParse(Console.ReadLine(), out choise);
                }

                if (choise == 1)
                {
                    if (customer1.TryToSell(book1))
                    {
                        Console.WriteLine("you sold the book");
                        bookSold = true;
                    }
                    else
                    {
                        Console.WriteLine("you didnt sell the book");

                    }
                }
                if (choise == 2)
                {
                    customer1.TalkWith();
                    Console.WriteLine("you talked to the customer");
                }
            }


        }
    }
}
