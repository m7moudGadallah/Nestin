namespace Nestin.Core.Entities
{
    public enum HostUgradeRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public enum HostUpgradeRequestDocumentType
    {
        Passport,
        NationalId
    }

    public class HostUpgradeRequest : BaseEntity<string>
    {
        public string UserId { get; set; }
        public HostUgradeRequestStatus Status { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? RejectionReason { get; set; }
        public HostUpgradeRequestDocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string FrontPhotoId { get; set; }
        public string BackPhotoId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual AppUser User { get; set; }
        public virtual AppUser? Approver { get; set; }
        public virtual FileUpload FrontPhoto { get; set; }
        public virtual FileUpload BackPhoto { get; set; }
    }
}
