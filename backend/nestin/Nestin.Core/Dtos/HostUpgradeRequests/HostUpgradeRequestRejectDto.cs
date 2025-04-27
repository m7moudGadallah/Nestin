using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.HostUpgradeRequests
{
    public class HostUpgradeRequestRejectDto
    {
        [Required]
        public string RejectionReason { get; set; }
    }
}
