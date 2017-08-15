namespace _10.The_Heigan_Dance
{
    using System;
    using System.Linq;

    public static class HeiganDance
    {
        private const int ChamberSize = 15;
        private const int CloudDmg = 3500;
        private const int EruptionDmg = 6000;
        private const double PlayerHealth = 18500;
        private const double HeiganHealth = 3000000;

        public static void Main()
        {
            var playerPos = new int[] { ChamberSize / 2, ChamberSize / 2 };

            var heiganHealth = HeiganHealth;
            var playerHealth = PlayerHealth;

            var isHeiganDead = false;
            var isPlayerDead = false;
            var hasCloud = false;
            var killerSpell = string.Empty;

            var dmg = double.Parse(Console.ReadLine());

            while (true)
            {
                var spellTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var spellName = spellTokens[0];
                var spellRow = int.Parse(spellTokens[1]);
                var spellCol = int.Parse(spellTokens[2]);

                heiganHealth -= dmg;

                isHeiganDead = heiganHealth <= 0;

                if (hasCloud)
                {
                    playerHealth -= CloudDmg;
                    hasCloud = false;
                    isPlayerDead = playerHealth <= 0;
                }
                if (isHeiganDead || isPlayerDead)
                {
                    break;
                }

                if (IsPlayerInRange(playerPos, spellRow, spellCol))
                {
                    if (!PlayerTryingToEscape(spellRow, spellCol, playerPos))
                    {
                        switch (spellName)
                        {
                            case "Cloud":
                                playerHealth -= CloudDmg;
                                hasCloud = true;
                                killerSpell = "Plague Cloud";
                                break;

                            case "Eruption":
                                playerHealth -= EruptionDmg;
                                killerSpell = spellName;
                                break;
                        }
                    }
                }
                isPlayerDead = playerHealth <= 0;

                if (isPlayerDead)
                {
                    break;
                }
            }

            PrintResult(playerHealth, heiganHealth, playerPos, killerSpell);
        }

        public static void PrintResult(double playerHealth, double heiganHealth, int[] playerPos, string killerSpell)
        {
            if (heiganHealth <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganHealth:f2}");
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine($"Player: Killed by {killerSpell}");
            }
            else
            {
                Console.WriteLine($"Player: {playerHealth}");
            }

            Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");
        }

         
        public static bool PlayerTryingToEscape(int spellRow, int spellCol, int[] playerPos)
        {
            if (playerPos[0] - 1 >= 0 && playerPos[0] - 1 < spellRow - 1)
            {
                playerPos[0]--;
                return true;
            }
            else if (playerPos[1] + 1 < ChamberSize && playerPos[1] + 1 > spellCol + 1)
            {
                playerPos[1]++;
                return true;
            }
            else if (playerPos[0] + 1 < ChamberSize && playerPos[0] + 1 > spellRow + 1)
            {
                playerPos[0]++;
                return true;
            }
            else if (playerPos[1] - 1 >= 0 && playerPos[1] - 1 < spellCol - 1)
            {
                playerPos[1]--;
                return true;
            }
            return false;
        }

        public static bool IsPlayerInRange(int[] playerPos, int spellRow, int spellCol)
        {
            var isRowHit = playerPos[0] >= spellRow - 1 && playerPos[0] <= spellRow + 1;
            var isColHit = playerPos[1] >= spellCol - 1 && playerPos[1] <= spellCol + 1;

            return isColHit && isRowHit;
        }
    }
}
