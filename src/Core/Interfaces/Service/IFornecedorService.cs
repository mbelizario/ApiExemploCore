using Core.Models;

namespace Core.Interfaces.Service
{
    public interface IFornecedorService
    {
        Task<IEnumerable<Fornecedor>> ObterAsync();
    }
}
