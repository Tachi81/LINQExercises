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
           // GetInfoAboutAlbum(4);
            GenerateTrackListsOfAllAlbums();

            Console.ReadLine();

        }

        private static List<Album> GenerateAlbums()
        {
            var albums = new List<Album>(){
               new Album()
               {
                   AlbumId = 1,
                   ArtistName = "Michael Jackson",
                   AlbumName = "Thriller"
               },
               new Album()
           {
               AlbumId = 3,
               ArtistName = "Wardruna",
               AlbumName = "Runaljod-Yggdrasil"
           },
               new Album()
          {
              AlbumId = 7,
              ArtistName = "Arctic Monkeys",
              AlbumName = "Favourite Worst Nightmare"
          },
               new Album()
           {
               AlbumId = 2,
               ArtistName = "Gang Albanii",
               AlbumName = "Królowie Życia"
           },
               new Album()
          {
              AlbumId = 9,
              ArtistName = "Tremonti",
              AlbumName = "Cauterize"
          },
               new Album()
           {
               AlbumId = 4,
               ArtistName = "Depeche Mode",
               AlbumName = "Ultra"
           },
               new Album()
          {
              AlbumId = 5,
              ArtistName = "Led Zeppelin",
              AlbumName = "IV.Zoso.Four Symbols"
          },
               new Album()

          {

              AlbumId = 6,

              ArtistName = "Helloween",

              AlbumName = "The Dark Ride"

          },
               new Album()
           {
               AlbumId = 8,
               ArtistName = "Pink Floyd",
               AlbumName = "The Wall"
           }
           };
            return albums;
        }

        private static List<Track> GenerateTracks()
        {
            var tracks = new List<Track>
            {
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "In the Flesh?",
                    Duration = new TimeSpan(0, 3, 19)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "The Thin Ice",
                    Duration = new TimeSpan(0, 2, 27)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Another Brick in the Wall, Part 1",
                    Duration = new TimeSpan(0, 3, 21)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "The Happiest Days of Our Lives",
                    Duration = new TimeSpan(0, 1, 46)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Another Brick in the Wall, Part 2",
                    Duration = new TimeSpan(0, 4, 0)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Mother",
                    Duration = new TimeSpan(0, 5, 36)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Goodbye Blue Sky",
                    Duration = new TimeSpan(0, 2, 45)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Empty Spaces",
                    Duration = new TimeSpan(0, 2, 10)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Young Lust",
                    Duration = new TimeSpan(0, 3, 25)
                },

                new Track()
                {
                    AlbumId = 8,
                    TrackName = "One of My Turns",
                    Duration = new TimeSpan(0, 3, 35)
                },

                new Track()

                {
                    AlbumId = 6,
                    TrackName = "Behind The Portal (Intro)",
                    Duration = new TimeSpan(0, 0, 45)

                },

                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Mr. Torture",
                    Duration = new TimeSpan(0, 3, 28)
                },

                new Track()
                {
                    AlbumId = 6,
                    TrackName = "All Over The Nations",
                    Duration = new TimeSpan(0, 4, 55)
                },

                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Mirror Mirror",
                    Duration = new TimeSpan(0, 3, 55)
                },

                new Track()
                {

                    AlbumId = 6,
                    TrackName = "If I Could Fly",
                    Duration = new TimeSpan(0, 4, 9)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Salvation",
                    Duration = new TimeSpan(0, 5, 43)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "The Departed/The Sun Is Going Down",
                    Duration = new TimeSpan(0, 4, 37)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "I Live For Your Pain",
                    Duration = new TimeSpan(0, 3, 59)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "We Damn The Night",
                    Duration = new TimeSpan(0, 4, 07)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Immortal",
                    Duration = new TimeSpan(0, 4, 04)
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "The Dark Ride",
                    Duration = new TimeSpan(0, 8, 52)
                },

                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Black Dog",
                    Duration = new TimeSpan(0, 4, 57)
                },

                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Rock and Roll",
                    Duration = new TimeSpan(0, 3, 40)
                },

                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Going to California",
                    Duration = new TimeSpan(0, 3, 31)
                },

                new Track()
                {
                    AlbumId = 5,
                    TrackName = "When the Levee Breaks",
                    Duration = new TimeSpan(0, 7, 8)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "The Battle of Evermore",
                    Duration = new TimeSpan(0, 5, 52)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Stairway to Heaven",
                    Duration = new TimeSpan(0, 8, 3)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Misty Mountain Hop",
                    Duration = new TimeSpan(0, 4, 38)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Four Sticks",
                    Duration = new TimeSpan(0, 4, 45)
                },

                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Barrel of a Gun",
                    Duration = new TimeSpan(0, 5, 35)
                },

                new Track()
                {
                    AlbumId = 4,
                    TrackName = "The Love Thieves",
                    Duration = new TimeSpan(0, 6, 34)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Home",
                    Duration = new TimeSpan(0, 5, 43)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "It's No Good",
                    Duration = new TimeSpan(0, 5, 58)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Uselink",
                    Duration = new TimeSpan(0, 2, 22)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Useless",
                    Duration = new TimeSpan(0, 5, 12)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Sister Of Night",
                    Duration = new TimeSpan(0, 6, 04)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Jazz Thieves",
                    Duration = new TimeSpan(0, 2, 55)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Freestate",
                    Duration = new TimeSpan(0, 6, 44)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "The Bottom Line",
                    Duration = new TimeSpan(0, 4, 27)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Insight",
                    Duration = new TimeSpan(0, 6, 26)
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "Junior Painkiller",
                    Duration = new TimeSpan(0, 2, 12)
                },

                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Wanna Be Startin’ Somethin’",
                    Duration = new TimeSpan(0, 6, 4)
                },

                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Baby Be Mine",
                    Duration = new TimeSpan(0, 4, 21)
                },

                new Track()
                {
                    AlbumId = 1,
                    TrackName = "The Girl Is Mine",
                    Duration = new TimeSpan(0, 3, 43)
                },

                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Thriller",
                    Duration = new TimeSpan(0, 5, 58)
                },

                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Rotlaust tre fell",
                    Duration = new TimeSpan(0, 4, 11)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Fehu",
                    Duration = new TimeSpan(0, 6, 45)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "NaudiR",
                    Duration = new TimeSpan(0, 6, 31)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "EhwaR",
                    Duration = new TimeSpan(0, 4, 10)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "AnsuR",
                    Duration = new TimeSpan(0, 6, 31)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "IwaR",
                    Duration = new TimeSpan(0, 5, 42)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "IngwaR",
                    Duration = new TimeSpan(0, 5, 28)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Gibu",
                    Duration = new TimeSpan(0, 5, 30)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Solringen",
                    Duration = new TimeSpan(0, 6, 30)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Sowelu",
                    Duration = new TimeSpan(0, 7, 40)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Helvegen",
                    Duration = new TimeSpan(0, 7, 11)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Brianstorm",
                    Duration = new TimeSpan(0, 2, 5)
                },

                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Teddy Picker",
                    Duration = new TimeSpan(0, 4, 43)
                },

                new Track()
                {
                    AlbumId = 7,
                    TrackName = "D Is for Dangerous",
                    Duration = new TimeSpan(0, 2, 16)
                },

                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Balaclava",
                    Duration = new TimeSpan(0, 2, 49)
                },

                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Fluorescent Adolescent",
                    Duration = new TimeSpan(0, 2, 57)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Only Ones Who Know",
                    Duration = new TimeSpan(0, 3, 02)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Do Me a Favour",
                    Duration = new TimeSpan(0, 3, 27)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "This House Is a Circus",
                    Duration = new TimeSpan(0, 3, 09)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "If You Were There, Beware",
                    Duration = new TimeSpan(0, 4, 34)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "The Bad Thing",
                    Duration = new TimeSpan(0, 2, 23)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Old Yellow Bricks",
                    Duration = new TimeSpan(0, 3, 11)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Królowie życia",
                    Duration = new TimeSpan(0, 3, 10)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Kokainowy Baron",
                    Duration = new TimeSpan(0, 3, 15)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Dla prawdziwych dam",
                    Duration = new TimeSpan(0, 3, 15)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Klub Go Go",
                    Duration = new TimeSpan(0, 3, 50)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Napad na bank",
                    Duration = new TimeSpan(0, 2, 53)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Narkotykowy odlot",
                    Duration = new TimeSpan(0, 2, 49)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Wyjazd do Sopotu",
                    Duration = new TimeSpan(0, 3, 05)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Muzyka",
                    Duration = new TimeSpan(0, 2, 58)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Albański raj",
                    Duration = new TimeSpan(0, 3, 03)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Wyprawa do kasyna",
                    Duration = new TimeSpan(0, 3, 24)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Blachary",
                    Duration = new TimeSpan(0, 3, 05)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Marihuana",
                    Duration = new TimeSpan(0, 3, 01)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Jedziemy do Dubaju",
                    Duration = new TimeSpan(0, 3, 00)
                },

                new Track()

                {
                    AlbumId = 9,
                    TrackName = "Radical Change",
                    Duration = new TimeSpan(0, 4, 24)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Flying Monkeys",
                    Duration = new TimeSpan(0, 4, 44)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Cauterize",
                    Duration = new TimeSpan(0, 4, 11)
                },

                new Track()

                {
                    AlbumId = 9,
                    TrackName = "Arm Yourself",
                    Duration = new TimeSpan(0, 3, 37)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Dark Trip",
                    Duration = new TimeSpan(0, 5, 9)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Another Heart",
                    Duration = new TimeSpan(0, 3, 31)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Fall Again",
                    Duration = new TimeSpan(0, 3, 58)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Tie the Noose",
                    Duration = new TimeSpan(0, 3, 51)
                },

                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Sympathy",
                    Duration = new TimeSpan(0, 4, 39)
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Providence",
                    Duration = new TimeSpan(0, 5, 38)
                }
            };
            return tracks;
        }

        //4. Funkcje skalarne, filtrowanie, sortowanie – wybierz piosenki dla danego albumu po AlbumId. Zsumuj 
        //długośd ich trwania. Ile wynosi długośd wybranego przez Ciebie albumu? Jaka jest najdłuższa, najkrótsza 
        // piosenka? Ile trwa najdłuższa, najkrótsza piosenka? Jaka jest średnia długośd piosenki z albumu?       

        static void GetInfoAboutAlbum(int albumId)
        {
            List<Track> tracks = GenerateTracks();
            var TracksFromAlbum = tracks.Where(alb => alb.AlbumId == albumId);


            // długość trwania łącznie            
            var TotalLengthInSeconds = TracksFromAlbum.Sum(tr => tr.Duration.TotalSeconds);
            var TotalLength = TimeSpan.FromSeconds(TotalLengthInSeconds);
            Console.WriteLine($"Total Length= {TotalLength}");

            //  Ile trwa najdłuższa, najkrótsza piosenka? Jaka jest średnia długośd piosenki z albumu?
            var LongestTimeOfSong = TracksFromAlbum.Max(t => t.Duration);
            var LongestSong = TracksFromAlbum.Where(tr => tr.Duration == LongestTimeOfSong).First();
            Console.WriteLine($"Longest Song= {LongestSong.TrackName}");

            var ShortesestTimeOfSong = TracksFromAlbum.Min(t => t.Duration);
            var ShortestSong = TracksFromAlbum.Where(tr => tr.Duration == ShortesestTimeOfSong).First();
            Console.WriteLine($"Shortest Song= {ShortestSong.TrackName}");

            var AverageTimeOfSong = TracksFromAlbum.Average(t => t.Duration.TotalSeconds);
            Console.WriteLine($"Average Time Of Song= {TimeSpan.FromSeconds(AverageTimeOfSong)}");

        }

        // 5. Wykonaj złączenie albumów z piosenkami po AlbumId i wyświetl raport – tytuł i autor albumu, 
        // następnie piosenka i jej długośd. Pamiętaj, że na poprzednich warsztatach potrafiliśmy ładnie 
        // sformatowad wyświetlanie danych 

        static void GenerateTrackListsOfAllAlbums()
        {
            List<Album> albums = GenerateAlbums();
            List<Track> tracks = GenerateTracks();

            
            foreach (var album in albums)
            {
                Console.WriteLine($"Album {album.AlbumName} made by {album.ArtistName} contains songs:");
                Console.WriteLine();  // pusta linia dla oddzielenia
                foreach (var track in tracks.Where(t => t.AlbumId == album.AlbumId))
                {
                    Console.WriteLine($"{track.TrackName,-40}   {track.Duration,4}");
                }
                Console.WriteLine(); // pusta linia dla oddzielenia
            }

        }

        // 7. EF + LINQ – korzystaj z bazy AdventureWorks2012, wyświetl recenzje produktów – join!@

    }
}
