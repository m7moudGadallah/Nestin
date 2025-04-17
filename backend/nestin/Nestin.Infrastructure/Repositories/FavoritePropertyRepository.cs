using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Infrastructure.Repositories
{
     class FavoritePropertyRepository : BaseRepository,IFavoritePropertyRepository
    {
        public FavoritePropertyRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task CreateAsync(string userId, string propertyId)
        {
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == userId);
            var propertyExists = await _dbContext.Properties.AnyAsync(p => p.Id == propertyId);

            if (!userExists || !propertyExists)
                throw new ArgumentException("Invalid user ID or property ID.");

            var alreadyFavorited = await _dbContext.FavoriteProperties
                .AnyAsync(f => f.UserId == userId && f.PropertyId == propertyId);

            if (alreadyFavorited)
                throw new InvalidOperationException("This property is already favorited by the user.");

            var entity = new FavoriteProperty { UserId = userId, PropertyId = propertyId };
            _dbContext.FavoriteProperties.Add(entity);
            await _dbContext.SaveChangesAsync();
        }


        public async Task DeleteAsync(string UserId, string PropertyId)
        {
            var entity = await _dbContext.FavoriteProperties
                .FirstOrDefaultAsync(f => f.UserId == UserId && f.PropertyId == PropertyId);

            if (entity != null)
            {
                _dbContext.FavoriteProperties.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }


        public async Task<List<FavoriteProperty>> GetAllByUserIdAsync(string userId,string propertyId)
        {
            return await _dbContext.FavoriteProperties
                .Where(f => f.UserId == userId &&   f.PropertyId == propertyId)
                .ToListAsync();
        }
    }
}

