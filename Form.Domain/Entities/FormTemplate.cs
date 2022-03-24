namespace Form.Domain.Entities;

public class FormTemplate : Base
{
    public FormTemplate()
    {

    }
    public FormTemplate(User user, Address address)
    {
        User = user;
        Address = address;
        CreatedDate = DateTime.UtcNow.Date;
    }


    public User User { get; private set; }
    public Address Address { get; private set; }
    public DateTime CreatedDate { get; private set; }
}