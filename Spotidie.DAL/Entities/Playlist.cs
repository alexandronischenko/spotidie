using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class Playlist
    {
        public Guid PlaylistId { get; set; }
        public string PlaylistName { get; set; }       
        public string PlaylistAvatar { get; set; }
        
        public int PlaylistForeignKey{ get; set; }
        public Guid PlaylistForeignKeyGuid{ get; set; }


        //Link to User
        // [NotMapped]
        // public MainUser MainUser { get; set; }
        // [ForeignKey("MainUserForeignKey")]
        // public Guid MainUserForeignKey { get; set; }
        
        //Link to Track
        public List<Track> Track { get; set; }

        // public Guid? MainUserId { get; set; } // Foreign key
        // public MainUser MainUser { get; set; } // Reference navigation
        //
        // public IList<Track> Tracks { get; set; } = new List<Track>(); // Skip collection navigation
    }
}
