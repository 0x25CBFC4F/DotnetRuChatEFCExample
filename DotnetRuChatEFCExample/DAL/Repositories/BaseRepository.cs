using DotnetRuChatEFCExample.DAL.Repositories.Example;
using Microsoft.EntityFrameworkCore;

namespace DotnetRuChatEFCExample.DAL.Repositories;

public class BaseRepository
{
    private readonly IDbContextFactory<ExampleDbContext> _factory;

    public BaseRepository(IDbContextFactory<ExampleDbContext> factory)
    {
        _factory = factory;
    }

    protected async Task<ExampleDbContext> GetContext() => await _factory.CreateDbContextAsync();
}