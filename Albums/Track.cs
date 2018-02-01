using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albums
{
    class Track
    {
        public int TrackId { get; set; }

        public int AlbumId { get; set; }

        public string TrackName { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
