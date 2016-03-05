using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151206152452)]
    public class m20151206152452_Insert_Data_Table_Statuses : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Statuses
            // 1-20 NORMAL STATUS
            // 20-40 MEMBERCARD STATUS
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(0,(select id from Users where username ='hsproot'))");// CREATED
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(1,(select id from Users where username ='hsproot'))");// DELETED
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(2,(select id from Users where username ='hsproot'))");// UPDATED
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(20,(select id from Users where username ='hsproot'))");// CARD IS NEW AND NOT USE
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(21,(select id from Users where username ='hsproot'))");// CARD IS LOSTING
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(22,(select id from Users where username ='hsproot'))");// CARD IS USING
            Execute.Sql("INSERT INTO STATUSES(Id,CreatedBy) VALUES(23,(select id from Users where username ='hsproot'))");// CARD IS BROKEN

            // INSERT TRANSLATION TABLE
            // LANGUAGE ID 1: EN-US.    2. VI-VN

            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(0, 2, N'Mới tạo', (select id from Users where username ='hsproot'))");// CREATED
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(1, 2, N'Đã Xóa', (select id from Users where username ='hsproot'))");// DELETED
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(2, 2, N'Đã có thay đổi', (select id from Users where username ='hsproot'))");// UPDATED
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(20, 2, N'Thẻ mới chưa sử dụng', (select id from Users where username ='hsproot'))");// CARD IS NEW AND NOT USE
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(21, 2, N'Thẻ báo mất', (select id from Users where username ='hsproot'))");// CARD IS LOSTING
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(22, 2, N'Thẻ đang sử dụng', (select id from Users where username ='hsproot'))");// CARD IS USING
            Execute.Sql("INSERT INTO StatusTranslations(StatusId, LanguageId, Description, CreatedBy) VALUES(23, 2, N'Thẻ bị hư', (select id from Users where username ='hsproot'))");// CARD IS BROKEN
            #endregion

        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM StatusTranslations WHERE StatusId in (0,1,2,20,21,22,23)");
            Execute.Sql("DELETE FROM STATUSES WHERE Id in (0,1,2,20,21,22,23)");
        }
    }
}