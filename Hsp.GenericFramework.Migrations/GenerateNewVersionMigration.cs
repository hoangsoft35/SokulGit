 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations.Migrations
{

	// === Tables ===
	// == create table ==
	// Create.Table("TestTable")
    //            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
    //            .WithColumn("Name").AsString(255).NotNullable().WithDefaultValue("Anonymous");
	// == delete table ==
	// Delete.Table("TestTable");
	// ======
    
	// === Columns ===
	// == add column ==
	// Alter.Table("TestTable").AddColumn("custom_int_column").AsInt32().Nullable();
	// == delete column ==
	// Delete.Column("custom_int_column").FromTable("TestTable");
	// == rename column ==
	// Rename.Column("str_column_3").OnTable("TestTable").To("string_column");
	// ======

	// === Stored procedures ===
	// up
	// Execute.Sql("DROP PROCEDURE [RO].[Addon_Costed_ByAirport]");
    // Execute.EmbeddedScript(@"RO_Addon_Costed_ByAirport.sql");
	// down
	// Execute.Sql("DROP PROCEDURE [RO].[Addon_Costed_ByAirport]");
	// Execute.EmbeddedScript(@"201410301401_RO_Addon_Costed_ByAirport.sql");
	// ======


	[Migration(20150703153328)]
	public class m20150703153328_TestMigration : Migration {
	    public override void Up()
        {
           
        }

        public override void Down()
        {
           
        }
	}
}
