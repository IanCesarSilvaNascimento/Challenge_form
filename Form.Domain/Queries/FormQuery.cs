using System.Linq.Expressions;
using Form.Domain.Entities;

namespace Form.Domain.Queries;

    public static class FormQuery
    {
        public static Expression<Func<FormTemplate, bool>> GetAllQuery(string author)
        {
            return x => x.Author == author;
        }
     
    }
