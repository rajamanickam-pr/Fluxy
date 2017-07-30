using System.Collections.Generic;
using Fluxy.Data.Model.Common;

namespace Fluxy.Services.Common
{
    public interface IEntityService<T> : IService
     where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();      
        void Update(T entity);
    }
}
