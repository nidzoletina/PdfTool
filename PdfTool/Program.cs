using System;
using System.IO;
using PdfTool.Tools;

namespace PdfTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "--help")
            {
                Console.WriteLine(PdfTools.Help);
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"\n\n{args[0]} is not a valid file path.\n\n");
                return;
            }

            if (args[1] == "--removePage")
                PdfTools.RemovePage(args[0], Int16.Parse(args[2]));


            if (args[1] == "--joinWith")
                PdfTools.JoinWith(args[0], args[2]);


            if (args[1] == "--extractPages")
                PdfTools.ExtractPages(args[0], Int16.Parse(args[2]), Int16.Parse(args[3]));
        }
    }
}
