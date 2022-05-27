﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string MainUserAvatar { get; set; }
        
        public int MainUserForeignKey{ get; set; }
        public Guid MainUserForeignKeyGuid{ get; set; }

            
        //Link to Playlist
         public List<Playlist> Playlists { get; set; }
        
        
        // public IList<Playlist> Playlists { get; set; } = new List<Playlist>(); // Collection navigation
    }
    
}
