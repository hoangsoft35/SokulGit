using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20151221210439)]
    public class m20151221210439_Alter_Table_Users : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Alter Users table

            Alter.Table("Users").AddColumn("LoginFailCount").AsInt32().WithDefaultValue(0);
            Alter.Table("Users").AddColumn("LastestLoginFailAt").AsDateTimeOffset().Nullable();
            Alter.Table("Users").AddColumn("LastestLoginAt ").AsDateTimeOffset().Nullable();

            #endregion

        }

        public override void Down()
        {
            Delete.Column("LoginFailCount").Column("LastestLoginFailAt").Column("LastestLoginAt").FromTable("Users");
        }
    }
}