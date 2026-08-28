using ClienteManager.Domain.Entities;

namespace ClienteManager.Application.Interfaces;

public interface IClienteRepository
{
    Task<List<Cliente>> ObterTodosAsync();

    Task<Cliente?> ObterPorIdAsync(int id);

    Task AdicionarAsync(Cliente cliente);

    Task AtualizarAsync(Cliente cliente);

    Task ExcluirAsync(Cliente cliente);
}