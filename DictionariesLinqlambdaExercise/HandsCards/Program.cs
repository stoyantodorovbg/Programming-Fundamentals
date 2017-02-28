using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cardPowers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }

            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            var cardsOfPlayersSum = new Dictionary<string, int>();

            while (input != "JOKER")
            {
                var cardsStringList = new List<string>();
                var cardsIntList = new List<int>();

                var cardsOfPlayer = new Dictionary<string, List<string>>();
               
                var sum = 0;

                var splitInput = input.Split(':');

                var name = splitInput[0].ToString();
                var cardsString = splitInput[1].ToString();

                cardsStringList = cardsString.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!cardsOfPlayer.ContainsKey(name))
                {
                    cardsOfPlayer[name] = cardsStringList;
                }
                else
                {
                    cardsOfPlayer[name].AddRange(cardsStringList);
                }

                var cardsOfPlayrsCopy = new Dictionary<string, List<string>>();

                foreach (var item in cardsOfPlayer)
                {
                    cardsOfPlayrsCopy[item.Key] = cardsOfPlayer[item.Key];
                    cardsOfPlayrsCopy[item.Key] = item.Value;
                }

                foreach (var item in cardsOfPlayer)
                {
                    foreach (var card in item.Value)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            var checkingCard = item.Value[i];
                            for (int e = i; e < item.Value.Count; e++)
                            {
                                var currentCard = item.Value[e];
                                if (checkingCard == currentCard)
                                {
                                    cardsOfPlayrsCopy.Remove(currentCard);
                                }
                            }
                        }
                    }
                }

                foreach (var item in cardsOfPlayrsCopy)
                {
                    var stringItem = item.ToString();
                    foreach (var card in item.Value)
                    {

                        var cardPower = card[0].ToString();
                        var cardType = card[1].ToString();
                        int cardIntPower = cardPowers[cardPower];
                        int cardIntType = cardTypes[cardType];
                        var cardValue = cardIntPower * cardIntType;
                        cardsIntList.Add(cardValue);

                        for (int i = 0; i < cardsIntList.Count; i++)
                        {
                            sum += cardsIntList[i];
                        }

                    }
                    cardsOfPlayersSum[stringItem] = sum;
                    sum = 0;
                }

                input = Console.ReadLine();
            }
            foreach (var item in cardsOfPlayersSum)
            {
                var name = item.Key;
                var value = item.Value;
                Console.WriteLine($"{name}: {value}");
            }

        }

        public static Dictionary<string, int> GetCardsTypePowers()
        {
            var cardPowers = new Dictionary<string, int>();

            cardPowers["S"] = 4;
            cardPowers["H"] = 3;
            cardPowers["D"] = 2;
            cardPowers["C"] = 1;

            return cardPowers;
        }

        private static Dictionary<string, int> GetCardNumberPowers()
        {

            var cardTypes = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardTypes[i.ToString()] = i;
            }

            cardTypes["J"] = 11;
            cardTypes["Q"] = 12;
            cardTypes["K"] = 13;
            cardTypes["A"] = 14;

            return cardTypes;
        }
    }
}
