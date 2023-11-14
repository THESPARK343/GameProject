using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellularGFX;

namespace MapBasedGame
{
    internal class Program
    {
        static int[,] Map;
        static int MapLeft;
        static int MapRight;

        static int playerPosL;
        static int playerPosR;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(5, 5);
            StartUp();
            MapDraw();
            Console.ReadKey();
        }

        static void StartUp()
        {
            MapLeft = 25;
            MapRight = 25;
            playerPosL = 10;
            playerPosR = -10;
            MapSetup();
        }

        static void PlayerMovement()
        {

        }

        static void PlayerSprite()
        {
            GFX.GridProcGFX(1,1,playerPosL,playerPosR,true,1);
        }

        static void EnemySprite()
        {

        }
        static void MapSetup()
        {
            Map = new int[MapLeft, MapRight];
            for (int L = 0; L < MapLeft; L++)
            {
                for (int R = 0; R < MapRight; R++)
                {
                    Map[L, R] = 6;
                }
            }
        }

        static void MapDraw()
        {
            for (int L = 0; L < MapLeft; L++)
            {
                for (int R = 0; R < MapRight; R++)
                {
                    foreach (int Cell in Map)
                    {
                        GFX.GridProcGFX(Cell, 1, 0, 0, true, MapRight);
                    }
                }
            }
            foreach (int Cell in Map)
            {
                GFX.GridProcGFX(Cell,1,0,0,true,MapRight);
            }
        }









    }

}
