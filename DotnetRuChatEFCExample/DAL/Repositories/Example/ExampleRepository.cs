using DotnetRuChatEFCExample.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetRuChatEFCExample.DAL.Repositories.Example;

public class ExampleRepository : BaseRepository, IExampleRepository
{
    public ExampleRepository(IDbContextFactory<ExampleDbContext> factory) : base(factory) {}
    
    public async Task Add(ExampleEntity entity)
    {
        await using var context = await GetContext();
        context.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ExampleEntity>> GetAll()
    {
        await using var context = await GetContext();
        return await context.ExampleEntities.ToArrayAsync();
    }

    public async Task<ExampleEntity> GetById(Guid id)
    {
        await using var context = await GetContext();
        return await context.ExampleEntities.FirstOrDefaultAsync(e => e.Id.Equals(id));
    }

    public async void Edit(ExampleEntity entity)
    {
        await using var context = await GetContext();
        context.ExampleEntities.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task Remote(ExampleEntity entity)
    {
        await using var context = await GetContext();
        context.ExampleEntities.Attach(entity);
        context.ExampleEntities.Remove(entity);
        await context.SaveChangesAsync();
    }
}