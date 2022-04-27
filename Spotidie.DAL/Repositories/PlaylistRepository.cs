using Spotidie.DAL.EF;
using Spotidie.DAL.Entities;
using Spotidie.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Repositories
{
    public class PlaylistRepository : IRepository<Playlist>
    {
        private readonly SpotidieContext _db;

        public PlaylistRepository(SpotidieContext context)
        {
            _db = context;
        }
        public void Create(Playlist item)
        {
            _db.Playlists.Add(item);
        }

        public void Delete(Guid id)
        {
            Playlist playlist = _db.Playlists.Find(id);
            if (playlist != null)
                _db.Playlists.Remove(playlist);
        }

        public IEnumerable<Playlist> Find(Func<Playlist, bool> predicate)
        {
            return _db.Playlists.Include(o => o.PlaylistId).Where(predicate).ToList();
        }

        public Playlist Get(Guid id)
        {
            return _db.Playlists.Find(id);
        }

        public IEnumerable<Playlist> GetAll()
        {
            return _db.Playlists.Include(o => o.PlaylistId).ToList();
        }

        public void Update(Playlist item)
        {
            _db.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;

        }
    }
}
