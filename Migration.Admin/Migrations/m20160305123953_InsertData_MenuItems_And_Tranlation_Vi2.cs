using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20160305123953)]
    public class m20160305123953_InsertData_MenuItems_And_Tranlation_Vi2: FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Update MenuItems LogOff

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Menus'),N'Quản lý trình đơn',2,getDate(),(select id from Users where username ='hsproot'))");

            //Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
            //            "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Authorisations'),N'Quản lý quyền',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Languages'),N'Quản lý ngôn ngữ',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Users'),N'Người dùng',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Password Rule'),N'Luật mật khẩu',2,getDate(),(select id from Users where username ='hsproot'))");

       

            #endregion
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Trình đơn' and LanguageId =2");
            //Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Quản lý quyền' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Quản lý ngôn ngữ' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Người dùng' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Luật mật khẩu' and LanguageId =2");
        }
    }
}