using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AlexaListTrim
{
	public static class Program 
	{
        static void Main()
        {
            var txtString = new List<string>();
            var modTxtString = new List<string>();

            if (File.Exists(@"c:\temp\text.txt"))
            {
	            using var sr = new StreamReader(@"c:\temp\text.txt");
	            while (sr.Peek() >= 0)
	            {
		            txtString.Add(sr.ReadLine());
	            }

	            foreach (var food in txtString)
                 {
                    Console.WriteLine($@"Trimming: {food}");
                    if (food.Length <= 0 || (food.IndexOf(".", StringComparison.Ordinal) + 2).ToString() == string.Empty ||
                        !food.Contains(".")) continue;
                    var newFood = food.Substring(food.IndexOf(".", StringComparison.Ordinal) + 2) + "\r\n";
                    modTxtString.Add(newFood);
                 }

	            using var sw = new StreamWriter(@"c:\temp\out.txt");
	            foreach (var food in modTxtString)
	            {
		            sw.Write(food);
	            }

	            Console.WriteLine(@"All done!  Press any key to start Notepad.exe");
                Console.ReadKey();
                File.Delete(@"c:\temp\text.txt");
                Process.Start("Notepad.exe", @"c:\temp\out.txt");
            }
            else
            {
                Console.WriteLine(@"Save text.txt to c:\temp before running!");
                Console.WriteLine(@"Press any key to exit....");
                Console.ReadKey();
            }
        }
    }
}
