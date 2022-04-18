namespace Form.Domain.Entities;

public class FormTemplate : Base
{
    public FormTemplate(string title, string author, int edition)
    {
        Title = title;
        Author = author;
        Edition = edition;
    }

    public string Title { get; set; }
    public string  Author { get; set; }
    public int  Edition { get; set; }
   
}