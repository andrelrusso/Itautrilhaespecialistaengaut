using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDesSoftware.Repositorio.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected readonly EFContexto Db;
        private readonly DbSet<T> DbSet;

        public BaseRepositorio(EFContexto context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual T Adicionar(T entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();

            return entity;
        }

        public virtual void Atualizar(T obj)
        {
            DbSet.Update(obj);
            Db.SaveChanges();
        }

        public virtual T Consultar(object id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> Listar()
        {
            return DbSet.AsQueryable();
        }
        public void Excluir(T entity)
        {
            DbSet.Remove(entity);
            Db.SaveChanges();
        }


    }
}
