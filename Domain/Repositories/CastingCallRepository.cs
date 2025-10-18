using CastingCallAPI.Data;
using CastingCallAPI.Domain.Interfaces;
using CastingCallAPI.Models;
using CastingCallAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CastingCallAPI.Domain.Repositories
{
    public class CastingCallRepository : ICastingCallRepository
    {
        private readonly CastingCallDbContext _context;
        public CastingCallRepository(CastingCallDbContext context)
        {
            _context = context;
        }

        public async Task<List<CastingCall>> GetCastingCallsAsync(Guid userId)
        {
            return await _context.CastingCallsTable.Where(x => x.UserId == userId)
                .ToListAsync();
        }

        public async Task AddCastingCallAsync(CastingCallDTO castingCall)
        {
            var newCastingCall = new CastingCall
            {
                UserId = castingCall.UserId,
                CompanyName = castingCall.CompanyName,
                CastingDirector = castingCall.CastingDirector,
                Title = castingCall.Title,
                Description = castingCall.Description,
                Ethnicity = castingCall.Ethnicity,
                Gender = castingCall.Gender,
                Age = castingCall.Age,
                CreatedAt = DateTime.Now,
                DueDate = castingCall.DueDate,
            };

            _context.CastingCallsTable.Add(newCastingCall);
            await _context.SaveChangesAsync();
        }
    }
}
