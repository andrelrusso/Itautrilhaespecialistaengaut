﻿using System.Collections.Generic;

namespace Modulo8DesSoftware.Repositorio.Interfaces
{
    public interface IBaseRepositorio<T> where T : class
    {
        T Adicionar(T obj);

        void Atualizar(T obj);

        void Excluir(T entity);

        T Consultar(object id);
        IEnumerable<T> Listar();
    }
}
