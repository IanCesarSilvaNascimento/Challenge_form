using System.ComponentModel.DataAnnotations;

namespace Form.Domain.Entities;

public class User : Base
{
    public User()
    {
        
    }
    public User(string firstName, string lastName, string gender, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Email = email;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Gender { get; private set; }
    public string Email { get; private set; }


}