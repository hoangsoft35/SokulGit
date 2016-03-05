using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151217215411)]
    public class m20151217215411_Loopkups : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Loopkups

            Create.Table("Loopkups").InSchema("dbo")
                .WithColumn("Id").AsString(50).NotNullable().PrimaryKey("PK_Loopkups_Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("StatusId").AsInt32().Indexed().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("Value").AsString(50).NotNullable()
                .WithColumn("Description").AsString(200).NotNullable();

            #endregion

            #region Insert data for loopkups

            Execute.Sql("INSERT INTO Loopkups(Id, Value, Description, CreatedBy, UpdatedBy) VALUES('LockLoginFailNumber', '5','Will lock account with 5 time login fail in 30 munites',(select id from Users where username ='hsproot'), (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO Loopkups(Id, Value, Description, CreatedBy, UpdatedBy) VALUES('LockLoginFailResetTime', '30' ,'After 30 munites, LockLoginFailNumber is reseted 0',(select id from Users where username ='hsproot'), (select id from Users where username ='hsproot'))");

            #endregion

        }

        public override void Down()
        {
            Delete.Table("Loopkups").InSchema("dbo");
        }
    }
}