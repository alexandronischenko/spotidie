using Spotidie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> Authors { get; }
        IRepository<Playlist> Playlists { get; }
        IRepository<Track> Tracks { get; }
        IRepository<MainUser> MainUsers { get; }

        void Save();    
}
}
