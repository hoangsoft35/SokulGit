using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151206211615)]
    public class m20151206211615_Insert_Data_Table_Areas_Tables : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Statuses
            // Companies
            Execute.Sql("INSERT INTO Companies(MobileNumber, PhoneNumber, StatusId,CreatedBy) " +
                        "VALUES('01889495849','07531234567', 0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                        "VALUES(1, 1, N'Sokul Vinh Thanh Branch',N'Vinh Thanh, Cho Lach, Ben Tre, VietNam', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                       "VALUES(1, 2, N'Sokul chi nhánh Vĩnh Thành',N'Vĩnh Thành, Chợ Lách, Bến Tre, Việt Nam', (select id from Users where username ='hsproot'))");


            Execute.Sql("INSERT INTO Companies(MobileNumber, PhoneNumber, StatusId,CreatedBy) " +
            "VALUES('01689027917','07531234567', 0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                      "VALUES(2, 1, N'Sokul Bavat Branch',N'Phuoc My Trung, Ben Tre, VietNam', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                       "VALUES(2, 2, N'Sokul chi nhánh ba vát',N'Phước Mỹ Trung, Bến Tre, Việt Nam', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Companies(MobileNumber, PhoneNumber, StatusId, CreatedBy) " +
            "VALUES('0932907534','07531234567', 0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                      "VALUES(3, 1, N'Sokul Cholach Branch',N'Cho Lach, Ben Tre, VietNam', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                       "VALUES(3, 2, N'Sokul Chi nhánh chợ lách',N'Chợ Lách, Bến Tre, Việt Nam', (select id from Users where username ='hsproot'))");

            Execute.Sql("INSERT INTO Companies(MobileNumber, PhoneNumber, StatusId,CreatedBy) " +
            "VALUES('01229952221','07531234567', 0,(select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                      "VALUES(4, 1, N'Sokul Bentre Branch',N'Ben Tre City, VietNam', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO CompanyTranslations(CompanyId, LanguageId, CompanyName,CompanyAddress, CreatedBy) " +
                       "VALUES(4, 2, N'Sokul chi nhánh tp bến tre',N'Thành Phố Bến Tre, Việt Nam', (select id from Users where username ='hsproot'))");


            // Areas
            Execute.Sql("INSERT INTO Areas(Id, StatusId,CreatedBy, CompanyId) VALUES(1,0,(select id from Users where username ='hsproot'),1)");
            Execute.Sql("INSERT INTO AreaTranslations(AreaId, LanguageId, AreaName, CreatedBy) VALUES(1, 2, N'Tiền Sảnh', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO Areas(Id, StatusId,CreatedBy, CompanyId) VALUES(2,0,(select id from Users where username ='hsproot'),1)");
            Execute.Sql("INSERT INTO AreaTranslations(AreaId, LanguageId, AreaName, CreatedBy) VALUES(2, 2, N'Phòng Lạnh', (select id from Users where username ='hsproot'))");


            //-- insert Table
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(1,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(2,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(3,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(4,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(5,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(6,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(7,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(8,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(9,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(10,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(11,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(12,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(13,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(14,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(15,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(16,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(17,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(18,1,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(19,1,0,(select id from Users where username ='hsproot'))");

            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(20,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(21,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(22,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(23,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(24,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(25,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(26,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(27,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(28,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(29,2,0,(select id from Users where username ='hsproot'))");
            Execute.Sql(" INSERT INTO TABLES(Id,AreaId,StatusId,CreatedBy) Values(30,2,0,(select id from Users where username ='hsproot'))");



            //Table translations
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(1, 2, N'Bàn 1', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(2, 2,N'Bàn 2', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(3, 2,N'Bàn 3', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(4, 2,N'Bàn 4', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(5, 2,N'Bàn 5', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(6, 2,N'Bàn 6', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(7, 2,N'Bàn 7', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(8, 2,N'Bàn 8', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(9, 2,N'Bàn 9', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(10, 2,N'Bàn 10', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(11, 2,N'Bàn 11', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(12, 2,N'Bàn 12', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(13, 2,N'Bàn 13', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(14, 2,N'Bàn 14', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(15, 2,N'Bàn 15', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(16, 2,N'Bàn 16', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(17, 2,N'Bàn 17', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(18, 2,N'Bàn 18', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(19, 2,N'Bàn 19', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(20, 2,N'Bàn 20', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(21, 2,N'Bàn 21', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(22, 2,N'Bàn 22', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(23, 2,N'Bàn 23', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(24, 2,N'Bàn 24', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(25, 2,N'Bàn 25', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(26, 2,N'Bàn 26', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(27, 2,N'Bàn 27', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(28, 2,N'Bàn 28', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(29, 2,N'Bàn 29', (select id from Users where username ='hsproot'))");
            Execute.Sql("INSERT INTO TableTranslations(TableId, LanguageId, TableName, CreatedBy) VALUES(30, 2,N'Bàn 30', (select id from Users where username ='hsproot'))");

            #endregion

        }

        public override void Down()
        {
            Execute.Sql(
            "DELETE FROM TableTranslations WHERE  TableId in (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30)");
            Execute.Sql("DELETE FROM TABLES WHERE Id  in (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30)");
            Execute.Sql("DELETE FROM AreaTranslations WHERE  AreaId in (1,2)");
            Execute.Sql("DELETE FROM Areas WHERE Id  in (1,2)");

            Execute.Sql("DELETE FROM CompanyTranslations WHERE  CompanyId in (1,2,3,4)");
            Execute.Sql("DELETE FROM Companies WHERE Id  in (1,2,3,4)");
        }
    }
}