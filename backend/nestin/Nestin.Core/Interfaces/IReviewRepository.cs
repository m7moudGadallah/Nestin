using Nestin.Core.Dtos;
using Nestin.Core.Dtos.Reviews;
using Nestin.Core.Entities;
using Nestin.Core.Shared;

namespace Nestin.Core.Interfaces
{
    public interface IReviewRepository : IGenericRepository<Review, string>
    {
        public Task<PaginatedResult<ReviewDto>> GetPropertyReviews(string propertyId, GetAllQueryDto dto);
    }
}
