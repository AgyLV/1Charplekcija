﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    internal class GAMEBOARD
    {
        public void gameBoard()
        {


            string[] gameBoard = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string player2Simbol = "";

            CallingGameBoard.GameBoard(gameBoard);

            Console.WriteLine("What is the name of player 1?");
            string player1 = Console.ReadLine();

            while (string.IsNullOrEmpty(player1))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                player1 = Console.ReadLine();
            }

            Console.WriteLine("What is the name of player 2?");
            string player2 = Console.ReadLine();

            while (string.IsNullOrEmpty(player2))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                player2 = Console.ReadLine();
            }

            Console.WriteLine($"{player1} choose your simbol X or O "); //Vajag uztaisīt, lai var ievadīt tikai šos divus simbolus.
            string player1Simbol = Console.ReadLine().ToUpper();




            if (player1Simbol == PlayerSimbol.secondSimbol)
            {
                player2Simbol = PlayerSimbol.firstSimbol;

            }
            else if (player1Simbol == PlayerSimbol.firstSimbol)
            {
                player2Simbol = PlayerSimbol.secondSimbol;

            }

            Console.WriteLine($"{player1} simbol: {player1Simbol}");
            Console.WriteLine($"{player2} simbol: {player2Simbol}");


            Console.Clear();


            Console.ReadLine();


            CallingGameBoard.GameBoard(gameBoard);


            int uzvaretajs = 0;
            
           

            for (int i = 2; i < gameBoard.Length - 1;)
            {
                uzvaretajs = CheckWinner.Winner(gameBoard);
                            
                   

                if (uzvaretajs == 1) // nenostrada lidz galam, jo ne vienmer uzvar tas, kam jauzvar
                {
                    //Console.WriteLine($"Winner!");


                    if (gameBoard[i] == player1Simbol)
                    {
                        Console.WriteLine($"{player1} wins!");
                    }
                    if (gameBoard[i] == player2Simbol)
                    {
                        Console.WriteLine($"{player2} wins!");
                    }
                  

                    break;
                }
                if (i % 2 == 0)
                {

                    Console.WriteLine($"{player1} choose your field!");
                    string choise = Console.ReadLine();

                    // while (choise != "1" || choise != "2" || choise != "3" || choise != "4" || choise != "5" || choise != "6" || choise != "7" || choise != "8" || choise != "9")
                    //{
                    //    Console.WriteLine($"{player1} choose your field!");
                    //     choise = Console.ReadLine();
                    //}

                    i++;
                    
                    int choise1 = int.Parse(choise);
                    gameBoard[choise1] = player1Simbol;
                    

                    CheckWinner.Winner(gameBoard);
                    Console.Clear();
                    CallingGameBoard.GameBoard(gameBoard);


                }
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{player2} choose your field!");
                    string choise = Console.ReadLine();
                    //while (choise != "1" || choise != "2" || choise != "3" || choise != "4" || choise != "5" || choise != "6" || choise != "7" || choise != "8" || choise != "9")
                    // {
                    //    Console.WriteLine($"{player2} choose your field!");
                    //    choise = Console.ReadLine();
                    // }

                    i++;
                    
                    int choise1 = int.Parse(choise);
                    gameBoard[choise1] = player2Simbol;
                    
                    CheckWinner.Winner(gameBoard);
                    Console.Clear();
                    CallingGameBoard.GameBoard(gameBoard);


                    static bool Aiznemts(int choise, int choise1, string PlayerSimbol, string[] gameBoard, string player1Simbol, string player2Simbol)
                    {
                        for (int i = 2; i < gameBoard.Length - 1;)
                        {
                            if (gameBoard[choise] == player2Simbol || gameBoard[choise1] == player1Simbol) // pārbauda vai lukums jau nav aizņemts
                            {
                                Console.WriteLine("Field is already taken!");
                                Console.Write("Choose other field");
                                Console.ReadLine();
                                Console.Clear();
                                return true;
                            }
                        }
                        gameBoard[choise] = PlayerSimbol;
                        gameBoard[choise1] = PlayerSimbol;

                        return false;


                    }

                    

                }









                //string[] gameBoard = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                //gameBoard[1] = "XX"; // NEMAINIJU TESTA PĒC ŠO LĪNIJU JĀDZĒŠ ARA

                //Console.WriteLine("         |         |         ");
                //Console.WriteLine($"    {gameBoard[1]}    |    {gameBoard[2]}    |    {gameBoard[3]}    ");
                //Console.WriteLine("         |         |         ");
                //Console.WriteLine("-----------------------------");
                //Console.WriteLine("         |         |         ");
                //Console.WriteLine($"    {gameBoard[4]}    |    {gameBoard[5]}    |    {gameBoard[6]}    ");
                //Console.WriteLine("         |         |         ");
                //Console.WriteLine("-----------------------------");
                //Console.WriteLine("         |         |         ");
                //Console.WriteLine($"    {gameBoard[7]}    |    {gameBoard[8]}    |    {gameBoard[9]}    ");
                //Console.WriteLine("         |         |         ");







            }
        }
    }
}