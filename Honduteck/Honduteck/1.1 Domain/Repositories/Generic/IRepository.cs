using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Honduteck._1._1_Domain.Repositories.Generic;

namespace Honduteck.Repositories.Generic
{
    public interface IRepository<TEntity> :IDisposable where TEntity:IEntity
    {
        IUnitofWork UnitofWork { get; }

        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetSingle(Expression<Func<TEntity, bool>> filter);
    }
}
