using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WdProject.EntityFramework.Repositories
{
    public abstract class WdProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WdProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WdProjectRepositoryBase(IDbContextProvider<WdProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WdProjectRepositoryBase<TEntity> : WdProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WdProjectRepositoryBase(IDbContextProvider<WdProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
