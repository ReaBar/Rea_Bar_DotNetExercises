﻿using System;

namespace GameCore
{
    public class HumanPlayer : IPlayer
    {
        public GameCheckers GameCheckerColor { get; }
        public PlayerCondition PlayerState { get; set; }
        public ConsoleColor GameCheckerConsoleColor { get; }

        public HumanPlayer(GameCheckers checkerColor)
        {
            PlayerState = PlayerCondition.Regular;
            switch (checkerColor)
            {
                case GameCheckers.White:
                    GameCheckerColor = GameCheckers.White;
                    GameCheckerConsoleColor = ConsoleColor.White;
                    break;
                case GameCheckers.Red:
                    GameCheckerColor = GameCheckers.Red;
                    GameCheckerConsoleColor = ConsoleColor.Red;
                    break;
            }
        }
    }
}
