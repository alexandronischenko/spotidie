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
    public class AuthorRepository : IRepository<Author>
    {
        private readonly SpotidieContext _db;

        public AuthorRepository(SpotidieContext context)
        {
            _db = context;
        }

        public void Create(Author item)
        {
            _db.Authors.Add(item);
        }

        public void Delete(Guid id)
        {
            Author author = _db.Authors.Find(id);
            if (author != null)
                _db.Authors.Remove(author);
        }

        public IEnumerable<Author> Find(Func<Author, bool> predicate)
        {
            return _db.Authors.Include(o => o.AuthorName).Where(predicate).ToList();
        }

        public Author Get(Guid id)
        {
            return _db.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _db.Authors.Include(o=>o.AuthorName).ToList();
        }

        public void Update(Author author)
        {
            _db.Entry(author).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
    }
}
