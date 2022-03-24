using Flunt.Notifications;
using Flunt.Validations;
using Form.Domain.Commands.Contracts;

namespace Form.Domain.Commands;
public class DeleteFormTemplateCommand : Notifiable, ICommand
{
    public DeleteFormTemplateCommand(string id)
    {
        Id = id;
    }

    public string Id { get; private set; }

    public void Validate()
    {
        AddNotifications(new Contract()
             .Requires()                   

         );

    }
}