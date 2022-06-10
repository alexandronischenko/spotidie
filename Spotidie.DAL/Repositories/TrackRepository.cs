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
    public class TrackRepository : IRepository<Track>
    {
        private readonly SpotidieContext _db;

        public TrackRepository(SpotidieContext context)
        {
            _db = context;
        }

        public void Create(Track item)
        {
            _db.Tracks.Add(item);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Track track = _db.Tracks.Find(id);
            if (track != null)
                _db.Tracks.Remove(track);
        }

        public IEnumerable<Track> Find(Func<Track, bool> predicate)
        {
            return _db.Tracks.Include(o => o.TrackName).Where(predicate).ToList();
        }

        public Track Get(Guid id)
        {
            return _db.Tracks.Find(id);
        }

        public IEnumerable<Track> GetAll()
        {
            return _db.Tracks.Include(o => o.TrackName).ToList();
        }

        public void Update(Track item)
        {
            _db.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
    }
}
