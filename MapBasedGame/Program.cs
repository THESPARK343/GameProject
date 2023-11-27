using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CellularGFX;

namespace MapBasedGame
{
    internal class Program
    {
        static int[,] Map;
        static int MapLeft;
        static int MapRight;

        static bool RunGame;
        static Random rng;
        static bool PLmoving;
        static int playerPosL;
        static int playerPosR;
        static bool PlayerMoved;

        static int enemyPosL;
        static int enemyPosR;
        static void Main(string[] args)
        {
            RunGame = false;
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            StartUp();

            while (RunGame)
            {
                if (Timer(0,120))
                {
                    PlayerInput();
                    if (PlayerMoved)
                    {
                        DrawLayers();
                        PlayerMoved = false;
                    }

                }

            }
        }
       
        static void StartUp()
        {
            rng = new Random();

            MapLeft = 25;
            MapRight = 25;
            playerPosL = 10;
            playerPosR = 10;
            enemyPosL = rng.Next(5, 10)*2;
            enemyPosR = rng.Next(5, 10)*2;
            
            RunGame = true;
            DrawLayers();

        }

        static void DrawLayers()
        {
            
            Console.SetCursorPosition(1, 1);
            MapDraw();
            Console.SetCursorPosition(1, 1);
            EnemySprite();
            Console.SetCursorPosition(1, 1);
            PlayerSprite();
            Console.SetCursorPosition(1, 1);
        }

        static void PlayerInput()
        {
            ConsoleKeyInfo MoveValue = Console.ReadKey();

            if (MoveValue.Key == ConsoleKey.UpArrow)
            {
                if (playerPosR >= 1+3)
                {
                    playerPosR -= 1;
                    PlayerMoved = true;

                }
            }
            else if (MoveValue.Key == ConsoleKey.DownArrow)
            {
                if (playerPosR <= 24+3)
                {
                    playerPosR += 1;
                    PlayerMoved = true;
                }
            }
            else if (MoveValue.Key == ConsoleKey.LeftArrow)
            {
                if (playerPosL >= 2)
                {
                    playerPosL -= 2;
                    PlayerMoved = true;
                }
            }
            else if (MoveValue.Key == ConsoleKey.RightArrow)
            {
                if (playerPosL <= 48)
                {
                    playerPosL += 2;
                    PlayerMoved = true;
                }
            }
            


        }

        static void PlayerSprite()
        {
            GFX.GridProcGFX("1", 1, playerPosL, playerPosR, true, 1, false);
            
        }

        static void EnemySprite()
        {
            GFX.GridProcGFX("5", 1, enemyPosL, enemyPosR, true, 1, false);
        
        }
        static void MapSetup()
        {
            
        }
        static void MapUnpack()
        {
           

        }

        static void MapDraw()
        {
            string[,] maplegend; 
            
            string mapData = SaveNLoad.Load();

            string[] mapRows = mapData.Split('\n');
            int rowCount = 0;
            foreach (string column in mapRows)
            {
                int lineCount = 0;
                string[] cells = column.Split('~');
              
                foreach (string cell in cells)
                {
                    lineCount++;
                    GFX.GridProcGFX(cell, 1, 0, 0, false, 1, false);
                }
                rowCount++;
            }
        }









    }

}
