using Core.Interfaces.Configuracao;
using Core.Interfaces.Repository;
using Core.Models;

namespace Repository
{
    public class FornecedorRepository: BaseRepository<Fornecedor>,IFornecedorRepository
    {
        private readonly IConexao contexto;

        public FornecedorRepository(IConexao contexto) :base(contexto)
        {
            this.contexto = contexto;
        }
    }
}
