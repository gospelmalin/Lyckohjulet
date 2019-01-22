using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyckohjulet
{
    class GameResult
    {
        public int winningNumber { get; set; }
        public String medal { get; set; }
        public String message { get; set; }

        public GameResult(int winningNumberIn, String medalIn, String messageIn)
        {
            this.winningNumber = winningNumberIn;
            this.medal = medalIn;
            this.message = messageIn;
        }

        override
        public String ToString()
        {
            return $"Winning number: {winningNumber}, message: {message}";
        }
    }
}
