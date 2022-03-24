using System.ComponentModel.DataAnnotations;

namespace Form.Domain.Entities;

public class Address : Base
{
    public Address()
    {
        
    }
    public Address(string city, string state, string country)
    {
        City = city;
        State = state;
        Country = country;
    }


    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }


}