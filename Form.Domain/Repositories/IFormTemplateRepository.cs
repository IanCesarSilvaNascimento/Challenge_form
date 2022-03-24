

using Form.Domain.Entities;

namespace Form.Domain.Repositories;
public interface IFormTemplateRepository
{
    void Create(FormTemplate formTemplate);
    void Delete(FormTemplate formTemplate);
    FormTemplate GetById(string id);
    IEnumerable<FormTemplate> GetAll();

}