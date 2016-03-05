using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151206182730)]
    public class m20151206182730_Insert_Data_Table_MemberTypes : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Statuses

            Execute.Sql("INSERT INTO MemberTypes(KulCoinToUpgrade,DiscountForThisType,StatusId,CreatedBy) VALUES(1000,0,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO MemberTypeTranslations(MemberTypeId, LanguageId, MemberTypeName, MemberTypeDescription, CreatedBy) VALUES((select top 1 Id from MemberTypes order by Id desc), 2, N'VIP 1',N'Thành viên Vip 1', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO MemberTypes(KulCoinToUpgrade,DiscountForThisType,StatusId,CreatedBy) VALUES(1500,5,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO MemberTypeTranslations(MemberTypeId, LanguageId, MemberTypeName, MemberTypeDescription, CreatedBy) VALUES((select top 1 Id from MemberTypes order by Id desc), 2, N'VIP 2',N'Thành viên Vip 2', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO MemberTypes(KulCoinToUpgrade,DiscountForThisType,StatusId,CreatedBy) VALUES(2000,10,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO MemberTypeTranslations(MemberTypeId, LanguageId, MemberTypeName, MemberTypeDescription, CreatedBy) VALUES((select top 1 Id from MemberTypes order by Id desc), 2, N'VIP 3',N'Thành viên Vip 3', (select id from Users where username ='hsproot'))");

            #endregion

        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM MemberTypeTranslations WHERE  MemberTypeName in ('VIP 1','VIP 2','VIP 3')");
            Execute.Sql("DELETE FROM MemberTypes WHERE KulCoinToUpgrade  in (1000,1500,2000)");
        }
    }
}