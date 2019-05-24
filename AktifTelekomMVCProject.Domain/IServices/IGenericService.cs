using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktifTelekomMVCProject.Domain
{
    public interface IGenericService<T>
    {
        Task Add(T entity);
        Task<List<T>> GetAll();
        Task Update(T entity);
        Task Delete(T entity);
        Task DeleteById(int id);
        Task<T> GetById(int id);
    }
}
