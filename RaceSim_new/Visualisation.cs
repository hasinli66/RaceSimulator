using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;
using static Model.Section;
using Controller;
using System.Data;

namespace RaceSim_new
{
   public static class Visualisation
   {
      public static Direction _direction;
      public static int _x, _y, _size;

      public static int initialCursorPosX = 25;
      public static int initialCursorPosY = 6;
      public static Dictionary<int, Direction> _sectionDirections = new Dictionary<int, Direction>();
     

      public enum Direction
      {
         North, East, South, West
      }

      public static void initialize()
      {
         
         Console.CursorVisible = true;
         Console.SetCursorPosition(initialCursorPosX, initialCursorPosY);
         /*Console.WriteLine($"Track:{Data.CurrentRace.Track.Name}");*/
         DrawTrack(Data.CurrentRace.Track);
         _direction = Direction.East;
         _size = 4;
      }

      #region graphics

      private static string[] _finishHorizontal = { "────", " ## ", " ## ", "────" };
            
/*          ────
             ## 
             ## 
            ────*/
            
            private static string[] _horizontalRoad = { "────", "    ", "    ", "────" };
/*            
            ────


            ───-*/
            
            private static string[] _verticalRoad = { "|  |", "|  |", "|  |", "|  |" };
            
/*          |  |
            |  |
            |  |
            |  |*/
            
            private static string[] _cornerNE = { "---┐", "   |", "   |", "┐  |" };
            
/*          ---┐
               |
               |
            ┐  |*/
            
            private static string[] _cornerNW = { "┌---", "|   ", "|   ", "|  ┌" };
            
/*          ┌---
            |
            |  
            |  ┌	
            */
            private static string[] _cornerSE = { "┘  |", "   |", "   |", "---┘" };
            
/*          ┘  |
               |
               |
            ---┘*/
            
            private static string[] _cornerSW = { "|  └", "|   ", "|   ", "└---" };
            
/*          |  └
            |   
            |  
            └---*/

      #endregion

      //oefenen
      
      public static void DrawTrack(Track t)
      {

         foreach (var item in _sectionDirections)
         {

               foreach (Section section in t.Sections)
               {

                  switch (section.SectionType)
                  {
                     case SectionTypes.Finish:
                        
                        break;

                     case SectionTypes.Straight:
                        
                        break;

                     case SectionTypes.StartGrid:
                        
                        break;

                     case SectionTypes.RightCorner:
                        
                        break;

                     case SectionTypes.LeftCorner:

                        break;

                  }
               }

            switch (_direction)
            {
               case Direction.North:
                  _y -= _size;
                  break;
               case Direction.East:
                  _x += _size;
                  break;
               case Direction.South:
                  _y += _size;
                  break;
               case Direction.West:
                  _x -= _size;
                  break;
            }
            Console.SetCursorPosition(_x, _y);
         }

         }

        

      public static void TranslateSectionIntoString(SectionTypes sectiontype)
      {
         if (sectiontype.Equals(SectionTypes.Finish))
         {
            foreach (string s in _finishHorizontal)
            {
               Console.WriteLine(s);
            }
         }
         else if (sectiontype.Equals(SectionTypes.StartGrid))
         {
            foreach (string s in _horizontalRoad)
            {
               Console.WriteLine(s);
            }
         }
         else if (sectiontype.Equals(SectionTypes.RightCorner))
         {

            if (_direction == Direction.East)
            {
               foreach (string s in _cornerNE)
               {
                  Console.WriteLine(s);
               }
            }
            else if (_direction == Direction.South)
            {
               foreach (string s in _cornerSE)
               {
                  Console.WriteLine(s);
               }
            }

         }
         else if (sectiontype.Equals(SectionTypes.LeftCorner))
         {

            if (_direction == Direction.West)
            {
               foreach (string s in _cornerSW)
               {
                  Console.WriteLine(s);
               }
            }
            else if (_direction == Direction.North)
            {
               foreach (string s in _cornerNW)
               {
                  Console.WriteLine(s);
               }
            }

         }
         else if (sectiontype.Equals(SectionTypes.Straight))
         {

            if (_direction == Direction.South || _direction == Direction.North)
            {
               foreach (string s in _verticalRoad)
               {
                  Console.WriteLine(s);
               }
            }
            else if (_direction == Direction.West)
            {
               foreach (string s in _horizontalRoad)
               {
                  Console.WriteLine(s);
               }
            }

         }

      }

      public static void DetermineDirection(Track t)
      {
            
         _sectionDirections.Add(1, Direction.East);
         _sectionDirections.Add(2, Direction.East);
         _sectionDirections.Add(3, Direction.East);
         _sectionDirections.Add(4, Direction.South);
         _sectionDirections.Add(5, Direction.South);
         _sectionDirections.Add(6, Direction.South);
         _sectionDirections.Add(7, Direction.South);
         _sectionDirections.Add(8, Direction.West);
         _sectionDirections.Add(9, Direction.West);
         _sectionDirections.Add(10, Direction.West);
         _sectionDirections.Add(11, Direction.West);
         _sectionDirections.Add(12, Direction.North);
         _sectionDirections.Add(13, Direction.North);
         _sectionDirections.Add(14, Direction.North);
         _sectionDirections.Add(15, Direction.North);

      }
      

     
   }
}
