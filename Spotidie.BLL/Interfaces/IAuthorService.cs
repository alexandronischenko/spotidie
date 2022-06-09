using BLL.ModelsDTO;

namespace BLL.Interfaces;

public interface IAuthorService
{
    Task<AuthorDTO> GetAuthor(string id);

    Task CreateAuthor(AuthorDTO author);

    Task DeleteAuthor(string id);
    
    IEnumerable<AuthorDTO> GetAuthorById(string id);

    IEnumerable<AuthorDTO> GetAuthors();

    IEnumerable<AuthorDTO> FindAuthor(string name);
}