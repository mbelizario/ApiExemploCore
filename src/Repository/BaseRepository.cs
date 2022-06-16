using Core.Interfaces.Configuracao;
using Core.Interfaces.Repository;
using Dapper;

namespace Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IConexao contexto;

        public BaseRepository(IConexao contexto)
        {
            this.contexto = contexto;
        }
        public async Task InserirAsync(T objeto)
        {
            using var conexao = contexto.ObterConexao();
            var sql = string.Empty;
            await conexao.ExecuteAsync(sql);
        }
        
        public async Task AtualizarAsync(T objeto)
        {
            using var conexao = contexto.ObterConexao();
            var sql = string.Empty;
            await conexao.ExecuteAsync(sql);
        }

        public async Task ExcluirAsync(Guid id)
        {
            using var conexao = contexto.ObterConexao();
            var sql = string.Empty;
            await conexao.ExecuteAsync(sql);
        }

        public async Task<IEnumerable<T>> ObterAsync()
        {
            using var conexao = contexto.ObterConexao();
            var sql = string.Empty;
            var resultado = await conexao.QueryAsync<T>(sql);
            return resultado;
        }

        public async Task<T> ObterAsync(Guid id)
        {
            using var conexao = contexto.ObterConexao();
            var sql = string.Empty;
            var resultado = await conexao.QueryFirstOrDefaultAsync<T>(sql);
            return resultado;
        }
    }
}
