using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class MainUser
    {
        public Guid MainUserId { get; set; }
        public string MainUserEmail { get; set; }
        public string MainUserPassword { get; set; }
        public string MainUserName { get; set; }
        public bool MainUserIsPremium { get; set; }
        public bool MainUserIsAdmin { get; set; }
        public byte[] MainUserAvatar { get; set; }

        //Link to Playlist
        public List<Playlist> Playlists { get; set; }

    }
}
