using Bank.Model;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Bank.BL
{
    public class EntityFrameworkGenericRepository<T> : IBankGenericRepository<T> where T : class
    {
        private BankingDBContext _db;
        private IDbSet<T> _entity;

        public EntityFrameworkGenericRepository()
        {
            _db = new BankingDBContext();
            _entity = _db.Set<T>();
        }
        public IQueryable<T> GetModel()
        {
            return _entity;
        }

        public void Insert(T model)
        {
            _entity.Add(model);
            SaveChanges();

        }

        public void Update(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
            SaveChanges();

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        

        public T GetById(Guid id)
        {
           return _entity.Find(id);
        }
    }
}
