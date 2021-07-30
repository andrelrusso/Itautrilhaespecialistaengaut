
using System.Collections.Generic;

namespace ModeloDesSoftware.Repositorio.Repositorio
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
