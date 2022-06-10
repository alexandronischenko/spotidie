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
        public string TrackData { get; set; }
        
        public byte[] TrackDataByte { get; set; }
        public string TrackAvatar{ get; set; }
        
        public int TrackForeignKey{ get; set; }


        // //Link to Playlist
        // public Playlist Playlist { get; set; }

        //Link to Author
        public Author Author { get; set; }
        public Playlist Playlist { get; set; }
    }
}
