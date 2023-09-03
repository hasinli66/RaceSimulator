using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public class Race
   {
      private Random _random;
      public Track Track { get; set; }
      public List<IParticipant> Participants { get; set; }
      public DateTime StartTime { get; set; }
      private Dictionary<Section, SectionData> _positions;

      public Race(Track track, List<IParticipant> participants)
      {

         Track = track; 
         Participants = participants;

         _random = new Random(DateTime.Now.Millisecond);
         _positions = new Dictionary<Section, SectionData>();

         

         RandomizeEquipment();

      }

      public SectionData GetSectionData(Section section)
      {
         if (!_positions.ContainsKey(section))
         {
            _positions.Add(section, new SectionData());
         }
         return _positions[section];
      }

      //Om de race spannend te maken gaan je de waarden
      //van de apparatuur bij de deelnemers wat aanpassen.
      //Dit maakt elke race wat onvoorspelbaarder.
      public void RandomizeEquipment()
      {
         for (int i = 0; i < Participants.Count; i++)
         {
            Participants[i].Equipment.Quality = _random.Next(10, 20);
            Participants[i].Equipment.Performance = _random.Next(10, 20);

            //
         }
      }
   }
}
