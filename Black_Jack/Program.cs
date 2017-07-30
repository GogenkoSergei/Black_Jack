using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    enum CardTypes
    {
        Ace = 11,
        King = 4,
        Lady = 3,
        Jack = 2,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6
    }
    enum Suit
    {
        Hearts,
        Clovers,
        Diamonds,
        Pikes
    }
    enum Result
    {
        PlayerWin,
        DealerWin,
        Draw
    }
    struct Card
    {
        CardTypes cardtypes;
        Suit suit;
        public Card(CardTypes cardtypes, Suit suit)
        {
            this.cardtypes = cardtypes;
            this.suit = suit;
        }
    }
    struct Player
    {
        public Card[] ReceivedCards;
        public bool You;
        public bool Computer;
        public int playerscores;
        public int computerscores;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Game Starts
            int answer = 0;
            do
            {
                Console.WriteLine("Do you want to start  New Game: Yes-press-1/No-press-2");
                answer = int.Parse(Console.ReadLine());
                {
                    if (answer == 1)
                    {
                        Console.WriteLine("Game Starts");
                        break;
                    }
                    if (answer == 2)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else Console.WriteLine("Error,write  Yes-press 1/No-press 2");
                }
            }
            while (answer != 1);

            Player you = new Player { You = false };
            Player computer = new Player { Computer = true };
            Console.WriteLine("Who's first received Cards? You-press 1, computer press-2");
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Console.WriteLine("You first");
            }
            if (answer1 == 2)
            {
                Console.WriteLine("Computer first");
            }

            int yourscores=0;
            int computerscores = 0;
            
            if (yourscores > 21 || yourscores / 2 == 11)
            {
                Console.WriteLine("You win!Do want to play once more");
            }
            if (computerscores > 21 || computerscores / 2 == 11)
            {
              
                 Console.WriteLine("You lose!Do want to play once more");
                
            }
            
        }
        // Building CardDeck
        static Card[] BuildCardDeck()
        {
            Card[] cardDeck = new Card[36];
            int i = 0;
            foreach (int e in Enum.GetValues(typeof(CardTypes)))
            {
                for (int j = 0; j < Enum.GetNames(typeof(Suit)).Length; i++, j++)
                {
                    cardDeck[i] = new Card((CardTypes)e, (Suit)j);
                }
            }
            return cardDeck;
        }

        // ShuffleCards
        static void ShuffleCardDeck(Card[] cardDeck)
        {
            Random rand = new Random();
            int r = 0;
            Card temp;
            for (int j = 0; j < cardDeck.Length; j++)
            {
                r = rand.Next(cardDeck.Length - 1);
                temp = cardDeck[j];
                cardDeck[j] = cardDeck[r];
                cardDeck[r] = temp;
            }
        }

    }
}

