using Microsoft.EntityFrameworkCore;
using Spotidie.DAL.EF;
using Spotidie.DAL.Entities;
using Spotidie.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Repositories
{
    public class EFUnitOfWork: IUnitOfWork
    {
        private SpotidieContext _db;
        private AuthorRepository _authorRepository;
        private PlaylistRepository _playlistRepository;
        private TrackRepository _trackRepository;
        private MainUserRepository _mainUserRepository;

        public EFUnitOfWork(DbContextOptions<SpotidieContext> options)
        {
            _db = new SpotidieContext(options);

        }
        public IRepository<Author> Authors
        {
            get {
                if (_authorRepository == null)
                    _authorRepository = new AuthorRepository(_db);
                return _authorRepository;
            }
        }

        public IRepository<Playlist> Playlists
        {
            get
            {
                if (_playlistRepository == null)
                    _playlistRepository = new PlaylistRepository(_db);
                return _playlistRepository;
            }
        }

        public IRepository<Track> Tracks
        {
            get
            {
                if (_trackRepository == null)
                    _trackRepository = new TrackRepository(_db);
                return _trackRepository;
            }
        }

        public IRepository<MainUser> MainUsers
        {
            get
            {
                if (_mainUserRepository == null)
                    _mainUserRepository = new MainUserRepository(_db);
                return _mainUserRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

