using Microsoft.EntityFrameworkCore;
using NoteQuestOnline.Data;

namespace NoteQuestOnline.Repositories
{
    public abstract class BaseRepository<TEntity>
          where TEntity : class
    {
        protected ApplicationDbContext Context = null;

        public BaseRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public abstract TEntity GetById(Guid id);
        public abstract IEnumerable<TEntity> GetAll();
        public abstract IQueryable<TEntity> GetAll(bool asyn = true);
    
        public TEntity Add(TEntity entry)
        {
            Context.Set<TEntity>().Add(entry);
            return entry;
        }

        public void Remove(Guid id)
        {
            var set = Context.Set<TEntity>();
            var entity = set.Find(id);
            Context.Remove(entity);
            Commit();
        }

        public TEntity Update(TEntity entry)
        {
            Context.Entry(entry).State = EntityState.Modified;
            Context.SaveChanges();
            return entry;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
