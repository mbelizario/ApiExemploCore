using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Conexao
{
    public class Conexao
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public Conexao(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }   
        public IDbConnection ObterConexao() => new SqlConnection(_connectionString);
        
    }
}
