using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WordScrambleConsoleGame.WordScrambleServiceReference;

namespace WordScrambleConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            WordScrambleServiceClient proxy = new WordScrambleServiceClient();
            bool canPlayGame;
            string playerName;
            canPlayGame = true;
            bool gameIsBeingHosted;
            string inputWord;
            string scrambledWord;
            Word gameWords;
            string guessedWord;
            bool gameOver;

            Console.Write("Player's name: ");
            playerName = Console.ReadLine();
            gameIsBeingHosted = proxy.IsGameBeingHosted();

            if (!gameIsBeingHosted)
            {
                Console.WriteLine("Welcome, {0}! Do you want to host the game?", playerName);
                if (Console.ReadLine().CompareTo("yes") == 0)
                {
                    Console.Clear();
                    canPlayGame = false;
                    Console.WriteLine("Type the word to scramble.");
                    inputWord = Console.ReadLine();
                    try
                    {
                        scrambledWord = proxy.HostGame(playerName, inputWord);
                        Console.WriteLine("You're hosting the game with word {0} scrambled as {1}", inputWord, scrambledWord);
                    }
                    catch (FaultException<GameAlreadyHostedFault> e)
                    {
                        Console.WriteLine(e.Detail.Reason);
                    }
                    Console.ReadKey();
                }
            }
            if (canPlayGame)
            {
                Console.WriteLine("Welcome, {0}!", playerName);
                Console.WriteLine("Do you want to play the game?");
                if (Console.ReadLine().CompareTo("yes") == 0)
                {
                    Console.Clear();
                    try
                    {
                        gameWords = proxy.Join(playerName);
                        Console.WriteLine("Type :quit to stop playing.");
                        Console.WriteLine("Can you unscramble this word? => {0}", gameWords.ScrambledWord);
                        
                        gameOver = false;
                        while (!gameOver)
                        {
                            guessedWord = Console.ReadLine();
                            if (guessedWord == ":quit")
                            {
                                gameOver = true;
                                break;
                            }

                            try
                            {
                                gameOver = proxy.GuessWord(playerName, guessedWord, gameWords.UnscrambledWord);
                            }
                            catch (FaultException<PlayerNotInGameFault> e)
                            {
                                // Player has not registered in the game
                                Console.WriteLine(e.Detail.Reason);
                                break; // leave While loop, end game
                            }

                            if (!gameOver)
                            {
                                Console.WriteLine("Nope, try again!...");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You won!");
                            }
                        }
                    }
                    catch (FaultException<MaxPlayersReachedFault> e)
                    {
                        // There are already 5 players registered
                        Console.WriteLine(e.Detail.Reason);
                    }
                    catch (FaultException<GameNotHostedFault> e)
                    {
                        // No one is hosting the game
                        Console.WriteLine(e.Detail.Reason);
                    }
                    catch (FaultException<PlayerIsHostFault> e)
                    {
                        // The player has the same username as the host
                        Console.WriteLine(e.Detail.Reason);
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                proxy.Close();
            }
        }
    }
}
