using DotnetRuChatEFCExample.DAL.Models;

namespace DotnetRuChatEFCExample.DAL.Repositories.Example;

public interface IExampleRepository
{
    Task Add(ExampleEntity entity);
    Task<IEnumerable<ExampleEntity>> GetAll();
    Task<ExampleEntity> GetById(Guid id);
    void Edit(ExampleEntity entity);
    Task Remote(ExampleEntity entity);
}