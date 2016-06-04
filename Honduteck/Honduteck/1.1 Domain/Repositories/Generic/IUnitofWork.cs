using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduteck._1._1_Domain.Repositories.Generic
{
    public interface IUnitofWork: IDisposable
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : class;
        void SetModified<TEntity>(TEntity item) where TEntity : class;
        void Commit();
    }
}
