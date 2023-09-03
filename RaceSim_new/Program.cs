using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;


namespace RaceSim_new
{
   public class Program
   {
      public static void Main(string[] args)
      {
         Console.BackgroundColor = ConsoleColor.DarkMagenta;
         Console.Clear();

         Data.Initialize();
         Data.NextRace();
         Visualisation.initialize();

         for (; ; )
         {
            Thread.Sleep(100);
         }
      }

      


   }
}
