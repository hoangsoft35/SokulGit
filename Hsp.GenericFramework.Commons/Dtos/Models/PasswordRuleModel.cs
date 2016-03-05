using System;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class PasswordRuleModel
    {
        public Guid Id { get; set; }
        public string PasswordRuleName { get; set; }
        public string PasswordRuleDescription { get; set; }
        public int PasswordMinLength { get; set; }
        public int PasswordMaxLength { get; set; }
        public bool IsSpecialCharacterRequired { get; set; }
        public int SpecialCharacterValue { get; set; }
        public bool IsUppercaseLetterRequired { get; set; }
        public int UppercaseLetterValue { get; set; }
        public bool IsLowercaseLetterRequired { get; set; }
        public int LowercaseLetterValue { get; set; }
        public bool IsAlphanumericRequired { get; set; }
        public int AlphanumericValue { get; set; }
        public bool IsActive { get; set; }
    }
}
