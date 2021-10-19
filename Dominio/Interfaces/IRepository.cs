using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Inserir(T entidade);

        Task<T> Atualizar(T entidade);

        Task<T> ObterPorConsulta(string filtro);

        Task<T> Excluir(string filtro);

        Task<List<T>> ObterTodos();
    }
}