using Nestin.Core.Dtos.HostUpgradeRequests;
using Nestin.Core.Entities;

namespace Nestin.Core.Mappings
{
    public static class HostUpgradeRequestMappingExtenstions
    {
        public static HostUpgradeRequestDto ToDto(this HostUpgradeRequest entity)
        {
            return new HostUpgradeRequestDto
            {
                UserId = entity.UserId,
                Status = entity.Status.ToString(),
                ApprovedBy = entity.ApprovedBy,
                ApprovalDate = entity.ApprovalDate,
                RejectionReason = entity.RejectionReason,
                DocumentType = entity.DocumentType.ToString(),
                DocumentNumber = entity.DocumentNumber,
                FrontPhoto = entity.FrontPhoto?.ToDto(),
                BackPhoto = entity.BackPhoto?.ToDto(),
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
