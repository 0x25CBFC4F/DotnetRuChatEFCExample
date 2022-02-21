using DotnetRuChatEFCExample.DAL.Models;
using DotnetRuChatEFCExample.DAL.Repositories.Example;
using Microsoft.AspNetCore.Mvc;

namespace DotnetRuChatEFCExample.Controllers;

[ApiController]
[Route("api/v1/example")]
public class ExampleController : ControllerBase
{
    private readonly IExampleRepository _exampleRepository;

    public ExampleController(IExampleRepository exampleRepository)
    {
        _exampleRepository = exampleRepository;
    }
    
    [HttpGet]
    public async Task<IEnumerable<ExampleEntity>> GetAll()
    {
        return await _exampleRepository.GetAll();
    }

    [HttpGet("{id:guid}")]
    public async Task<ExampleEntity> GetById([FromRoute] Guid id)
    {
        return await _exampleRepository.GetById(id);
    }

    [HttpPost("add")]
    public async Task<ExampleEntity> Add([FromBody] ExampleEntity entity)
    {
        await _exampleRepository.Add(entity);
        return entity;
    }

    [HttpPost("edit")]
    public async Task<ExampleEntity> Edit([FromBody] ExampleEntity entity)
    {
        await _exampleRepository.Edit(entity);
        return entity;
    }

    [HttpDelete("delete/{exampleEntityId:guid}")]
    public async Task Delete([FromRoute] Guid exampleEntityId)
    {
        var entity = await _exampleRepository.GetById(exampleEntityId);
        await _exampleRepository.Remove(entity);
    }
}