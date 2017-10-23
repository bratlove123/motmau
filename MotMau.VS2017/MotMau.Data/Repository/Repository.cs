using Microsoft.EntityFrameworkCore;
using MotMau.Core.Base;
using MotMau.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MotMau.Core.Repository
{
    public partial class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext _context;
        private DbSet<T> _entities;

        public Repository(MotMauDataContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return _entities;
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                _entities.Remove(entity);
            }
            catch (DbUpdateException)
            {
                _context.Entry(entity).State = EntityState.Detached;
                throw;
            }
        }

        public virtual T GetById(object id)
        {
            return _entities.Find(id);
        }

        public virtual void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                _entities.Add(entity);
            }
            catch (DbUpdateException)
            {
                _context.Entry(entity).State = EntityState.Detached;
                throw;
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                _entities.Update(entity);
            }
            catch (DbUpdateException)
            {
                _context.Entry(entity).State = EntityState.Detached;
                throw;
            }
        }
    }
}
