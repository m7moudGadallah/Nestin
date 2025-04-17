using Nestin.Core.Dtos;
using Nestin.Core.Dtos.PropertyFees;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IPropertyFeeRepository : IGenericRepository<PropertyFee, int>
    {
        public Task<PaginatedResult<PropertyFeeDto>> GetByPropertyIdAsync(string propertyId, GetAllQueryDto dto);
    }
}
