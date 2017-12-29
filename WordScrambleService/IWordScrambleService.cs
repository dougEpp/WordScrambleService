using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordScrambleService
{
    [ServiceContract]
    public interface IWordScrambleService
    {
        // Returns true if the game is already being hosted
        // Otherwise returns false
        [OperationContract]
        bool IsGameBeingHosted();

        // User 'username' tries to host the game with word 'wordToScramble'
        // Returns the scrambled word
        // Exception: the game is already being hosted by someone else
        [FaultContract(typeof(GameAlreadyHostedFault))]
        [OperationContract]
        string HostGame(string userName, string wordToScramble);

        // Player 'playerName' tries to join the game
        // Returns a Word object containing the host's scrambled and unscrambled word
        // Exception: maximum number of players reached
        // Exception: host cannot join the game
        // Exception: nobody is hosting the game
        [FaultContract(typeof(MaxPlayersReachedFault))]
        [FaultContract(typeof(GameNotHostedFault))]
        [FaultContract(typeof(PlayerIsHostFault))]
        [OperationContract]
        Word Join(string playerName);

        // Player 'playerName' guesses 'guessedWord' for the scrambled word
        // Word is compared with 'unscrambledWord'
        // Returns true if 'guessedWord' matches 'unscrambledWord'
        // Returns false if no match
        // Exception: user is not playing the game
        [FaultContract(typeof(PlayerNotInGameFault))]
        [FaultContract(typeof(GameNotHostedFault))]
        [OperationContract]
        bool GuessWord(string playerName, string guessedWord, string unscrambledWord);

        [OperationContract]
        void LogOut(string playerName);
        [OperationContract]
        void EndGame(string playerName);
    }

    [DataContract]
    public class Word
    {
        [DataMember]
        public string UnscrambledWord;

        [DataMember]
        public string ScrambledWord;
        public Word(string unscrambledWord, string scrambledWord)
        {
            UnscrambledWord = unscrambledWord;
            ScrambledWord = scrambledWord;
        }
    }
    [DataContract]
    public class GameAlreadyHostedFault
    {
        [DataMember]
        public string UserName;
        [DataMember]
        public string HostName;
        [DataMember]
        public string Reason;
        public GameAlreadyHostedFault(string userName, string hostName)
        {
            UserName = userName;
            HostName = hostName;
            if (userName == hostName)
            {
                Reason = "You are already hosting this game.";
            }
            else
            {
                Reason = "This game is already being hosted by " + hostName;
            }
        }
    }
    [DataContract]
    public class MaxPlayersReachedFault
    {
        [DataMember]
        public string UserName;
        [DataMember]
        public string Reason;
        public MaxPlayersReachedFault(string userName)
        {
            UserName = userName;
            Reason = "There are already 5 players in the game";
        }
    }
    [DataContract]
    public class GameNotHostedFault
    {
        [DataMember]
        public string UserName;
        [DataMember]
        public string Reason;
        public GameNotHostedFault(string userName)
        {
            UserName = userName;
            Reason = "This game is not yet being hosted.";
        }
    }
    [DataContract]
    public class PlayerIsHostFault
    {
        [DataMember]
        public string UserName;
        [DataMember]
        public string HostName;
        [DataMember]
        public string Reason;
        public PlayerIsHostFault(string userName, string hostName)
        {
            UserName = userName;
            HostName = hostName;
            Reason = "A player with this user name is hosting the game.";
        }
    }
    [DataContract]
    public class PlayerNotInGameFault
    {
        [DataMember]
        public string UserName;
        [DataMember]
        public string Reason;
        public PlayerNotInGameFault(string userName)
        {
            UserName = userName;
            Reason = "Your player name is not in the list of players.";
        }
    }
}
