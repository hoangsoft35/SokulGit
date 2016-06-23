using System;
using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20160217215737)]
    public class m20160217215737_Resources : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Resources

            Create.Table("Resources").InSchema("dbo")
                .WithColumn("Id").AsString(240).NotNullable().PrimaryKey("PK_Resources_Id")
                .WithColumn("ViewId").AsString(50).Indexed().NotNullable()
                .WithColumn("LanguageId").AsInt32().Indexed().NotNullable()
                .ForeignKey("FK_Resources_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("Updated").AsDateTimeOffset().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("StatusId").AsInt32().Indexed().NotNullable().WithDefaultValue(0)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("UpdatedBy").AsGuid().NotNullable()
                .WithColumn("Value").AsString(Char.MaxValue).NotNullable();

            #endregion

            #region Insert data for Resources

            Execute.Sql("INSERT INTO Resources(Id, ViewId, LanguageId, CreatedBy, UpdatedBy, Value) VALUES('label_1', 'home_index', 1, (select id from Users where username ='hsproot'), (select id from Users where username ='hsproot'), 'label 1')");
            Execute.Sql("INSERT INTO Resources(Id, ViewId, LanguageId, CreatedBy, UpdatedBy, Value) VALUES('label_2', 'account_login', 1, (select id from Users where username ='hsproot'), (select id from Users where username ='hsproot'), 'label 2')");

            #endregion
            }

        public override void Down()
        {
            Delete.Table("Resources").InSchema("dbo");
        }
    }
}