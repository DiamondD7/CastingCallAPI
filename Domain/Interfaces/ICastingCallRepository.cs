using CastingCallAPI.Models;
using CastingCallAPI.Models.DTOs;

namespace CastingCallAPI.Domain.Interfaces
{
    public interface ICastingCallRepository
    {
        Task<List<CastingCall>> GetCastingCallsAsync(Guid userId);
        Task AddCastingCallAsync(CastingCallDTO castingCall);
    }
}
