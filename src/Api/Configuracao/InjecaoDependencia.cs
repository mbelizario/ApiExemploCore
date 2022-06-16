using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Repository;
using Service;

namespace Api.Configuracao
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection servico)
        {
            //services
            servico.AddScoped<IFornecedorService, FornecedorService>();
            //repository
            servico.AddScoped<IFornecedorRepository, FornecedorRepository>();
            return servico;
        }
    }
}
