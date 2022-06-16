using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Core.Models;

namespace Service
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }
        public Task<IEnumerable<Fornecedor>> ObterAsync() => fornecedorRepository.ObterAsync();
    }
}
