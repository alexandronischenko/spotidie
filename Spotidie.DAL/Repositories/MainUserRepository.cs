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
    public class MainUserRepository : IRepository<MainUser>
    {
        private readonly SpotidieContext _db;

        public MainUserRepository(SpotidieContext context)
        {
            _db = context;
        }

        public void Create(MainUser item)
        {
            _db.MainUsers.Add(item);
        }

        public void Delete(Guid id)
        {
            MainUser mainUser= _db.MainUsers.Find(id);
            if (mainUser != null)
                _db.MainUsers.Remove(mainUser);
        }

        public IEnumerable<MainUser> Find(Func<MainUser, bool> predicate)
        {
            return _db.MainUsers.Include(o => o.MainUserId).Where(predicate).ToList();
        }

        public MainUser Get(Guid id)
        {
            return _db.MainUsers.Find(id);
        }

        public IEnumerable<MainUser> GetAll()
        {
            return _db.MainUsers.Include(o => o.MainUserId).ToList();
        }

        public void Update(MainUser item)
        {
            _db.Entry(item).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }
    }
}
