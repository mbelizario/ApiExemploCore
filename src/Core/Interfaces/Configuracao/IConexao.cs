using System.Data;

namespace Core.Interfaces.Configuracao
{
    public interface IConexao
    {
        IDbConnection ObterConexao();
    }
}
