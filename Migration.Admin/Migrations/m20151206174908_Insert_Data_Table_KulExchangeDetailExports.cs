using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20151206174908)]
    public class m20151206174908_Insert_Data_Table_KulExchangeDetailExports : FluentMigrator.Migration
    {
        public override void Up()
        {
            //-- 0-100.000vnd
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(0,9000,0,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(10000,19000,5,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(20000,29000,10,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(30000,39000,15,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(40000,49000,20,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(50000,59000,25,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(60000,69000,30,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(70000,79000,35,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(80000,89000,40,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(90000,99000,45,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(100000,109000,50,0,(select id from Users where username ='hsproot'))");

            //-- 100.000-200.000vnd
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(110000,119000,55,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(120000,129000,60,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(130000,139000,65,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(140000,149000,70,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(150000,159000,75,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(160000,169000,80,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(170000,179000,85,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(180000,189000,90,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(190000,199000,95,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(200000,209000,100,0,(select id from Users where username ='hsproot'))");
            //-- 200.000-300.000vnd
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(210000,219000,105,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(220000,229000,110,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(230000,239000,115,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(240000,249000,120,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(250000,259000,125,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(260000,269000,130,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(270000,279000,135,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(280000,289000,140,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(290000,299000,145,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(300000,309000,150,0,(select id from Users where username ='hsproot'))");
            //-- 300.000-400.000vnd
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(310000,319000,155,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(320000,329000,160,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(330000,339000,165,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(340000,349000,170,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(350000,359000,175,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(360000,369000,180,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(370000,379000,185,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(380000,389000,190,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(390000,399000,195,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(400000,409000,200,0,(select id from Users where username ='hsproot'))");
            //-- 400.000-500.000vnd
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(410000,419000,205,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(420000,429000,210,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(430000,439000,215,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(440000,449000,220,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(450000,459000,225,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(460000,469000,230,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(470000,479000,235,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(480000,489000,240,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(490000,499000,245,0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO KulExchangeDetailExports(TotalBillFrom,TotalBillTo,KulBonusValue,StatusId,CreatedBy) VALUES(500000,509000,250,0,(select id from Users where username ='hsproot'))");

        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM KulExchangeDetailExports WHERE KulBonusValue in (0,5,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,100," +
                        "105,110,115,120,125,130,135,140,145,150,155,160,165,170,175,180,185,190,195,200," +
                        "205,210,215,220,225,230,235,240,245,250)");
        }
    }
}