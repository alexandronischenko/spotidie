using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class Track
    {
        public Guid TrackId { get; set; }
        public string TrackName { get; set; }
        public int TrackDuration { get; set; }
        public byte[] TrackData { get; set; }       
        public byte[] TrackAvatar{ get; set; }

        //Link to Playlist
        public Playlist Playlist { get; set; }

        //Link to Author
        public Author Author { get; set; }

    }
}
