using Microsoft.EntityFrameworkCore;
using Nestin.Core.Entities;
using Nestin.Core.Interfaces;
using Nestin.Infrastructure.Data;

namespace Nestin.Infrastructure.Repositories
{
    class PaymentRepository : GenericRepository<Payment, string>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public async Task<Payment?> GetPaymentBySessionIdAsync(string sessionId)
        {
            return await _dbContext.Payments.Where(x => x.StripeSessionId == sessionId).FirstOrDefaultAsync();
        }
    }
}
