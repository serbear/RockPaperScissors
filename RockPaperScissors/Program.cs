using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RockPaperScissors
{
    internal static class Program
    {
        private static int _computerChoice;

        private static readonly Dictionary<int, int> WinIndices =
            new Dictionary<int, int> { { 3, 2 }, { 4, 1 }, { 5, 3 } };

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitiateComputerChoice();
            Application.Run(new Form1());
        }

        public static void InitiateComputerChoice()
        {
            var rnd = new Random();
            _computerChoice = rnd.Next(1, 4); 
        }

        public static int GetComputerChoice()
        {
            return _computerChoice;
        }

        public static int CompareChoices(int userChoice)
        {
            // 0 - draw
            return userChoice == _computerChoice ? 0 : GetWinner(userChoice);
        }

        private static int GetWinner(int userChoice)
        {
            var sumOfChoices = _computerChoice + userChoice;
            var winnerIndex = WinIndices[sumOfChoices];
            var retVal = -1;

            if (userChoice == winnerIndex)
            {
                retVal = 1;
            }

            if (userChoice != winnerIndex)
            {
                retVal = 2;
            }

            // 1 - player wins
            // 2 - computer wins
            return retVal;
        }
    }
}