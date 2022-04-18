using Form.Domain.Commands;
using Form.Domain.Entities;
using Form.Domain.Handlers;
using Form.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Form.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FormTemplateController : ControllerBase
{
    [HttpGet("")]
    public IEnumerable<FormTemplate> GetAllFormTemplates(
        [FromServices] IFormTemplateRepository repository)
    {

        return repository.GetAll();
    }

    [HttpGet("/{author}")]
    public IEnumerable<FormTemplate> GetAllQueryFormTemplates(
        [FromRoute] string author,
        [FromServices] IFormTemplateRepository repository)
    {      
        return repository.GetAllQuery(author);
    }


    [HttpPost("")]
    public CommandResult CreateFormTemplate(
        [FromBody] CreateFormTemplateCommand command,
        [FromServices] FormTemplateHandler handler)
    {

        return (CommandResult)handler.Handle(command);
    }


    [HttpDelete("/{id:int}")]
    public CommandResult DeleteById(
        [FromRoute] int id,
        [FromServices] FormTemplateHandler handler)
    {
        var command = new DeleteFormTemplateCommand(id);
        return (CommandResult)handler.Handle(command);
    }



}
