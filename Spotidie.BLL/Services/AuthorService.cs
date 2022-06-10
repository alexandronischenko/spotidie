using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Spotidie.DAL.Entities;
using Spotidie.DAL.Interfaces;

namespace BLL.Services;

public class AuthorService : IAuthorService
{
    public AuthorService(IUnitOfWork db)
    {
        Db = db;
    }

    private IUnitOfWork Db { get; set; }
    
    public async Task<AuthorDTO> GetAuthor(string id)
    {
        if (id == null)
            throw new Exception("Id is null");

        var author = Db.Authors.Get(Guid.Parse(id));

        if (author == null)
            throw new Exception("Playlist not found");

        return DTOMapper.MapAuthor(author);
    }

    public Task CreateAuthor(AuthorDTO author)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAuthor(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AuthorDTO> GetAuthorById()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AuthorDTO> FindAuthor(string name)
    {
        if (name == null)
            throw new Exception("name is null");
        var authors = Db.Authors.Find(x => x.AuthorForeignKey.ToString()==name);
        
        var result = new List<AuthorDTO>();
        
        foreach (var author in authors)
        {
            result.Add(DTOMapper.MapAuthor(author));
        }

        return result;
    }

    public IEnumerable<AuthorDTO> GetAuthorById(string id)
    {
        var authors = Db.Authors.GetAll();
        
        if (authors == null)
            throw new Exception("Playlist not found");

        return DTOMapper.MapAuthors(authors);    }

    public IEnumerable<AuthorDTO> GetAuthors()
    {
        var authors = Db.Authors.GetAll();

        if (authors == null)
            throw new Exception("Playlist not found");

        return DTOMapper.MapAuthors(authors);
    }
}