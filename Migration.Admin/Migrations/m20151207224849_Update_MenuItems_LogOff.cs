using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151207224849)]
    public class m20151207224849_Update_MenuItems_LogOff : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Update MenuItems LogOff

            Execute.Sql("UPDATE MenuItems SET IsLink=1, ControllerName='Account', ActionName='LogOff' WHERE Id=(select top 1 MenuItemId from MenuItemTranslations Where Label = 'Log Out')");
            Execute.Sql("UPDATE MenuItems SET IsLink=1, ControllerName='Home', ActionName='Index' WHERE Id=(select top 1 MenuItemId from MenuItemTranslations Where Label = 'Home')");


            #endregion
        }

        public override void Down()
        {
            Execute.Sql("UPDATE MenuItems SET IsLink=0, ControllerName='NULL', ActionName='NULL' WHERE Id=(select top 1 MenuItemId from MenuItemTranslations Where Label = 'Log Out')");
            Execute.Sql("UPDATE MenuItems SET IsLink=0, ControllerName='NULL', ActionName='NULL' WHERE Id=(select top 1 MenuItemId from MenuItemTranslations Where Label = 'Home')");

        }
    }
}