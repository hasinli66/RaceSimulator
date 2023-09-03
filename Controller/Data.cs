using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{

   public static class Data
   {

      // opslaan competitie
      public static Competition Competition { get; set; }

      public static Race CurrentRace { get; set; }

      // competitie, participants, tracks toevoegen
      public static void Initialize()
      {
         Competition = new Competition();
         AddParticipants();
         AddTracks();

         
      }

      public static void AddParticipants()
      {
         Competition.Participants.Add(new Driver("Driver1", new Car(100, 10, 10, false), TeamColors.Red));
         Competition.Participants.Add(new Driver("Driver2", new Car(100, 10, 10, false), TeamColors.Green));
         Competition.Participants.Add(new Driver("Driver3", new Car(100, 10, 10, false), TeamColors.Yellow));
      }

      public static void AddTracks()
      {
         Competition.Tracks.Enqueue(new Track("vierkant", new[]
         {
            // east
            Section.SectionTypes.Finish,
            //east
            Section.SectionTypes.StartGrid,
            //east
            Section.SectionTypes.RightCorner,
            
            //south
            Section.SectionTypes.Straight,
            //south
            Section.SectionTypes.Straight,
            //south
            Section.SectionTypes.Straight,
            //south
            Section.SectionTypes.RightCorner,
            

            Section.SectionTypes.Straight,
            //west
            Section.SectionTypes.Straight,
            //west
            Section.SectionTypes.Straight,
            //west
            Section.SectionTypes.LeftCorner,
            //north

            //north
            Section.SectionTypes.Straight,
            //north
            Section.SectionTypes.Straight,
            //north
            Section.SectionTypes.Straight,
            //north
            Section.SectionTypes.LeftCorner,
         }));
/*
         Competition.Tracks.Enqueue(new Track("lange ovaal", new[]
           {
            SectionTypes.StartGrid,
            SectionTypes.StartGrid,
            SectionTypes.Finish,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.RightCorner,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.RightCorner,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.RightCorner,
            SectionTypes.Straight,
            SectionTypes.Straight,
            SectionTypes.RightCorner,
            }));*/

      }

      public static void NextRace()
      {
         Track trackUno = Competition.NextTrack();

         if (trackUno != null)
         {
            CurrentRace = new Race(trackUno, Competition.Participants);
         }
         else
         {
            Console.WriteLine("Er zijn geen tracks meer over");
         }
      }

   }
}
