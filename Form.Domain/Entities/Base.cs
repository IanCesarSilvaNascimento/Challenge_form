namespace Form.Domain.Entities;

public abstract class Base
{
    protected Base()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; private set; }
}