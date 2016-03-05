﻿using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class LanguageModel : BaseEntityModel
    {
        public int Id { get; set; }
        public string CultureName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayFullName { get; set; }
        public string CultureCode { get; set; }
        public string Iso639XValue { get; set; }
        public byte[] FlagImage { get; set; }
        public byte[] FlagLargeImage { get; set; }
        public string SymbolCurrency { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}