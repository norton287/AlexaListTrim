﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaListTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            var txtString = new List<string>();
            var modTxtString = new List<string>();

            using (var sr = new StreamReader(@"c:\temp\text.txt"))
            {
                while (sr.Peek() >= 0)
                    txtString.Add(sr.ReadLine());
            }

            foreach (var food in txtString)
            {
                Console.WriteLine($"Trimming: {food}");
                if (food.Length <= 0 || (food.IndexOf(".", StringComparison.Ordinal) + 2).ToString() == string.Empty ||
                    !food.Contains(".")) continue;
                var newFood = food.Substring(food.IndexOf(".", StringComparison.Ordinal) + 2) + "\n";
                modTxtString.Add(newFood);
            }

            using (var sw = new StreamWriter(@"c:\temp\out.txt"))
            {
                foreach (var food in modTxtString)
                {
                    sw.Write(food);
                }

                sw.Close();
            }

            Console.WriteLine("All done!  Press any key to start Notepad.exe");
            Console.ReadKey();
            Process.Start("Notepad.exe", @"c:\temp\out.txt");
        }
    }
}
