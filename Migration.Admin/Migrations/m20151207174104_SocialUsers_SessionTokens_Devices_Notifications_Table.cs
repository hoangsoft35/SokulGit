using System;
using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20151207174104)]
    public class m20151207174104_SocialUsers_SessionTokens_Devices_Notifications_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region SocialTypes

            Create.Table("SocialTypes").InSchema("dbo")
                .WithColumn("Id").AsInt16().NotNullable().PrimaryKey("PK_SocialTypes_Id")
                .WithColumn("Name").AsString(50).NotNullable().Indexed()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable();
            #endregion


            #region SocialUsers

            Create.Table("SocialUsers").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_SocialUsers_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("SocialId").AsString(50).NotNullable().Indexed()
                .WithColumn("SocialAccessToken").AsString(500).NotNullable()
                .WithColumn("SocialTypeId").AsInt16().NotNullable()
                .WithColumn("UserId").AsGuid().NotNullable()                
                .WithColumn("Email").AsString(250).Nullable()
                .WithColumn("FirstName").AsAnsiString(50).Nullable()
                .WithColumn("LastName").AsAnsiString(50).Nullable();
            
            Create.ForeignKey("FK_SocialUsers_UserId")
                .FromTable("SocialUsers")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            Create.ForeignKey("FK_SocialTypes_SocialTypeId")
               .FromTable("SocialUsers")
               .InSchema("dbo")
               .ForeignColumn("SocialTypeId")
               .ToTable("SocialTypes").InSchema("dbo").PrimaryColumn("Id");

            #endregion

            #region SessionTokens

            Create.Table("SessionTokens").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_SessionTokens_Id")
               .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("Expired").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow.AddHours(24))
                .WithColumn("UserId").AsGuid().NotNullable();

            Create.ForeignKey("FK_SessionTokens_UserId")
                .FromTable("SessionTokens")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            #endregion

            #region NotificationTypes

            Create.Table("NotificationTypes").InSchema("dbo")
                .WithColumn("Id").AsInt16().NotNullable().PrimaryKey("PK_NotificationTypes_Id")
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable();

            Create.Table("NotificationTypeTranslations").InSchema("dbo")
               .WithColumn("NotificationTypeId").AsInt16().NotNullable()
               .WithColumn("Name").AsString().Nullable()
               .WithColumn("LanguageId").AsInt32().NotNullable()
               .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
               .WithColumn("CreatedBy").AsGuid().NotNullable()
               .WithColumn("Updated").AsDateTimeOffset()
               .WithColumn("UpdatedBy").AsGuid();

            Create.PrimaryKey("PK_NotificationTypeTranslations_NotificationTypeId_LanguageId")
               .OnTable("NotificationTypeTranslations")
               .WithSchema("dbo").Columns("NotificationTypeId", "LanguageId");
            Create.ForeignKey("FK_NotificationTypeTranslations_NotificationTypeId")
                .FromTable("NotificationTypeTranslations")
                .InSchema("dbo")
                .ForeignColumn("NotificationTypeId")
                .ToTable("NotificationTypes").InSchema("dbo").PrimaryColumn("Id");
            Create.ForeignKey("FK_NotificationTypeTranslations_LanguageId_Languages_Id")
                .FromTable("NotificationTypeTranslations")
                .InSchema("dbo")
                .ForeignColumn("LanguageId")
                .ToTable("Languages")
                .InSchema("dbo")
                .PrimaryColumn("Id");

            #endregion



            #region Notifications

            Create.Table("Notifications").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_Notifications_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("Message").AsAnsiString(500).Nullable()
                .WithColumn("IsRead").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("UserId").AsGuid().NotNullable()
                .WithColumn("NotificationTypeId").AsInt16().NotNullable().ForeignKey("NotificationTypes", "Id");

            Create.Table("NotificationTranslations").InSchema("dbo")
               .WithColumn("NotificationId").AsInt32().NotNullable()
               .WithColumn("Message").AsAnsiString(500).Nullable()
               .WithColumn("LanguageId").AsInt32().NotNullable()
               .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.Now)
               .WithColumn("CreatedBy").AsGuid().NotNullable()
               .WithColumn("Updated").AsDateTimeOffset()
               .WithColumn("UpdatedBy").AsGuid();

            Create.PrimaryKey("PK_NotificationTranslations_NotificationId_LanguageId")
               .OnTable("NotificationTranslations")
               .WithSchema("dbo").Columns("NotificationId", "LanguageId");
            Create.ForeignKey("FK_NotificationTranslations_NotificationId")
                .FromTable("NotificationTranslations")
                .InSchema("dbo")
                .ForeignColumn("NotificationId")
                .ToTable("Notifications").InSchema("dbo").PrimaryColumn("Id");
            Create.ForeignKey("FK_NotificationTranslations_LanguageId_Languages_Id")
                .FromTable("NotificationTranslations")
                .InSchema("dbo")
                .ForeignColumn("LanguageId")
                .ToTable("Languages")
                .InSchema("dbo")
                .PrimaryColumn("Id");

            #endregion

            #region Notification Users

            Create.Table("NotificationUsers").InSchema("dbo")
                .WithColumn("Id").AsInt64().NotNullable().PrimaryKey("PK_NotificationUsers_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("IsRead").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("UserId").AsGuid().NotNullable()
                .WithColumn("NotificationId").AsInt32().NotNullable();

            Create.ForeignKey("FK_NotificationUsers_UserId")
                .FromTable("Notifications")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            Create.ForeignKey("FK_NotificationUsers_NotificationId")
               .FromTable("NotificationUsers")
               .InSchema("dbo")
               .ForeignColumn("NotificationId")
               .ToTable("Notifications").InSchema("dbo").PrimaryColumn("Id");

            #endregion

            #region DeviceTypes

            Create.Table("DeviceTypes").InSchema("dbo")
                .WithColumn("Id").AsInt16().NotNullable().PrimaryKey("PK_DeviceTypes_Id")
                .WithColumn("DeviceTypeName").AsString(50).NotNullable().Indexed()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable();
            #endregion


            #region Devices

            Create.Table("Devices").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_Devices_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("AppVersion").AsString(10).NotNullable()
                .WithColumn("DeviceTypeId").AsInt16().NotNullable()
                .WithColumn("DeviceToken").AsString(250).Nullable()
                .WithColumn("DeviceId").AsString(250).Nullable()
                .WithColumn("IsAcceptPush").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("UserId").AsGuid().NotNullable();

            Create.ForeignKey("FK_Devices_UserId")
                .FromTable("Devices")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            Create.ForeignKey("FK_DeviceTypes_UserId")
              .FromTable("Devices")
              .InSchema("dbo")
              .ForeignColumn("DeviceTypeId")
              .ToTable("DeviceTypes").InSchema("dbo").PrimaryColumn("Id");

            #endregion            

            #region Alter table

            Alter.Table("Users").AddColumn("CreatedBy").AsGuid().Nullable();
            Alter.Table("Users").AddColumn("UpdatedBy").AsGuid().Nullable();
            Alter.Table("Users").AddColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0);

            #endregion


        }

        public override void Down()
        {

            Delete.Table("SocialUsers").InSchema("dbo");
            Delete.Table("SocialTypes").InSchema("dbo");
            Delete.Table("SessionTokens").InSchema("dbo");
            Delete.Table("NotificationUsers").InSchema("dbo");
            Delete.Table("NotificationTranslations").InSchema("dbo");
            Delete.Table("Notifications").InSchema("dbo");
            Delete.Table("NotificationTypeTranslations").InSchema("dbo");
            Delete.Table("NotificationTypes").InSchema("dbo");
            Delete.Table("Devices").InSchema("dbo");                        
            Delete.Table("DeviceTypes").InSchema("dbo");                        
                              
                                  

            Delete.Column("CreatedBy").FromTable("Users");
            Delete.Column("UpdatedBy").FromTable("Users");
            Delete.Column("StatusId").FromTable("Users");
        }
    }
}