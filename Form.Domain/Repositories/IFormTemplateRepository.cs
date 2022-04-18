using Form.Domain.Entities;

namespace Form.Domain.Repositories;
public interface IFormTemplateRepository
{
    void Create(FormTemplate formTemplate);
    void Delete(FormTemplate formTemplate);
    FormTemplate GetById(int id);
    IEnumerable<FormTemplate> GetAll();
    IEnumerable<FormTemplate> GetAllQuery(string author);

}