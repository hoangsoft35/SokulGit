using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151207174104)]
    public class m20151207174104_SocialUsers_SessionTokens_Devices_Notifications_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region SocialUsers

            Create.Table("SocialUsers").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_SocialUsers_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("SocialId").AsString(50).NotNullable().Indexed()
                .WithColumn("SocialAccessToken").AsString(500).NotNullable()
                .WithColumn("SocialType").AsString(10).NotNullable().Indexed()
                .WithColumn("UserId").AsGuid().NotNullable()                
                .WithColumn("Email").AsString(250).Nullable()
                .WithColumn("FirstName").AsAnsiString(50).Nullable()
                .WithColumn("LastName").AsAnsiString(50).Nullable();
            
            Create.ForeignKey("FK_SocialUsers_UserId")
                .FromTable("SocialUsers")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            #endregion

            #region SessionTokens

            Create.Table("SessionTokens").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_SessionTokens_Id")
               .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
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

            #region Notifications

            Create.Table("Notifications").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_Notifications_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("ReferenceId").AsGuid().NotNullable()
                .WithColumn("ReferenceTypeId").AsInt32().NotNullable()
                .WithColumn("Message").AsAnsiString(500).Nullable()
                .WithColumn("IsRead").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("UserId").AsGuid().NotNullable();

            Create.ForeignKey("FK_Notifications_UserId")
                .FromTable("Notifications")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            #endregion

            #region Devices

            Create.Table("Devices").InSchema("dbo")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey("PK_Devices_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("AppVersion").AsString(10).NotNullable()
                .WithColumn("DeviceType").AsString(10).NotNullable()
                .WithColumn("DeviceToken").AsString(250).Nullable()
                .WithColumn("DeviceId").AsString(250).Nullable()
                .WithColumn("IsAcceptPush").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("UserId").AsGuid().NotNullable();

            Create.ForeignKey("FK_Devices_UserId")
                .FromTable("Devices")
                .InSchema("dbo")
                .ForeignColumn("UserId")
                .ToTable("Users").InSchema("dbo").PrimaryColumn("Id");

            #endregion            

            #region Alter table

            Alter.Table("Users").AddColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow);
            Alter.Table("Users").AddColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow);
            Alter.Table("Users").AddColumn("CreatedBy").AsGuid().Nullable();
            Alter.Table("Users").AddColumn("UpdatedBy").AsGuid().Nullable();
            Alter.Table("Users").AddColumn("StatusId").AsInt32().NotNullable().WithDefaultValue(0);

            #endregion


        }

        public override void Down()
        {
            Delete.Table("SocialUsers").InSchema("dbo");
            Delete.Table("SessionTokens").InSchema("dbo");
            Delete.Table("Notifications").InSchema("dbo");
            Delete.Table("Devices").InSchema("dbo");                        

            Delete.Column("Created").FromTable("Users");
            Delete.Column("Updated").FromTable("Users");
            Delete.Column("CreatedBy").FromTable("Users");
            Delete.Column("UpdatedBy").FromTable("Users");
            Delete.Column("StatusId").FromTable("Users");
        }
    }
}