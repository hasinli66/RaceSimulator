using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ControllerTest
{
   [TestFixture]
   public class Model_Competition_NextTrackShould
   {
      private Competition _competition;

      [SetUp]
      public void SetUp()
      {
         _competition = new Competition();
      }

      [Test]
      public void NextTrack_EmptyQueue_ReturnNull()
      {

         //arange + act
         var result = _competition.NextTrack();

         //assert
         Assert.IsNull(result);
      }

      [Test]
      public void NextTrack_OneInQueue_ReturnTrack()
      {
         //arange
         Track track1 = new Track("track2", new SectionTypes[] { SectionTypes.StartGrid });

         //act
         _competition.Tracks.Enqueue(track1);

         //assert
         Assert.AreEqual(track1, _competition.Tracks.Peek());
      }

      [Test]
      public void NextTrack_OneInQueue_RemoveTrackFromQueue()
      {
         //arange
         Track track1 = new Track("track1", new SectionTypes[] { SectionTypes.StartGrid });

         //act
         var result = _competition.NextTrack(); 
         result = _competition.NextTrack();

         //assert
         Assert.IsNull(result);
      }

      [Test]
      public void NextTrack_TwoInQueue_ReturnNextTrack()
      {
         //arange
         Track track1 = new Track("track1", new SectionTypes[] { SectionTypes.StartGrid });
         Track track2 = new Track("track2", new SectionTypes[] { SectionTypes.StartGrid });

         //act
         _competition.Tracks.Enqueue(track1);
         _competition.Tracks.Enqueue(track2);
         var result = _competition.NextTrack();
         result = _competition.NextTrack();

         //assert
         Assert.AreEqual(track2,result);
      }

   }
}
