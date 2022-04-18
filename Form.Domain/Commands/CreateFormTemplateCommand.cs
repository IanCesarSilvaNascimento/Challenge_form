using Flunt.Notifications;
using Flunt.Validations;
using Form.Domain.Commands.Contracts;

namespace Form.Domain.Commands;

public class CreateFormTemplateCommand : Notifiable, ICommand
{
    public CreateFormTemplateCommand(string title, string author, int edition)
    {
        Title = title;
        Author = author;
        Edition = edition;
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public int Edition { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()         

        );

    }
}