using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosScreen
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                screens.Main();
                var input = Console.ReadLine();
            
            }
            
            
        }
    }
    class randomScreen
    {
        public static int x = 0; public static int y = 0; public static int width = 79; public static int height = 22;
        public static String a = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ+ »«?)(/&%$#\"|!#$%&/()=?";
        public static String chrs = " ";
        public static void Writer()
        {
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.WriteLine(chrs);
        }
        public static void gets()
        {
            Random r = new Random();
            int l = a.Length - 3;
            x = r.Next(width);
            y = r.Next(height);
            l = r.Next(l);
            chrs = a.Substring(l, 1);
        }
        public static void screenLoop(int x, int y)
        {
            width = x; height = y;
            while (true)

            {
                gets();
                Writer();
                System.Threading.Thread.Sleep(10);
                if (Console.KeyAvailable) break;
            }


        }
    }

    class screens
    {


        public static void Main()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            randomScreen.screenLoop(Console.WindowWidth - 3, Console.WindowHeight - 3);

        }




    }


}
