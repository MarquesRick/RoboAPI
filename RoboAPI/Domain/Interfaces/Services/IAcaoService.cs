using RoboAPI.Domain.Dtos.Acao;

namespace RoboAPI.Domain.Interfaces.Services
{
    public interface IAcaoService
    {
        Task<IEnumerable<AcaoDto>> GetAllByType(long type);
        Task<IEnumerable<AcoesDto>> GetAll();
    }
}
