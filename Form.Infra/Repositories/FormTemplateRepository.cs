using Form.Domain.Entities;
using Form.Domain.Repositories;
using Form.Infra.Data;



namespace Form.Infra.Repositories;

public class FormTemplateRepository : IFormTemplateRepository
{
    private readonly DataContext _context;

    public FormTemplateRepository(DataContext context)
    {
        _context = context;
    }

    public void Create(FormTemplate formTemplate)
    {
        _context.FormTemplates.Add(formTemplate);
        _context.SaveChanges();
    }

    public void Delete(FormTemplate formTemplate)
    {
        var item = _context.FormTemplates.FirstOrDefault(x => x.Id == formTemplate.Id);
        _context.FormTemplates.Remove(item);
        _context.SaveChanges();
    }

    public IEnumerable<FormTemplate> GetAll()
    {
        var item = _context.FormTemplates.OrderBy(x => x.CreatedDate).AsEnumerable<FormTemplate>();
        return  item;
    }

    public FormTemplate GetById(string id)
    {
        return _context.FormTemplates.FirstOrDefault(x => x.Id == id);
    }
}
