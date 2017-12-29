using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordScrambleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WordScrambleService : IWordScrambleService
    {
        private const int MAX_PLAYERS = 5;
        private static string hostUser = null;
        private static Word gameWords;
        private static List<string> activePlayers = new List<string>();

        [OperationBehavior]
        public bool IsGameBeingHosted()
        {
            if (hostUser != null)
            {
                return true;
            }
            return false;
        }

        [OperationBehavior]
        public string HostGame(string userName, string wordToScramble)
        {
            if (IsGameBeingHosted())
            {
                // Game is already being hosted
                GameAlreadyHostedFault fault = new GameAlreadyHostedFault(userName, hostUser);
                throw new FaultException<GameAlreadyHostedFault>(fault);
            }
            hostUser = userName;
            string scrambledWord = ScrambleWord(wordToScramble);
            gameWords = new Word(wordToScramble, scrambledWord);
            return scrambledWord;

        }

        [OperationBehavior]
        public Word Join(string playerName)
        {

            if (!IsGameBeingHosted())
            {
                // The game word has not been set, or no one is hosting
                GameNotHostedFault fault = new GameNotHostedFault(playerName);
                throw new FaultException<GameNotHostedFault>(fault);
            }

            if (activePlayers.Count >= MAX_PLAYERS)
            {
                // there are already 5 players in the game
                MaxPlayersReachedFault fault = new MaxPlayersReachedFault(playerName);
                throw new FaultException<MaxPlayersReachedFault>(fault);
            }

            if (hostUser == playerName)
            {
                // player is hosting the game (not allowed to play)
                PlayerIsHostFault fault = new PlayerIsHostFault(playerName, hostUser);
                throw new FaultException<PlayerIsHostFault>(fault);
            }

            activePlayers.Add(playerName);
            return gameWords;
        }

        [OperationBehavior]
        public bool GuessWord(string playerName, string guessedWord, string unscrambledWord)
        {
            if (!IsGameBeingHosted())
            {
                // Game has ended between user joining and making their guess
                GameNotHostedFault fault = new GameNotHostedFault(playerName);
                throw new FaultException<GameNotHostedFault>(fault);
            }
            if (!activePlayers.Contains(playerName))
            {
                // user is not playing the game
                PlayerNotInGameFault fault = new PlayerNotInGameFault(playerName);
                throw new FaultException<PlayerNotInGameFault>(fault);
            }
            if (guessedWord == unscrambledWord)
            {
                return true;
            }
            return false;
        }
        
        // Utility function to scramble a word
        private string ScrambleWord(string word)
        {
            char[] chars = word.ToArray();
            Random r = new Random(2011);

            // Loop through every character in the given string and swap
            // that character with a random one from elsewhere in the string
            for (int i = 0; i < chars.Length; i++)
            {
                int randomIndex = r.Next(0, chars.Length);
                char temp = chars[randomIndex];
                chars[randomIndex] = chars[i];
                chars[i] = temp;
            }
            return new string(chars);
        }

        public void LogOut(string playerName)
        {
            activePlayers.Remove(playerName);
        }

        public void EndGame(string playerName)
        {
            gameWords = null;
            hostUser = null;
            activePlayers.Clear();
        }
    }
}
