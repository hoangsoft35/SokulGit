using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20151219100657)]
    public class m20151219100657_InsertData_MenuItems_And_Tranlation_Vi : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Update MenuItems LogOff

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Home'),N'Trang chủ',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Administration'),N'Quản trị người dùng',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'System Admin'),N'Quản trị hệ thống',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
                        "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Sign Out'),N'Đăng xuất',2,getDate(),(select id from Users where username ='hsproot'))");

            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
            "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Configurations'),N'Quản trị cấu hình',2,getDate(),(select id from Users where username ='hsproot'))");


            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) " +
            "values ((select top 1 MenuItemId from MenuItemTranslations where Label = 'Dashboard'),N'Bảng thông báo',2,getDate(),(select id from Users where username ='hsproot'))");

            #endregion
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Trang chủ' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Quản trị người dùng' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Quản trị hệ thống' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Đăng xuất' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Quản trị cấu hình' and LanguageId =2");
            Execute.Sql("DELETE FROM MenuItemTranslations WHERE Label = N'Bảng thông báo' and LanguageId =2");
        }
    }
}