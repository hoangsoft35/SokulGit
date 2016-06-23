using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20160305133116)]
    public class m20160305133116_InsertData_MenuItemTypes_And_Tranlation_Vi2 : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Insert VI data for MenuItemTypeTranslations

            Execute.Sql("insert into MenuItemTypeTranslations(MenuItemTypeId, MenuItemTypeName, LanguageId, Created, CreatedBy, Updated, UpdatedBy) " +
                        "values ((select top 1 MenuItemTypeId from MenuItemTypeTranslations where MenuItemTypeName = 'Client site'),N'Người dùng',2,getDate(),(select id from Users where username ='hsproot'), getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTypeTranslations(MenuItemTypeId, MenuItemTypeName, LanguageId, Created, CreatedBy, Updated, UpdatedBy) " +
                        "values ((select top 1 MenuItemTypeId from MenuItemTypeTranslations where MenuItemTypeName = 'Admin site'),N'Quản trị người dùng',2,getDate(),(select id from Users where username ='hsproot'), getDate(),(select id from Users where username ='hsproot'))");
                       

            #endregion
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM MenuItemTypeTranslations WHERE MenuItemTypeName=N'Người dùng' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTypeTranslations WHERE MenuItemTypeName=N'Quản trị người dùng' and LanguageId =2");            
        }
    }
}