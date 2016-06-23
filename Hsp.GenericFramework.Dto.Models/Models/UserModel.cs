using System;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public short AccessFailedCount { get; set; }
        public DateTimeOffset? LockoutEndDateUtc { get; set; }
        public bool IsLockout { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public DateTimeOffset? LockedDate { get; set; }
        public string UserName { get; set; }
        public string SecurityStamp { get; set; }
        public string PasswordHash { get; set; }
        public int LoginFailCount { get; set; }
        public DateTimeOffset? LastestLoginFailAt { get; set; }
        public DateTimeOffset? LastestLoginAt { get; set; }
        public Guid PasswordRuleId { get; set; }
        public PasswordRuleModel PasswordRule { get; set; }
    }
}
