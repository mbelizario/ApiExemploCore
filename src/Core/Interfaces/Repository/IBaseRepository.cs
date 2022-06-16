namespace Core.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task AtualizarAsync(T objeto);
        Task ExcluirAsync(Guid id);
        Task InserirAsync(T objeto);
        Task<IEnumerable<T>> ObterAsync();
        Task<T> ObterAsync(Guid id);
    }
}
