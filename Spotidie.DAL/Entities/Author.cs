using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotidie.DAL.Entities
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorAvatar { get; set; }

        //Link to Track
        public List<Track> Tracks { get; set; }
    }
}
