using Hsp.GenericFramework.Commons.Dtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Commons
{
    public static class Consts
    {        
        public static class LangCultures
        {
            public const int DefaultLanguage = 1;
            public const int DefaultWinformAppLanguage = 2;
            public const int en_US = 1;
            public const int vi_VN = 2;
        }

        public static class TableStatus
        {
            public const int HaveGuest = 1;
            public const int NotHaveGuest= 2;
            public const int Selected = 3;
        }

        public static class Loopkups
        {
            public static void Load(List<LoopkupModel> loopkups)
            {
                var lockLoginFailNumber = loopkups.First(r => r.Id == "LockLoginFailNumber");
                LockLoginFailNumber = lockLoginFailNumber != null ? int.Parse(lockLoginFailNumber.Value) : 5;

                var lockLoginFailResetTime = loopkups.First(r => r.Id == "LockLoginFailResetTime");
                LockLoginFailResetTime = lockLoginFailResetTime != null ? int.Parse(lockLoginFailResetTime.Value) : 30;
            }

            /// <summary>
            /// Will lock account with 5 time login fail in 30 munites
            /// </summary>
            public static int LockLoginFailNumber { get; set; }

            /// <summary>
            /// After 30 munites, LockLoginFailNumber is reseted 0
            /// </summary>
            public static int LockLoginFailResetTime { get; set; }
        }
        public static class ErrorStatus
        {
            public const int Success = 0;
            public const int Error = 1;            
        }
        public enum Status
        {
            Created = 0,
            Deleted = 1,
            Updated = 2,
            CardNewNotUse = 20,
            CardLosting = 21,
            CardUsing = 22,
            CardBroken = 23,
 


        }
        public const string MemberTypeStandard = "std";
        public const string MemberTypeSliver = "sli";
        public const string MemberTypeGold = "gol";
    }
}
