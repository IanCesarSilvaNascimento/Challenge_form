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


    [HttpPost("")]
    public CommandResult CreateFormTemplate(
        [FromBody] CreateFormTemplateCommand command,
        [FromServices] FormTemplateHandler handler)
    {

        return (CommandResult)handler.Handle(command);
    }


    [HttpDelete("")]
    public CommandResult DeleteById(
        [FromBody] string id,
        [FromServices] FormTemplateHandler handler)
    {
        var command = new DeleteFormTemplateCommand(id);
        return (CommandResult)handler.Handle(command);
    }



}
