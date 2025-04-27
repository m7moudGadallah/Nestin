using Nestin.Core.Entities;

namespace Nestin.Core.Interfaces
{
    public interface IPaymentRepository : IGenericRepository<Payment, string>
    {
        public Task<Payment?> GetPaymentBySessionId(string sessionId);
    }
}
