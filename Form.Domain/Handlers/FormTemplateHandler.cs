using Flunt.Notifications;
using Form.Domain.Commands;
using Form.Domain.Commands.Contracts;
using Form.Domain.Entities;
using Form.Domain.Handlers.Contracts;
using Form.Domain.Repositories;

namespace Form.Domain.Handlers;

public class FormTemplateHandler :
    Notifiable,
    IHandler<CreateFormTemplateCommand>,
    IHandler<DeleteFormTemplateCommand>

{
    private readonly IFormTemplateRepository _repository;

    public FormTemplateHandler(IFormTemplateRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateFormTemplateCommand command)
    {
        // Fail Fast Validations
        command.Validate();
        if (command.Invalid)
        {
            AddNotifications(command);
            return new CommandResult(false, "Não foi possível incluir seu formulário", command.Notifications);
        }

        var user = new User(command.FirstName, command.LastName, command.Gender, command.Email);
        var address = new Address(command.City, command.State, command.Country);
        var formTemplate = new FormTemplate(user, address);

        _repository.Create(formTemplate);

        return new CommandResult(true, "Formulário incluído com sucesso", command);
    }

    public ICommandResult Handle(DeleteFormTemplateCommand command)
    {
        // Fail Fast Validations
        command.Validate();
        if (command.Invalid)
        {
            AddNotifications(command);
            return new CommandResult(false, "Não foi possível deletar seu formulário", command.Notifications);
        }

        var formTemplate = _repository.GetById(command.Id);

        _repository.Delete(formTemplate);
    
        return new CommandResult(true, "Formulário deletado com sucesso", command);
    }
}
