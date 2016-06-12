using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20150715151032)]
    public class m20150715151032_AddUserTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Password rules

            Create.Table("PasswordRules")
                .InSchema("dbo")
                .WithColumn("Id")
                .AsGuid()
                .NotNullable()
                .PrimaryKey("PasswordRules_Id")
                .WithColumn("PasswordRuleName").AsString(250).NotNullable().Unique()
                .WithColumn("PasswordRuleDescription").AsString().Nullable()
                .WithColumn("PasswordMinLength").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("PasswordMaxLength").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("IsSpecialCharacterRequired").AsBoolean().NotNullable()
                .WithColumn("SpecialCharacterValue").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("IsUppercaseLetterRequired").AsBoolean().NotNullable()
                .WithColumn("UppercaseLetterValue").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("IsLowercaseLetterRequired").AsBoolean().NotNullable()
                .WithColumn("LowercaseLetterValue").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("IsAlphanumericRequired").AsBoolean().NotNullable()
                .WithColumn("AlphanumericValue").AsInt16().NotNullable().WithDefaultValue(0)
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable();

            var passwordRuleId = Guid.NewGuid();
            Insert.IntoTable("PasswordRules").InSchema("dbo").Row(new Dictionary<string, object>
            {
                {"Id", passwordRuleId},
                {"PasswordRuleName", "Default Profile"},
                {"PasswordRuleDescription", "This is default password rule"},
                {"PasswordMinLength", 8},
                {"PasswordMaxLength", 20},
                {"IsSpecialCharacterRequired", 1},
                {"SpecialCharacterValue", 2},
                {"IsUppercaseLetterRequired", 1},
                {"UppercaseLetterValue", 2},
                {"IsLowercaseLetterRequired", 1},
                {"LowercaseLetterValue", 2},
                {"IsAlphanumericRequired", 1},
                {"AlphanumericValue", 2},
                {"IsActive", 1},
            });

            #endregion

            #region Group user

            var groupUserId = Guid.NewGuid();
            Create.Table("GroupUsers").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_GroupUsers_Id")
                .WithColumn("GroupUserName").AsString(100).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable()
                .WithColumn("IsActive").AsBoolean().NotNullable();


            Execute.Sql("insert into GroupUsers" +
                        "(" +
                        "Id, " +
                        "GroupUserName," +
                        "IsActive" +
                        ")values" +
                        "('" + groupUserId + "',N'Group roles for root',1)");

            #endregion

            #region Users

            var userId = Guid.NewGuid();
            Create.Table("Users").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_Users_Id")
                .WithColumn("Email").AsString(256).NotNullable()
                .WithColumn("EmailConfirmed").AsBoolean().NotNullable()
                .WithColumn("PhoneNumber").AsAnsiString(30).Nullable()
                .WithColumn("PhoneNumberConfirmed").AsBoolean().NotNullable()
                .WithColumn("AccessFailedCount").AsInt16().NotNullable()
                .WithColumn("LockoutEndDateUtc").AsDateTimeOffset().Nullable()
                .WithColumn("IsLockout").AsBoolean().NotNullable()
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("IsLocked").AsBoolean().NotNullable()
                .WithColumn("LockedDate").AsDateTimeOffset().Nullable()
                .WithColumn("UserName").AsString(50).NotNullable().Unique()
                .WithColumn("SecurityStamp").AsString(int.MaxValue).Nullable()
                .WithColumn("PasswordHash").AsString(int.MaxValue).Nullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable()
                .WithColumn("PasswordRuleId")
                .AsGuid()
                .NotNullable()
                .ForeignKey("FK_Users_PasswordRuleId_PasswordRules_Id", "PasswordRules", "Id")
                .WithColumn("GroupUserId")
                .AsGuid()
                .NotNullable()
                .ForeignKey("FK_Users_GroupUserId_GroupUsers_Id", "GroupUsers", "Id");

            Insert.IntoTable("Users").InSchema("dbo").Row(new Dictionary<string, object>
            {
                {"Id", userId},
                {"Email", "hoangsoft35@gmail.com"},
                {"EmailConfirmed", 1},
                {"PhoneNumber", 0123456789},
                {"PhoneNumberConfirmed", 1},
                {"AccessFailedCount", 0},
                {"LockoutEndDateUtc", DateTime.Now},
                {"IsLockout", 1},
                {"IsActive", 1},
                {"IsLocked", 0},
                {"LockedDate", DateTime.Now},
                {"UserName", "hsproot"},
                {
                    "SecurityStamp",
                    "QK4htvU1v46djyfVYmEspqfz6pkyRd6yjsW+bv3b7Xcsq8V7OVJ715Wn6GpbTbzmqv9dZOP6UHGk7RkJ/xRnXw=="
                },
                {
                    "PasswordHash",
                    "1000:8H4ZP2o73ReLhuw3fXyCqj2XoJMvOUsMs3uLTVc/GxFIo51gl3KrZ68OcZPtNgVaP8+gk/oSE+hf4cayhnge8Q==:pf8/M7IABslB08I+8Iv99q36FPtFjQie6v1/QQGLCASAGWhdHVqC3AKvfYiVSt8XL7BXJCrIzQIwTpq9ipDzQQ=="
                }, // password is 123456ssAA11@@ 
                {"PasswordRuleId", passwordRuleId},
                {"GroupUserId", groupUserId}
            });

            #endregion

            #region Roles

            var roleId = Guid.NewGuid();
            Create.Table("Roles").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_Roles_Id")
                .WithColumn("RoleName").AsString(250).NotNullable()
                .WithColumn("RoleDescription").AsString(250).NotNullable()
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Execute.Sql("insert into Roles" +
                        "(" +
                        "Id, " +
                        "RoleName," +
                        "RoleDescription," +
                        "IsActive," +
                        "Created," +
                        "CreatedBy)" +
                        "values" +
                        "('" + roleId + "',N'Super user',N'This is super user',1 , getdate(), '" + userId + "')");

            #endregion

            #region Group User Roles

            Create.Table("GroupUserRoles").InSchema("dbo")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable()
                .WithColumn("RoleId")
                .AsGuid()
                .NotNullable()
                .ForeignKey("FK_GroupUserRoles_RoleId_Roles_Id", "Roles", "Id")
                .WithColumn("GroupUserId")
                .AsGuid()
                .NotNullable()
                .ForeignKey("FK_GroupUserRoles_GroupUserId_GroupUsers_Id", "GroupUsers", "Id");
            Create.PrimaryKey("PK_GroupUserRoles_RoleId_GroupUserId")
                .OnTable("GroupUserRoles")
                .WithSchema("dbo")
                .Columns("RoleId", "GroupUserId");

            Execute.Sql("insert into GroupUserRoles" +
                        "(" +
                        "RoleId, " +
                        "GroupUserId" +
                        ")values" +
                        "('" + roleId + "','" + groupUserId + "')");

            #endregion

            #region Languages

            Create.Table("Languages").InSchema("dbo")
                .WithColumn("Id").AsInt32().Identity().NotNullable().PrimaryKey("PK_Languages_Id")
                .WithColumn("CultureName").AsAnsiString(10).NotNullable()
                .WithColumn("CultureFullName").AsAnsiString(250).NotNullable()
                .WithColumn("DisplayName").AsString(100).NotNullable()
                .WithColumn("CultureCode").AsAnsiString(10).NotNullable()
                .WithColumn("Iso639XValue").AsAnsiString(3).Nullable()
                .WithColumn("FlagImage").AsByte().Nullable()
                .WithColumn("FlagLargeImage").AsByte().Nullable()
                .WithColumn("SymbolCurrency").AsAnsiString(5).Nullable()
                .WithColumn("IsDefault").AsBoolean().NotNullable()
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Execute.Sql("insert into Languages" +
                        "(" +
                        "CultureName, " +
                        "CultureFullName," +
                        "DisplayName," +
                        "CultureCode," +
                        "Iso639XValue," +
                        "SymbolCurrency, " +
                        "IsDefault," +
                        "IsActive," +
                        "Created," +
                        "CreatedBy)" +
                        "values" +
                        "('en-US','English - United States',N'English', '0x0409','ENU','$',1,1,getdate(),'" + userId +
                        "')");

            Execute.Sql("insert into Languages" +
                        "(" +
                        "CultureName, " +
                        "CultureFullName," +
                        "DisplayName," +
                        "CultureCode," +
                        "Iso639XValue," +
                        "SymbolCurrency, " +
                        "IsDefault," +
                        "IsActive," +
                        "Created," +
                        "CreatedBy)" +
                        "values" +
                        "('vi-VN','Vietnamese - Vietnam',N'Tiếng việt', '0x042A','VIT','Vnd',1,1,getdate(),'" + userId +
                        "')");

            #endregion

            #region Memu items

            Create.Table("MenuItemTypes").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_MenuItemTypes_Id")
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("MenuItemTypeTranslations").InSchema("dbo")
                .WithColumn("MenuItemTypeId").AsGuid().NotNullable()
                .WithColumn("MenuItemTypeName").AsString().Nullable()
                .WithColumn("LanguageId").AsInt32().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsDateTimeOffset()
                .WithColumn("UpdatedBy").AsGuid();
            Create.PrimaryKey("PK_MenuItemTypeTranslation_MenuItemTypeId_LanguageId")
                .OnTable("MenuItemTypeTranslations")
                .WithSchema("dbo").Columns("MenuItemTypeId", "LanguageId");
            Create.ForeignKey("FK_MenuItemTypeTranslation_MenuItemTypeId")
                .FromTable("MenuItemTypeTranslations")
                .InSchema("dbo")
                .ForeignColumn("MenuItemTypeId")
                .ToTable("MenuItemTypes").InSchema("dbo").PrimaryColumn("Id");
            Create.ForeignKey("FK_MenuItemTypeTranslation_LanguageId_Languages_Id")
                .FromTable("MenuItemTypeTranslations")
                .InSchema("dbo")
                .ForeignColumn("LanguageId")
                .ToTable("Languages")
                .InSchema("dbo")
                .PrimaryColumn("Id");

            var adminMenuItemTypeId = Guid.NewGuid();
            Execute.Sql("insert into MenuItemTypes(Id, IsActive, Created, CreatedBy) values('" + adminMenuItemTypeId +
                        "',1, getDate(),'" + userId + "')");
            Execute.Sql(
                "insert into MenuItemTypeTranslations(MenuItemTypeId, MenuItemTypeName, LanguageId, Created, CreatedBy, Updated, UpdatedBy) values('" +
                adminMenuItemTypeId + "',N'Admin site',1,getDate(),'" + userId + "', getDate(),'" + userId + "')");

            var clientMenuItemTypeId = Guid.NewGuid();
            Execute.Sql("insert into MenuItemTypes(Id, IsActive, Created, CreatedBy) values('" + clientMenuItemTypeId +
                        "',1, getDate(),'" + userId + "')");
            Execute.Sql(
                "insert into MenuItemTypeTranslations(MenuItemTypeId, MenuItemTypeName, LanguageId, Created, CreatedBy, Updated, UpdatedBy) values('" +
                clientMenuItemTypeId + "',N'Client site',1,getDate(),'" + userId + "', getDate(),'" + userId + "')");


            Create.Table("MenuItems").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_MenuItems_Id")
                .WithColumn("MenuItemTypeId").AsGuid().NotNullable()
                .WithColumn("IsRoot").AsBoolean().NotNullable()
                .WithColumn("IsActive").AsBoolean().NotNullable()
                .WithColumn("ParentId").AsGuid().Nullable()
                .WithColumn("IsTitle").AsBoolean().NotNullable()
                .WithColumn("IsLink").AsBoolean().NotNullable()
                .WithColumn("ControllerName").AsAnsiString(100).Nullable()
                .WithColumn("ActionName").AsAnsiString(100).Nullable()
                .WithColumn("SectionParameter").AsInt32().Nullable()
                .WithColumn("Order").AsInt32().Nullable()
                .WithColumn("CssClassIcon").AsString().Nullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable();
            Create.ForeignKey("FK_MenuItems_MenuItemTypeId_MenuItemTypes_Id")
                .FromTable("MenuItems")
                .InSchema("dbo")
                .ForeignColumn("MenuItemTypeId")
                .ToTable("MenuItemTypes").InSchema("dbo").PrimaryColumn("Id");


            Create.Table("MenuItemTranslations").InSchema("dbo")
                .WithColumn("MenuItemId").AsGuid().NotNullable()
                .WithColumn("Label").AsString(100).NotNullable()
                .WithColumn("LanguageId").AsInt32().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_MenuItemTranslations_MenuItemId_LanguageId")
                .OnTable("MenuItemTranslations")
                .WithSchema("dbo")
                .Columns("MenuItemId", "LanguageId");
            Create.ForeignKey("FK_MenuItemTranslations_MenuItemId_MenuItems_Id")
                .FromTable("MenuItemTranslations")
                .InSchema("dbo")
                .ForeignColumn("MenuItemId")
                .ToTable("MenuItems")
                .InSchema("dbo")
                .PrimaryColumn("Id");
            Create.ForeignKey("FK_MenuItemTranslation_LanguageId_Languages_Id")
                .FromTable("MenuItemTranslations")
                .InSchema("dbo")
                .ForeignColumn("LanguageId")
                .ToTable("Languages")
                .InSchema("dbo")
                .PrimaryColumn("Id");

            // insert top menu
            var homeMenuItemId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter, MenuItemTypeId, ParentId,[Order], CssClassIcon)" +
                "values('" + homeMenuItemId + "',1,1,0,0,'NULL','NULL',0,'" + adminMenuItemTypeId + "','" + homeMenuItemId + "', '" + -int.MaxValue + "','fa fa-home')"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        homeMenuItemId + "',N'Home',1,getDate(),'" + userId + "')");


            var dashboardMenuItemId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter, MenuItemTypeId, ParentId,[Order], CssClassIcon)" +
                "values('" + dashboardMenuItemId + "',1,1,0,0,'NULL','NULL',0,'" + adminMenuItemTypeId + "','" + homeMenuItemId + "',1,'fa fa-dashboard')"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        dashboardMenuItemId + "',N'Dashboard',1,getDate(),'" + userId + "')");




            var adminMenuItemId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter, MenuItemTypeId, ParentId,[Order], CssClassIcon)" +
                "values('" + adminMenuItemId + "',1,1,0,0,'NULL','NULL',0,'" + adminMenuItemTypeId + "','" + homeMenuItemId + "',2,'fa fa-users')"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        adminMenuItemId + "',N'Administration',1,getDate(),'" + userId + "')");


            var sysAdminMenuItemId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter, MenuItemTypeId, ParentId,[Order], CssClassIcon)" +
                "values('" + sysAdminMenuItemId + "',1,1,0,0,'NULL','NULL',0,'" + adminMenuItemTypeId + "','" + homeMenuItemId + "',3,'fa fa-gear')"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        sysAdminMenuItemId + "',N'System Admin',1,getDate(),'" + userId + "')");


            var logoutMenuItemId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter, MenuItemTypeId, ParentId,[Order], CssClassIcon)" +
                "values('" + logoutMenuItemId + "',1,1,0,0,'NULL','NULL',0,'" + adminMenuItemTypeId + "','" + homeMenuItemId + "','" + int.MaxValue + "','fa fa-lock')"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        logoutMenuItemId + "',N'Log Out',1,getDate(),'" + userId + "')");


            // insert child menu for administration 
            // title
            var languageTitleId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + languageTitleId + "',0,1,1,0,'NULL','NULL',1,'" + adminMenuItemId + "','" + adminMenuItemTypeId + "',3)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        languageTitleId + "',N'Languages',1,getDate(),'" + userId + "')");

            // link 
            var languageId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + languageId + "',0,1,0,1,'Language','Index',1,'" + languageTitleId + "','" + adminMenuItemTypeId + "',4)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        languageId + "',N'Language',1,getDate(),'" + userId + "')");


            // insert child menu for system admin 
            // title authorise
            var authorisationTitleId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + authorisationTitleId + "',0,1,1,0,'NULL','NULL',1,'" + sysAdminMenuItemId + "','" + adminMenuItemTypeId + "',5)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        authorisationTitleId + "',N'Authorisations',1,getDate(),'" + userId + "')");

            // link 
            var menuAuthorisationId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + menuAuthorisationId + "',0,1,0,1,'MenuItem','Index',1,'" + authorisationTitleId + "','" + adminMenuItemTypeId + "',6)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        menuAuthorisationId + "',N'Menus',1,getDate(),'" + userId + "')");


            // title
            var manageUserTitleId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + manageUserTitleId + "',0,1,1,0,'NULL','NULL',1,'" + sysAdminMenuItemId + "','" + adminMenuItemTypeId + "',7)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        manageUserTitleId + "',N'Users',1,getDate(),'" + userId + "')");


            // link 
            var passwordRuleLinkId = Guid.NewGuid();
            Execute.Sql(
                "insert into MenuItems(Id,IsRoot,IsActive,IsTitle,IsLink,ControllerName,ActionName,SectionParameter,ParentId, MenuItemTypeId, [Order])" +
                "values('" + passwordRuleLinkId + "',0,1,0,1,'User','PasswordRule',1,'" + manageUserTitleId + "','"+adminMenuItemTypeId+"',8)"
                );
            Execute.Sql("insert into MenuItemTranslations(MenuItemId, Label, LanguageId, Created, CreatedBy) values('" +
                        passwordRuleLinkId + "',N'Password Rule',1,getDate(),'" + userId + "')");


            Create.Table("MenuItemAuthorisations")
                .WithColumn("MenuItemId").AsGuid().NotNullable()
                .WithColumn("RoleId").AsGuid().NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_MenuItemAuthorisations_MenuItemId_RoleId").OnTable("MenuItemAuthorisations")
                .WithSchema("dbo")
                .Columns("MenuItemId", "RoleId");
            Create.ForeignKey("FK_MenuItemAuthorisations_MenuItemId_MenuItems_Id")
                .FromTable("MenuItemAuthorisations")
                .InSchema("dbo")
                .ForeignColumn("MenuItemId")
                .ToTable("MenuItems")
                .InSchema("dbo")
                .PrimaryColumn("Id");
            Create.ForeignKey("FK_MenuItemAuthorisations_RoleId_Roles_Id")
                .FromTable("MenuItemAuthorisations")
                .InSchema("dbo")
                .ForeignColumn("RoleId")
                .ToTable("Roles")
                .InSchema("dbo")
                .PrimaryColumn("Id");

            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + homeMenuItemId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + adminMenuItemId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + sysAdminMenuItemId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + logoutMenuItemId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + languageTitleId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + languageId + "','" + roleId +
                        "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + authorisationTitleId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + menuAuthorisationId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + manageUserTitleId + "','" +
                        roleId + "')");
            Execute.Sql("insert into MenuItemAuthorisations(MenuItemId, RoleId) values('" + passwordRuleLinkId + "','" +
                        roleId + "')");

            #endregion
        }

        public override void Down()
        {
            Delete.Table("GroupUserRoles").InSchema("dbo");
            Delete.Table("Users").InSchema("dbo");
            Delete.Table("PasswordRules").InSchema("dbo");
            Delete.Table("MenuItemAuthorisations").InSchema("dbo");
            Delete.Table("Roles").InSchema("dbo");
            Delete.Table("GroupUsers").InSchema("dbo");
            Delete.Table("MenuItemTranslations").InSchema("dbo");
            Delete.Table("MenuItems").InSchema("dbo");
            Delete.Table("MenuItemTypeTranslations").InSchema("dbo");
            Delete.Table("MenuItemTypes").InSchema("dbo");
            Delete.Table("Languages").InSchema("dbo");
        }
    }
}