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
    public class UserRepository : IRepository<User>
    {
        private readonly SpotidieContext _db;

        public UserRepository(SpotidieContext context)
        {
            _db = context;
        }

        public void Create(User item)
        {
            _db.Users.Add(item);
        }

        public void Delete(Guid id)
        {
            User user = _db.Users.Find(id);
            if (user != null)
                _db.Users.Remove(user);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return _db.Users.Include(o => o.UserName).Where(predicate).ToList();
        }

        public User Get(int id)
        {
            return _db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users.Include(o => o.UserName).ToList();
        }

        public void Update(User item)
        {
            _db.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
    }
}
