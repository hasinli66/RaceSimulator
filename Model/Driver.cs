using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Driver : IParticipant
   {
      public string Name { get; set; }
      public int Points { get; set; }
      public IEquipment Equipment { get; set; }
      public TeamColors TeamColor { get; set; }

      public Driver(string name, IEquipment equipment, TeamColors teamcolor)
      {
         Name = name;
         Equipment = equipment;
         TeamColor = teamcolor;

         Points = 0;
      }

   }
}
