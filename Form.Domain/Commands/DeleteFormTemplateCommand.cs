using Flunt.Notifications;
using Flunt.Validations;
using Form.Domain.Commands.Contracts;

namespace Form.Domain.Commands;
public class DeleteFormTemplateCommand : Notifiable, ICommand
{
    public DeleteFormTemplateCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract()
             .Requires()                   

         );

    }
}