using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace CellularGFX
{
    internal class GFX
    {        
        /// <summary>
        /// The Conversions are as follows;;
        /// Keyword || Effect
        /// 0  :: black 
        /// 1  :: white 
        /// 2  :: blue
        /// 3  :: green
        /// 4  :: yellow
        /// 5  :: red
        /// 6  :: grey
        /// 7  :: dark grey
        /// 8  :: dark yellow
        /// 9  :: dark green
        /// !  :: Next line
        /// these are the rules for the system
        /// Must have a Space between each keyword
        /// Must be entirely lowercase
        /// you basically send a string to the function and it uses the string as a line of consecutive commands to execute
        /// each keyword causes one cell of its respective colour to be printed to console, using a period will send you the the next row
        /// 
        /// for example :
        /// 
        /// string argument = "red white red . white white white . red white red .";
        /// CellularGFX.GridProcGFX(argument);
        /// 
        /// this will output a 3x3 picture of a white plus with red corners
        /// </summary>
        public static int LineCount = 0;
        static void CellCLRGFX(int CellCLR)
        {

            // Black
            if (CellCLR == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // White
            else if (CellCLR == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Blue
            else if (CellCLR == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Green
            else if (CellCLR == 3)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Yellow
            else if (CellCLR == 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Red
            else if (CellCLR == 5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Grey
            else if (CellCLR == 6)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Dark Grey
            else if (CellCLR == 7)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (CellCLR == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (CellCLR == 9)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Next Line
            //if (CellCLR == !)
            //{
            //    Console.Write("\n");
            //}
        }
        public static void GridProcGFX(int CellGFX, int FMR, int PosX, int PosY, bool HoldPos, int Nline)
        {
            int RnTime = 0;
           // ValueGFX = new char CellA[] { };

            //Array.Copy(ValueGFX , );

            
            while (RnTime < FMR)
            {
                if (HoldPos)
                {
                    Console.SetCursorPosition(PosX, PosY);
                }
                
                 
                if (LineCount <= (Nline - 1))
                {
                    LineCount = LineCount + 1;
                    CellCLRGFX(CellGFX);
                    RnTime = RnTime + 1;

                }   
                else
                {
                    Console.Write("\n");
                    LineCount = 0;
                }

            }
        }
    }
}
