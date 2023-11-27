using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class SaveNLoad
    {
        static string SavePath = @"MapFile.txt";
        public void Save()
        {

        }
        public static string Load()
        {
            string LoadedValue = File.ReadAllText(SavePath);

            return LoadedValue;
        }
    }

