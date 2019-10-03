using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntikvariatagarensDotter
{
    class Book
    {
        string title = "Unnamed"; //name
        string genre = "Undefined"; //category
        public int price;
        int rarity;
        int actualValue;
        bool cursed;
        Random random = new Random();

        List<string> nameList = new List<string>() { "Hurgeburg" , "Häxans hemliga kvast, En erotisk saga", "The life of a Sosig"  };
        List<string> genreList = new List<string>() { "Documentary", "Fantasy", "Comedy" };

        public Book()
            {
            title = nameList[random.Next(nameList.Count-1)];
            genre = nameList[random.Next(genreList.Count-1)];
            actualValue = random.Next(49, 799);
            cursed = random.Next(100) <= 50; //50% risk för cursed
            rarity = random.Next(5);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Genre : " + genre);
            Console.WriteLine("Rarity : " + rarity);


            if(price != 0)
            {

                Console.WriteLine("Price estimate : " + price);
            }
            else
            {
                Console.WriteLine("Price estimate : not yet appraised");
            }
        }

        public int Evaluate()
        {
            price = (int)((float)actualValue * (float)rarity * ((float)random.Next(50 , 150)/100));// tar actualValue gånger rarity gånger ett tall mellan 0.5 och 1.5(50 och 150 delat på 100)
            return price;
        }
        public string GetCategory()
        {
            return genre;
        
        }
        public string GetName()
        {
            return title;

        }
        public bool IsCursed(int guessChanse)//använder guessChanse istället för en fast 80% curse uppskattningsförmåga så olika personer kan ha olika möjlighet att uppskatta om en bok är cursed
        {
            bool thinkIsCursed;
            if (random.Next(100) <= guessChanse) // guessChanse% chans att ha rätt
            {
                thinkIsCursed = cursed;
            }
            else//har fel
            {
                thinkIsCursed = random.Next(1) < 1; //slumpar curse 50 50
            }
            return thinkIsCursed;


        }

    }
}
