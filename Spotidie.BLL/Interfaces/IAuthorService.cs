using BLL.ModelsDTO;

namespace BLL.Interfaces;

public interface IAuthorService
{
    Task<AuthorDTO> GetAuthor(string id);

    Task CreateAuthor(AuthorDTO author);

    Task DeleteAuthor(string id);
    
    IEnumerable<AuthorDTO> GetAuthor();

    IEnumerable<AuthorDTO> GetAuthors();

    IEnumerable<AuthorDTO> FindAuthor(string name);
}