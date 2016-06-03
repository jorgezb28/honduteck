using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduteck.Repositories.Generic
{
    public interface IRepository<TEntity> where TEntity:IEntity
    {
        IEnumerable<TEntity> List { get; }
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity FindById(string id);
    }
}
