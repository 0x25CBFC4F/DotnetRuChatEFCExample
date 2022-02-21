# Example project with repository pattern for pooled Entity Framework Core

This example shows how to use Entity Framework Core with repository pattern.

Pros:
- Controllers/services know nothing about DA layer. Have no access to `DbContext<T>` lifetime or any knowledge about DbContext inner cache (EFC tracking).
- You can easily optimize any requests using different ORM libraries (for example Dapper/Linq2Sql or raw sql) with no external code changes.
- DbContext pooling enables extra performance :)

Cons:
- `await using var context = await GetContext();` in every method
- ...??

## How to add new migration
1. Move to `\DotnetRuChatEFCExample\DotnetRuChatEFCExample\`
2. Execute `dotnet ef migrations add "Example entity added" -o "./DAL/Migrations"` in any desired terminal

Enjoy 💖

PS. No viewmodels/DTO's are implemented though. Just EFC example.