using FluentMigrator;

namespace Migration.Admin.Migrations
{
    [Migration(20151222175912)]
    public class m20151222175912_Insert_Basic_Data_Begin_From_ItemType : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Insert data ItemType
            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'01.Trà sữa', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'02.Trà sữa các loại hạt', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'03.Trà sữa các loại hương', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'04.Lục trà-Hồng trà', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'05.Sữa môn', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'06.Socolar', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'07.Kem tuyết', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'08.YA-Ice', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'09.A Cool', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'10.Siro', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'11.Cà phê', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'12.Sinh tố', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'13.Nước ép', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'14.Thêm các loại hương/hạt', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'15.Sữa bong bóng', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO ItemTypes(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO ItemTypeTranslations(ItemTypeId, LanguageId, ItemTypeName, CreatedBy) " +
                        "VALUES((select top 1 Id from ItemTypes order by Id desc), 2, N'16.Phụ thu', (select id from Users where username ='hsproot'))");

            #endregion

            #region Insert basic data Units table

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Ly', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Cái', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Bịt', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Kg', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Chai', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Thùng', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Bao', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Bình', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Units(StatusId,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO UnitTranslations(UnitId, LanguageId, UnitName, CreatedBy) " +
                        "VALUES((select top 1 Id from Units order by Id desc), 2, N'Lít', (select id from Users where username ='hsproot'))");

            #endregion

            #region Insert basic data table Items, ItemPrices


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,1)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa', (select id from Users where username ='hsproot'),N'ts')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,1)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa MV', (select id from Users where username ='hsproot'),N'tsmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa trân châu', (select id from Users where username ='hsproot'),N'tstc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa trân châu MV', (select id from Users where username ='hsproot'),N'tstcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt trái cây', (select id from Users where username ='hsproot'),N'tshtc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt trái cây MV', (select id from Users where username ='hsproot'),N'tshtcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt táo xanh', (select id from Users where username ='hsproot'),N'tshtx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt táo xanh MV', (select id from Users where username ='hsproot'),N'tshtxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt lục trà', (select id from Users where username ='hsproot'),N'tshlt')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt lục trà MV', (select id from Users where username ='hsproot'),N'tshltmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt cà phê', (select id from Users where username ='hsproot'),N'tshcp')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,2)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hạt cà phê MV', (select id from Users where username ='hsproot'),N'tshcpmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");






            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương bạc hà', (select id from Users where username ='hsproot'),N'tsbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương bạc hà MV', (select id from Users where username ='hsproot'),N'tsbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương cam', (select id from Users where username ='hsproot'),N'tsc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương cam MV', (select id from Users where username ='hsproot'),N'tscmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương chanh', (select id from Users where username ='hsproot'),N'tsc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương chanh MV', (select id from Users where username ='hsproot'),N'tscmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương chanh dây', (select id from Users where username ='hsproot'),N'tscd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương chanh dây MV', (select id from Users where username ='hsproot'),N'tscdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương đào', (select id from Users where username ='hsproot'),N'tsd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương đào MV', (select id from Users where username ='hsproot'),N'tsdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương dâu tây', (select id from Users where username ='hsproot'),N'tsd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương dâu tây MV', (select id from Users where username ='hsproot'),N'tsdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương nho', (select id from Users where username ='hsproot'),N'tsn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương nho MV', (select id from Users where username ='hsproot'),N'tsnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương táo xanh', (select id from Users where username ='hsproot'),N'tstx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương táo xanh MV', (select id from Users where username ='hsproot'),N'tstxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương kiwi', (select id from Users where username ='hsproot'),N'tskiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương kiwi MV', (select id from Users where username ='hsproot'),N'tskiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương vải', (select id from Users where username ='hsproot'),N'tsv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương vải MV', (select id from Users where username ='hsproot'),N'tsvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương xoài', (select id from Users where username ='hsproot'),N'tsx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương xoài MV', (select id from Users where username ='hsproot'),N'tsxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương mật ong', (select id from Users where username ='hsproot'),N'tsmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương mật ong MV', (select id from Users where username ='hsproot'),N'tsmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");






            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà', (select id from Users where username ='hsproot'),N'ht')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà MV', (select id from Users where username ='hsproot'),N'htmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà trân châu', (select id from Users where username ='hsproot'),N'httc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà trân châu MV', (select id from Users where username ='hsproot'),N'httcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà bạc hà', (select id from Users where username ='hsproot'),N'htbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà bạc hà MV', (select id from Users where username ='hsproot'),N'htbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà cam', (select id from Users where username ='hsproot'),N'htc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà cam MV', (select id from Users where username ='hsproot'),N'htcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà chanh', (select id from Users where username ='hsproot'),N'htc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà chanh MV', (select id from Users where username ='hsproot'),N'htcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà chanh dây', (select id from Users where username ='hsproot'),N'htcd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà chanh dây MV', (select id from Users where username ='hsproot'),N'htcdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà đào', (select id from Users where username ='hsproot'),N'htd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà đào MV', (select id from Users where username ='hsproot'),N'htdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà dâu tây', (select id from Users where username ='hsproot'),N'htd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà dâu tây MV', (select id from Users where username ='hsproot'),N'htdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà nho', (select id from Users where username ='hsproot'),N'htn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà nho MV', (select id from Users where username ='hsproot'),N'htnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà táo xanh', (select id from Users where username ='hsproot'),N'httx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà táo xanh MV', (select id from Users where username ='hsproot'),N'httxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà kiwi', (select id from Users where username ='hsproot'),N'htkiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà kiwi MV', (select id from Users where username ='hsproot'),N'htkiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà vải', (select id from Users where username ='hsproot'),N'htv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà vải MV', (select id from Users where username ='hsproot'),N'htvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà xoài', (select id from Users where username ='hsproot'),N'htx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà xoài MV', (select id from Users where username ='hsproot'),N'htxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà mật ong', (select id from Users where username ='hsproot'),N'htmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà - Lục trà mật ong MV', (select id from Users where username ='hsproot'),N'htmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");





            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,5)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa môn', (select id from Users where username ='hsproot'),N'sm')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,5)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa môn MV', (select id from Users where username ='hsproot'),N'smmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,6)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa socola', (select id from Users where username ='hsproot'),N'scl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,6)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa socola MV', (select id from Users where username ='hsproot'),N'sclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,6)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa socola bạc hà', (select id from Users where username ='hsproot'),N'sclbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,6)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa socola bạc hà MV', (select id from Users where username ='hsproot'),N'sclbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");








            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết bạc hà', (select id from Users where username ='hsproot'),N'ktbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết bạc hà MV', (select id from Users where username ='hsproot'),N'ktbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết cam', (select id from Users where username ='hsproot'),N'ktc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết cam MV', (select id from Users where username ='hsproot'),N'ktcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết chanh', (select id from Users where username ='hsproot'),N'ktc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết chanh MV', (select id from Users where username ='hsproot'),N'ktcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết chanh dây', (select id from Users where username ='hsproot'),N'ktcd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết chanh dây MV', (select id from Users where username ='hsproot'),N'ktcdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết đào', (select id from Users where username ='hsproot'),N'ktd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết đào MV', (select id from Users where username ='hsproot'),N'ktdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết dâu tây', (select id from Users where username ='hsproot'),N'ktd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết dâu tây MV', (select id from Users where username ='hsproot'),N'ktdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết nho', (select id from Users where username ='hsproot'),N'ktn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết nho MV', (select id from Users where username ='hsproot'),N'ktnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết táo xanh', (select id from Users where username ='hsproot'),N'kttx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết táo xanh MV', (select id from Users where username ='hsproot'),N'kttxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết kiwi', (select id from Users where username ='hsproot'),N'ktkiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết kiwi MV', (select id from Users where username ='hsproot'),N'ktkiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết vải', (select id from Users where username ='hsproot'),N'ktv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết vải MV', (select id from Users where username ='hsproot'),N'ktvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết xoài', (select id from Users where username ='hsproot'),N'ktx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết xoài MV', (select id from Users where username ='hsproot'),N'ktxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết mật ong', (select id from Users where username ='hsproot'),N'ktmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết mật ong MV', (select id from Users where username ='hsproot'),N'ktmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");







            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice bạc hà', (select id from Users where username ='hsproot'),N'yabh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice bạc hà MV', (select id from Users where username ='hsproot'),N'yabhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice cam', (select id from Users where username ='hsproot'),N'yac')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice cam MV', (select id from Users where username ='hsproot'),N'yacmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice chanh', (select id from Users where username ='hsproot'),N'yac')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice chanh MV', (select id from Users where username ='hsproot'),N'yacmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice chanh dây', (select id from Users where username ='hsproot'),N'yacd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice chanh dây MV', (select id from Users where username ='hsproot'),N'yacdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice đào', (select id from Users where username ='hsproot'),N'yad')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice đào MV', (select id from Users where username ='hsproot'),N'yadmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice dâu tây', (select id from Users where username ='hsproot'),N'yad')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice dâu tây MV', (select id from Users where username ='hsproot'),N'yadmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice nho', (select id from Users where username ='hsproot'),N'yan')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice nho MV', (select id from Users where username ='hsproot'),N'yanmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice táo xanh', (select id from Users where username ='hsproot'),N'yatx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice táo xanh MV', (select id from Users where username ='hsproot'),N'yatxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice kiwi', (select id from Users where username ='hsproot'),N'yakiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice kiwi MV', (select id from Users where username ='hsproot'),N'yakiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice vải', (select id from Users where username ='hsproot'),N'yav')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice vải MV', (select id from Users where username ='hsproot'),N'yavmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice xoài', (select id from Users where username ='hsproot'),N'yax')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice xoài MV', (select id from Users where username ='hsproot'),N'yaxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice mật ong', (select id from Users where username ='hsproot'),N'yamo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice mật ong MV', (select id from Users where username ='hsproot'),N'yamomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");








            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool bạc hà', (select id from Users where username ='hsproot'),N'acbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool bạc hà MV', (select id from Users where username ='hsproot'),N'acbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool cam', (select id from Users where username ='hsproot'),N'acc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool cam MV', (select id from Users where username ='hsproot'),N'accmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool chanh', (select id from Users where username ='hsproot'),N'acc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool chanh MV', (select id from Users where username ='hsproot'),N'accmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool chanh dây', (select id from Users where username ='hsproot'),N'accd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool chanh dây MV', (select id from Users where username ='hsproot'),N'accdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool đào', (select id from Users where username ='hsproot'),N'acd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool đào MV', (select id from Users where username ='hsproot'),N'acdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool dâu tây', (select id from Users where username ='hsproot'),N'acd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool dâu tây MV', (select id from Users where username ='hsproot'),N'acdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool nho', (select id from Users where username ='hsproot'),N'acn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool nho MV', (select id from Users where username ='hsproot'),N'acnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool táo xanh', (select id from Users where username ='hsproot'),N'actx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool táo xanh MV', (select id from Users where username ='hsproot'),N'actxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool kiwi', (select id from Users where username ='hsproot'),N'ackiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool kiwi MV', (select id from Users where username ='hsproot'),N'ackiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool vải', (select id from Users where username ='hsproot'),N'acv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool vải MV', (select id from Users where username ='hsproot'),N'acvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool xoài', (select id from Users where username ='hsproot'),N'acx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool xoài MV', (select id from Users where username ='hsproot'),N'acxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool mật ong', (select id from Users where username ='hsproot'),N'acmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool mật ong MV', (select id from Users where username ='hsproot'),N'acmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");






            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro bạc hà', (select id from Users where username ='hsproot'),N'srbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro bạc hà MV', (select id from Users where username ='hsproot'),N'srbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro cam', (select id from Users where username ='hsproot'),N'src')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro cam MV', (select id from Users where username ='hsproot'),N'srcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro chanh', (select id from Users where username ='hsproot'),N'src')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro chanh MV', (select id from Users where username ='hsproot'),N'srcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro chanh dây', (select id from Users where username ='hsproot'),N'srcd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro chanh dây MV', (select id from Users where username ='hsproot'),N'srcdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro đào', (select id from Users where username ='hsproot'),N'srd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro đào MV', (select id from Users where username ='hsproot'),N'srdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro dâu tây', (select id from Users where username ='hsproot'),N'srd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro dâu tây MV', (select id from Users where username ='hsproot'),N'srdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro nho', (select id from Users where username ='hsproot'),N'srn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro nho MV', (select id from Users where username ='hsproot'),N'srnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro táo xanh', (select id from Users where username ='hsproot'),N'srtx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro táo xanh MV', (select id from Users where username ='hsproot'),N'srtxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro kiwi', (select id from Users where username ='hsproot'),N'srkiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro kiwi MV', (select id from Users where username ='hsproot'),N'srkiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro vải', (select id from Users where username ='hsproot'),N'srv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro vải MV', (select id from Users where username ='hsproot'),N'srvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro xoài', (select id from Users where username ='hsproot'),N'srx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro xoài MV', (select id from Users where username ='hsproot'),N'srxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro mật ong', (select id from Users where username ='hsproot'),N'srmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,10)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Siro mật ong MV', (select id from Users where username ='hsproot'),N'srmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");







            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê đá', (select id from Users where username ='hsproot'),N'cpd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê đá MV', (select id from Users where username ='hsproot'),N'cpdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 10000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê sữa đá', (select id from Users where username ='hsproot'),N'cpsd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê sữa đá MV', (select id from Users where username ='hsproot'),N'cpsdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Lipton đá', (select id from Users where username ='hsproot'),N'ltd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Lipton đá MV', (select id from Users where username ='hsproot'),N'ltdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Lipton nóng', (select id from Users where username ='hsproot'),N'ltn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Lipton nóng MV', (select id from Users where username ='hsproot'),N'ltnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê sữa thạch trân châu', (select id from Users where username ='hsproot'),N'cpsttt')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,11)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Cà phê sữa thạch trân châu MV', (select id from Users where username ='hsproot'),N'cpstttmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");






            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố đu đủ', (select id from Users where username ='hsproot'),N'stdd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố đu đủ MV', (select id from Users where username ='hsproot'),N'stddmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố mãng cầu', (select id from Users where username ='hsproot'),N'stmc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố mãng cầu MV', (select id from Users where username ='hsproot'),N'stmcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố cà chua', (select id from Users where username ='hsproot'),N'stcc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố cà chua MV', (select id from Users where username ='hsproot'),N'stccmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố xoài', (select id from Users where username ='hsproot'),N'stx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố xoài MV', (select id from Users where username ='hsproot'),N'stxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố dừa', (select id from Users where username ='hsproot'),N'std')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố dừa MV', (select id from Users where username ='hsproot'),N'stdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố sapoche', (select id from Users where username ='hsproot'),N'stsp')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố sapoche MV', (select id from Users where username ='hsproot'),N'stspmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố bơ', (select id from Users where username ='hsproot'),N'stb')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố bơ MV', (select id from Users where username ='hsproot'),N'stbmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 14000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố dâu', (select id from Users where username ='hsproot'),N'std')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,12)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sinh tố dâu MV', (select id from Users where username ='hsproot'),N'stdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép dưa hấu', (select id from Users where username ='hsproot'),N'nedh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép dưa hấu MV', (select id from Users where username ='hsproot'),N'nedhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép cà rốt', (select id from Users where username ='hsproot'),N'necr')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép cà rốt MV', (select id from Users where username ='hsproot'),N'necrmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép thơm', (select id from Users where username ='hsproot'),N'net')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép thơm MV', (select id from Users where username ='hsproot'),N'netmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép bưởi', (select id from Users where username ='hsproot'),N'neb')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép bưởi MV', (select id from Users where username ='hsproot'),N'nebmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép táo', (select id from Users where username ='hsproot'),N'net')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép táo MV', (select id from Users where username ='hsproot'),N'netmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép cam', (select id from Users where username ='hsproot'),N'nec')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép cam MV', (select id from Users where username ='hsproot'),N'necmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép lê', (select id from Users where username ='hsproot'),N'nel')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép lê MV', (select id from Users where username ='hsproot'),N'nelmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép ổi', (select id from Users where username ='hsproot'),N'neo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép ổi MV', (select id from Users where username ='hsproot'),N'neomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép dâu', (select id from Users where username ='hsproot'),N'ned')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,13)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Nước ép dâu MV', (select id from Users where username ='hsproot'),N'nedmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 16000)");





            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hạt trân châu', (select id from Users where username ='hsproot'),N'htc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hạt trái cây', (select id from Users where username ='hsproot'),N'htc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hạt táo xanh', (select id from Users where username ='hsproot'),N'htx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hạt lục trà', (select id from Users where username ='hsproot'),N'hlt')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hạt cà phê', (select id from Users where username ='hsproot'),N'hcp')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,14)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Thêm hương các loại', (select id from Users where username ='hsproot'),N'th')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 2000)");





            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng bạc hà', (select id from Users where username ='hsproot'),N'sbbbh')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng bạc hà MV', (select id from Users where username ='hsproot'),N'sbbbhmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng cam', (select id from Users where username ='hsproot'),N'sbbc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng cam MV', (select id from Users where username ='hsproot'),N'sbbcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng chanh', (select id from Users where username ='hsproot'),N'sbbc')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng chanh MV', (select id from Users where username ='hsproot'),N'sbbcmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng chanh dây', (select id from Users where username ='hsproot'),N'sbbcd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng chanh dây MV', (select id from Users where username ='hsproot'),N'sbbcdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng đào', (select id from Users where username ='hsproot'),N'sbbd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng đào MV', (select id from Users where username ='hsproot'),N'sbbdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng dâu tây', (select id from Users where username ='hsproot'),N'sbbd')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng dâu tây MV', (select id from Users where username ='hsproot'),N'sbbdmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng nho', (select id from Users where username ='hsproot'),N'sbbn')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng nho MV', (select id from Users where username ='hsproot'),N'sbbnmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng táo xanh', (select id from Users where username ='hsproot'),N'sbbtx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng táo xanh MV', (select id from Users where username ='hsproot'),N'sbbtxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng kiwi', (select id from Users where username ='hsproot'),N'sbbkiwi')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng kiwi MV', (select id from Users where username ='hsproot'),N'sbbkiwimv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");




            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng vải', (select id from Users where username ='hsproot'),N'sbbv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng vải MV', (select id from Users where username ='hsproot'),N'sbbvmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng xoài', (select id from Users where username ='hsproot'),N'sbbx')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng xoài MV', (select id from Users where username ='hsproot'),N'sbbxmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng mật ong', (select id from Users where username ='hsproot'),N'sbbmo')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng mật ong MV', (select id from Users where username ='hsproot'),N'sbbmomv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");






            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương socolar', (select id from Users where username ='hsproot'),N'tsscl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,3)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Trà sữa hương socolar MV', (select id from Users where username ='hsproot'),N'tssclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà-Lục trà socola', (select id from Users where username ='hsproot'),N'htscl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,4)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Hồng trà-Lục trà socola MV', (select id from Users where username ='hsproot'),N'htsclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết socola', (select id from Users where username ='hsproot'),N'ktscl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,7)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Kem tuyết socola MV', (select id from Users where username ='hsproot'),N'ktsclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice mật socola', (select id from Users where username ='hsproot'),N'yascl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,8)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'YA - Ice mật socola MV', (select id from Users where username ='hsproot'),N'yasclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool socola', (select id from Users where username ='hsproot'),N'acscl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,9)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'A Cool socola MV', (select id from Users where username ='hsproot'),N'acsclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng socola', (select id from Users where username ='hsproot'),N'sbbscl')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");

            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,15)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Sữa Bong Bóng socola MV', (select id from Users where username ='hsproot'),N'sbbsclmv')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,2,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 12000)");



            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,16)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Ly trà sữa(Theo thời giá)', (select id from Users where username ='hsproot'),N'ptlts')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 40000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 40000)");


            Execute.Sql("INSERT INTO Items(StatusId,CreatedBy, UnitId, ItemTypeId) VALUES(0,(select id from Users where username ='hsproot'),1,16)");
            Execute.Sql("INSERT INTO ItemTranslations(ItemId, LanguageId, ItemName, CreatedBy,Shortcut) " +
                                    "VALUES((select top 1 Id from Items order by Id desc), 2, N'Các loại ly khác(Theo thời giá)', (select id from Users where username ='hsproot'),N'ptlts')");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 40000)");
            Execute.Sql("INSERT INTO ItemPrices (StatusId, CompanyId, ItemId, CreatedBy,EffectiveFromDate, Value)" +
                                    "VALUES(0,1,(select top 1 Id from Items order by Id desc), (select id from Users where username ='hsproot'),getdate(), 35000)");

            

            #endregion
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM ExportDetails");
            Execute.Sql("DELETE FROM Exports");
            Execute.Sql("DELETE FROM ItemPrices WHERE ItemId in (select top 254 Id from items)");
            Execute.Sql("DELETE FROM ItemTranslations WHERE ItemId in (select top 254 Id from items)");
            Execute.Sql("DELETE FROM Items WHERE Id in (select top 254 Id from items)");

            Execute.Sql("DELETE FROM ItemTypeTranslations WHERE ItemTypeId in (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16)");
            Execute.Sql("DELETE FROM ItemTypes WHERE Id in (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16)");

            Execute.Sql("DELETE FROM UnitTranslations WHERE UnitId in (Select top 9 Id from Units)");
            Execute.Sql("DELETE FROM Units WHERE Id in (Select top 9 Id from Units)");


        }
    }
}