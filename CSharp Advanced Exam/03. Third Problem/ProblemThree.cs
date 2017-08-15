using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _03.Third_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ProblemThree
    {
        public static Dictionary<char, int> cardInts;
        public static void Main()
        {
            cardInts = new Dictionary<char, int>();

            FillCardsDict(cardInts);
            var firstPlayer = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            var secondPlayer = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            var counter = 1;
            var isDraw = false;
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (counter == 1_000_000)
                {
                    break;
                }

                var firstPlayerHand = firstPlayer.Dequeue();
                var secondPlayerHand = secondPlayer.Dequeue();

                var sum1 = SumPlayerCards(firstPlayerHand);
                var sum2 = SumPlayerCards(secondPlayerHand);

                if (firstPlayer.Count == secondPlayer.Count)
                    isDraw = CheckIfDraw(firstPlayer, secondPlayer);
                if (!isDraw)
                {
                    if (sum1 > sum2) MoveHandInDeck(firstPlayer, firstPlayerHand, secondPlayerHand, sum1, sum2);
                    else if (sum2 > sum1) MoveHandInDeck(secondPlayer, firstPlayerHand, secondPlayerHand, sum2, sum1);
                    else if (sum1 == sum2) GetOnWar(firstPlayer, secondPlayer);
                }
                counter++;

            }
            if (isDraw)
            {
                Console.WriteLine($"Draw after {counter} turns");
            }
            if (counter == 1000000)
            {
                PrintMethod(firstPlayer, secondPlayer, counter);
            }
            else
            {
                PrintMethod(firstPlayer, secondPlayer, counter);
            }


        }

        private static void PrintMethod(Queue<string> firstPlayer, Queue<string> secondPlayer, int counter)
        {
            if (firstPlayer.Count > 0 && secondPlayer.Count == 0)
            {
                Console.WriteLine($"First player wins after {counter} turns");

            }
            else
            {
                Console.WriteLine($"Second player wins after {counter} turns");
            }
        }

        public static bool CheckIfDraw(Queue<string> firstPlayer, Queue<string> secondPlayer)
        {
            var hasDraw = false;
            var first = firstPlayer.ToArray();
            var second = secondPlayer.ToArray();

            for (int i = 0; i < firstPlayer.Count; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    hasDraw = true;
                }
            }
            return hasDraw;
        }
        public static void GetOnWar(Queue<string> firstPlayer, Queue<string> secondPlayer)
        {
            var handOne = new List<string>();
            var handTwo = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                handOne.Add(firstPlayer.Dequeue());
                handTwo.Add(secondPlayer.Dequeue());

            }
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum1 += cardInts[handOne[i].Last()];
                sum2 += cardInts[handTwo[i].Last()];
            }

            handOne.OrderByDescending(x => x);
            handTwo.OrderByDescending(x => x);
            if (sum1 > sum2)
            {
                EnqueHand(firstPlayer, secondPlayer, handOne, handTwo);
            }
            else if (sum2 > sum1)
            {
                EnqueHand(secondPlayer, firstPlayer, handTwo, handOne);
            }
            else
            {
                GetOnWar(firstPlayer, secondPlayer);
            }
        }
        public static void EnqueHand(Queue<string> firstPlayer, Queue<string> secondPlayer, List<string> handOne, List<string> handTwo)
        {
            for (int i = 0; i < handOne.Count; i++)
            {
                firstPlayer.Enqueue(handOne[i]);
                secondPlayer.Enqueue(handTwo[1]);
            }
        }
        public static void MoveHandInDeck(Queue<string> firstPlayer, string firstPlayerHand, string secondPlayerHand, int sum1, int sum2)
        {
            if (sum1 > sum2)
            {
                if (firstPlayerHand.Last().CompareTo(secondPlayerHand.Last()) > 0)
                {
                    firstPlayer.Enqueue(firstPlayerHand);
                    firstPlayer.Enqueue(secondPlayerHand);
                }
                else
                {
                    firstPlayer.Enqueue(secondPlayerHand);
                    firstPlayer.Enqueue(firstPlayerHand);
                }

            }
        }
        public static int SumPlayerCards(string player)
        {
            var numb = 0;
            var charr = player[player.Length - 1];
            var rgx = Regex.Match(charr.ToString(), @"[a-zA-Z]", RegexOptions.IgnoreCase);
            var lastNumb = 0;

            if (rgx.Success)
            {
                lastNumb = cardInts[charr];
            }

            for (int i = 0; i < player.Length - 1; i++)
            {
                numb += int.Parse(player[i].ToString());
            }
            return numb + lastNumb;
        }
        public static void FillCardsDict(Dictionary<char, int> cardInts)
        {
            var counter = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                cardInts.Add(i, counter);
                counter++;
            }
        }
    }
}
