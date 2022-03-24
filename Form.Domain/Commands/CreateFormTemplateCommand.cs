using Flunt.Notifications;
using Flunt.Validations;
using Form.Domain.Commands.Contracts;

namespace Form.Domain.Commands;

public class CreateFormTemplateCommand : Notifiable, ICommand
{
    public CreateFormTemplateCommand(string firstName, string lastName, string gender, string email, string city, string state, string country)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Email = email;
        City = city;
        State = state;
        Country = country;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Gender { get; private set; }
    public string Email { get; private set; }

    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "User.FirstName", "Primeiro nome deve ter no mínimo 3 caracteres.")
            .HasMaxLen(FirstName, 40, "User.FirstName", "Primeiro nome deve ter no máximo 40 caracteres.")
            .HasMinLen(LastName, 3, "User.LastName", "Último nome deve ter no mínimo 3 caracteres.")
            .HasMaxLen(LastName, 40, "User.LastName", "Último nome deve ter no máximo 40 caracteres.")
            .HasMinLen(Gender, 3, "User.Gender", "Gênero  deve ter no mínimo 3 caracteres.")
            .HasMaxLen(Gender, 40, "User.Gender", "Gênero deve ter no máximo 40 caracteres.")
            .HasMinLen(City, 3, "Address.City", "Cidade  deve ter no mínimo 3 caracteres.")
            .HasMaxLen(City, 40, "Address.City", "Cidade deve ter no máximo 40 caracteres.")
            .HasMinLen(State, 3, "Address.State", "Estado  deve ter no mínimo 3 caracteres.")
            .HasMaxLen(State, 40, "Address.State", "Estado deve ter no máximo 40 caracteres.")
            .HasMinLen(Country, 3, "Address.Country", "País  deve ter no mínimo 3 caracteres.")
            .HasMaxLen(Country, 40, "Address.Country", "País deve ter no máximo 40 caracteres.")
            .IsEmail(Email,"User.Email","Email inválido")

        );

    }
}