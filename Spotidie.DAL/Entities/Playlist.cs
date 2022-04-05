﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class Playlist
    {
        public Guid PlaylistId { get; set; }
        public byte[] PlaylistAvatar { get; set; }

        //Link to User
        public User User { get; set; }

        //Link to Track
        public List<Track> Tracks { get; set; }

    }
}
