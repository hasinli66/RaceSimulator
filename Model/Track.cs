using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Track
   {
      public string Name { get; }
      public LinkedList<Section> Sections { get; }

      public Track(string name, Section.SectionTypes[] sections)
      {
         Name = name;
         Sections = AddArrayOfSectionsToLinkedList(sections);

         //to check if they are saved or not
/*         foreach (var item in Sections)
         {
            Console.Write(item.SectionType + " -> ");
         }*/
      }

      //method for saving sectiontypes to the linkedlist 
      private LinkedList<Section> AddArrayOfSectionsToLinkedList(Section.SectionTypes[] sections)
      {
         LinkedList<Section> section = new LinkedList<Section>();

         if (sections == null)
         {
            return section;
         }

         foreach (Section.SectionTypes item in sections)
         {
            section.AddLast(new Section(item));
         }
         return section;

      }

      

   }
}
