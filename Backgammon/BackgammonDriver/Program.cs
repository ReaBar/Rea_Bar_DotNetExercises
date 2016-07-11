﻿
using System;
using GameCore;
using UICore;

namespace BackgammonDriver
{
    class Program
    {
        enum GamePlayers
        {
            Human, 
            AI
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Is player one human? yes/no");
            //var answer = Console.ReadLine();
            IPlayer whitePlayer = new HumanPlayer(GameCheckers.White);
            IPlayer redPlayer = new HumanPlayer(GameCheckers.Red);
            IGameController gameController = new GameController(whitePlayer,redPlayer);
            IUiController uiController = new UiController(gameController);
            uiController.StartGame();
        }
    }
}