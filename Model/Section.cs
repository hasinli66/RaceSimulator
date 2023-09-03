using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Section
   {
      public string[] SectionString { get; set; }
      public SectionTypes SectionType { get; set; }

      public enum SectionTypes { Straight, LeftCorner, RightCorner, StartGrid, Finish }



      /*public enum Direction { NORTH, EAST, SOUTH, WEST}*/

      public Section(SectionTypes sectiontype)
      {
         SectionType = sectiontype;
      }

      //Update X  en Y aan de hand van de direction
/*      public void DrawSection()
      {
         foreach (var layer in SectionString)
         {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(layer);
         }
      }*/

   }
   


}
