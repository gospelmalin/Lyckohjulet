using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyckohjulet
{
    class Game
    {
        Random random = new Random(); 


        public Game() { }

        /// <summary>
        /// play Lyckohjulet game
        /// </summary>
        /// <returns>game result</returns>
        public GameResult playLyckohjulet(List<int> selectedNumbers)
        {
            List<int> playersSelectedNumbers = selectedNumbers;
            //TODO messageBox - Hjulet snurrar..
            //Slumpa fram vinstnummer
            int winningNumber = theWinningNumberIs();
            //Slumpa fram placering
            String medal = theMedalIs();
            //Kontrollera om det finns en vinnare
            bool didYouWin = isTheWinner(winningNumber, playersSelectedNumbers);
            string message = winnerMessage(didYouWin);
            GameResult result = new GameResult(winningNumber, medal, message);
            return result;
        }
        

        /// <summary>
        /// selects the winning number
        /// </summary>
        /// <returns>winning number</returns>
        public int theWinningNumberIs()
        {
            int winningNumber = random.Next(1, 21);
            return winningNumber;
        }

        public bool isTheWinner(int winningNumber, List<int> selectedNumbers)
        {
            bool didYouWin = selectedNumbers.Any<int>(selectedNumber => selectedNumber == winningNumber);
            return didYouWin;  
            
        }

        public String winnerMessage(bool didYouWin)
        {
            string message;
            if (didYouWin)
            {
                message = "Grattis! Du vann!";
            }
            else
            {
                message = "Tyvärr vann du inte den här gången.";
            }
            return message;
        }

        /// <summary>
        /// selects the medal
        /// </summary>
        /// <returns>medal</returns>
        public String theMedalIs()
        {
            String[] medals = { "1:a pris", "2:a pris", "Stjärnvinst!" };
            int index = random.Next(0, medals.Length);
            String medal = medals[index];
            return medal;
        }
    }
}
