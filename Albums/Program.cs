using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albums
{
    class Program
    {
        static void Main(string[] args)
        {

        }

       
        private static void GenerateAlbumsAndTracks()
        {
            var album = new Album()
            {
                AlbumId = 4,
                ArtistName = "Depeche Mode",
                AlbumName = "Ultra"
            };

            var tracks = new List<Track>();

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Barrel of a Gun",
                Duration = new TimeSpan(0, 5, 35)
            });          
            
            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "The Love Thieves",
                Duration = new TimeSpan(0, 6, 34)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Home",
                Duration = new TimeSpan(0, 5, 43)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "It's No Good",
                Duration = new TimeSpan(0, 5, 58)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Uselink",
                Duration = new TimeSpan(0, 2, 22)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Useless",
                Duration = new TimeSpan(0, 5, 12)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Sister Of Night",
                Duration = new TimeSpan(0, 6, 04)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Jazz Thieves",
                Duration = new TimeSpan(0, 2, 55)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Freestate",
                Duration = new TimeSpan(0, 6, 44)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "The Bottom Line",
                Duration = new TimeSpan(0, 4, 27)
            });  

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Insight",
                Duration = new TimeSpan(0, 6, 26)
            });

            tracks.Add(new Track()
            {
                AlbumId = 4,
                TrackName = "Junior Painkiller",
                Duration = new TimeSpan(0, 2, 12)
            });
        }
    }
}
