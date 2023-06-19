using RoboAPI.Domain.Dtos.Robo;

namespace RoboAPI.Domain.Interfaces.Services
{
    public interface IRoboService
    {
        Task<RoboDto> GetById(long id);
        Task<IEnumerable<RoboDto>> GetAll();
        Task<RoboDto> Update(RoboUpdateDto robo);
        Task<RoboDto> Reset(long id);
        Task<RoboDto> Post(RoboCreateDto robo);
        Task<bool> Delete(long id);
    }
}
