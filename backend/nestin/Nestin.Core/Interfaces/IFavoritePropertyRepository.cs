using Nestin.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Interfaces
{
    public interface IFavoritePropertyRepository
    {
        Task<List<FavoriteProperty>> GetAllByUserIdAsync(string userId, string propertyId);
        Task CreateAsync(string userId, string propertyId);
        Task DeleteAsync(string userId, string propertyId);
    }
}
