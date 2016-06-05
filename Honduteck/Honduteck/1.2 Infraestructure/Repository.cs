using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Honduteck.Repositories.Generic;
using Honduteck._1._1_Domain.Repositories.Generic;

namespace Honduteck._1._2_Infraestructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:IEntity
    {
        public IUnitofWork UnitofWork { get; }

        public Repository(IUnitofWork unitofWork)
        {
            if (unitofWork == null)
                throw new ArgumentNullException("unitOfWork");
            UnitofWork = unitofWork;
        }

        public void Dispose()
        {
            UnitofWork?.Dispose();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return GetSet();
        }

        IDbSet<TEntity> GetSet()
        {
            return UnitofWork.CreateSet<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                GetSet().Add(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                GetSet().Remove(entity);
            }
        }

        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                UnitofWork.SetModified(entity);
            }
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            return GetSet().FirstOrDefault(filter);
        }

        public override string ToString()
        {
            return "MyRepository with type : " + typeof(TEntity).Name;
        }
    }
}
