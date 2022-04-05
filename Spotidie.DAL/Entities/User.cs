using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public bool UserIsPremium { get; set; }
        public bool UserIsAdmin { get; set; }
        public byte[] UserAvatar { get; set; }

        //Link to Playlist
        public List<Playlist> Playlists { get; set; }

    }
}
