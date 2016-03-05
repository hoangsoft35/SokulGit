using System;
using System.Collections.Generic;
using FluentMigrator;
using FluentMigrator.Expressions;

namespace Migration.Admin.Migrations
{
    [Migration(20151204003417)]
    public class m20151204003417_MergeTableFromCurrentApplication : FluentMigrator.Migration
    {
        public override void Up()
        {
            #region Statuses

            Create.Table("Statuses").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_Statuses_Id")
                .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("StatusTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_StatusTranslations_Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_StatusTranslations_StatusId_Statuses_Id", "Statuses", "Id")
                .WithDefaultValue(0)
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_StatusTranslations_StatusId_Languages_Id", "Languages", "Id")
                .WithColumn("Description").AsString(200).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_StatusTranslations_StatusId_LanguageId_Description")
                .OnTable("StatusTranslations")
                .Columns("StatusId", "LanguageId", "Description");

            #endregion

            #region Companies

            Create.Table("Companies").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Companies_Id").Identity()
                .WithColumn("MobileNumber").AsString(20).Nullable()
                .WithColumn("PhoneNumber").AsString(50).Nullable()
                .WithColumn("Fax").AsString(20).Nullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Companies_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("CompanyTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_CompanyTranslations_Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CompanyTranslations_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CompanyTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("CompanyName").AsString(200).NotNullable()
                .WithColumn("CompanyAddress").AsString(200).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_CompanyTranslations_CompanyId_LanguageId_CompanyName")
                .OnTable("CompanyTranslations")
                .Columns("CompanyId", "LanguageId", "CompanyName");

            #endregion

            #region Areas

            Create.Table("Areas")
                .InSchema("dbo")
                .WithColumn("Id")
                .AsInt32()
                .NotNullable()
                .PrimaryKey("Areas_Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Areas_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Areas_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("AreaTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_AreaTranslations_Id")
                .WithColumn("AreaId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_AreaTranslations_AreaId_Areas_Id", "Areas", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_AreaTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("AreaName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_AreaTranslations_AreaId_LanguageId_Description")
                .OnTable("AreaTranslations")
                .Columns("AreaId", "LanguageId", "AreaName");


            #endregion

            #region KulExchanges

            Create.Table("KulExchanges").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_KulExchanges_Id")
                .WithColumn("Value").AsInt32().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_KulExchanges_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("KulExchangeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_KulExchangeTranslations_Id")
                .WithColumn("KulExchangeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_KulExchangeTranslations_KulExchangeId_KulExchanges_Id", "KulExchanges", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_KulExchangeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("KulName").AsString(50).NotNullable()
                .WithColumn("KulDescription").AsString(200).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_KulExchangeTranslations_KulExchangeId_LanguageId_KulName")
                .OnTable("KulExchangeTranslations")
                .Columns("KulExchangeId", "LanguageId", "KulName");

            #endregion

            #region MemberTypes

            Create.Table("MemberTypes").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_MemberTypes_Id")
                .WithColumn("KulCoinToUpgrade").AsInt32().NotNullable()
                .WithColumn("DiscountForThisType").AsInt32().Nullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MemberTypes_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("MemberTypeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_MemberTypeTranslations_Id")
                .WithColumn("MemberTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MemberTypeTranslations_MemberTypeId_MemberTypes_Id", "MemberTypes", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MemberTypeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("MemberTypeName").AsString(50).NotNullable()
                .WithColumn("MemberTypeDescription").AsString(200).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_MemberTypeTranslations_MemberTypeId_LanguageId_MemberTypeName")
                .OnTable("MemberTypeTranslations")
                .Columns("MemberTypeId", "LanguageId", "MemberTypeName");

            #endregion

            #region MemberCards

            Create.Table("MemberCards").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_MemberCards_Id").Identity()
                .WithColumn("MemberCardNumber").AsAnsiString(50).NotNullable().Unique()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MemberCards_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region Customers

            Create.Table("Customers").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Customers_Id").Identity()
                .WithColumn("Dob").AsDateTimeOffset().Nullable()
                .WithColumn("IdCard").AsAnsiString(20).Nullable()
                .WithColumn("MobileNumber").AsString(20).Nullable()
                .WithColumn("PhoneNumber").AsString(20).Nullable()
                .WithColumn("IsActiveCard").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("MemberCardNumber").AsString(50).Nullable()
                .WithColumn("DateActiveCard").AsDateTimeOffset().Nullable()
                .WithColumn("KulPoint").AsInt32().NotNullable()
                .WithColumn("TotalKulPoint").AsInt32().NotNullable()
                .WithColumn("TotalLost").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("IsCustomerLock").AsBoolean().NotNullable().WithDefaultValue(0)
                .WithColumn("MemberTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MemberTypes_MemberTypesId_MemberType_Id", "MemberTypes", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Customers_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("CustomerTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_CustomerTranslations_Id")
                .WithColumn("CustomerId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CustomerTranslations_CustomerId_Customer_Id", "Customers", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CustomerTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("MiddleName").AsString(50).NotNullable()
                .WithColumn("FullName").AsString(200).NotNullable()
                .WithColumn("Address").AsString(200).Nullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_CustomerTranslations_CustomerId_LanguageId")
                .OnTable("CustomerTranslations")
                .Columns("CustomerId", "LanguageId");

            #endregion

            #region CustomerHistorys

            Create.Table("CustomerHistorys").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_CustomerHistorys_Id").Identity()
                .WithColumn("CustomerId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CustomerHistorys_CustomerId_Statuses_Id", "Customers", "Id")
                .WithColumn("FunctionName").AsString(100).NotNullable()
                .WithColumn("Detail").AsString(200).NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_CustomerHistorys_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region KulExchangeDetailExports

            Create.Table("KulExchangeDetailExports").InSchema("dbo")
                .WithColumn("Id")
                .AsInt32()
                .NotNullable()
                .Identity()
                .PrimaryKey("PK_KulExchangeDetailExports_Id")
                .Identity()
                .WithColumn("TotalBillFrom").AsDecimal().NotNullable()
                .WithColumn("TotalBillTo").AsDecimal().NotNullable()
                .WithColumn("KulBonusValue").AsInt32().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_KulExchangeDetailExports_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region Tables

            Create.Table("Tables").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey("PK_Tables_Id")
                .WithColumn("AreaId").AsInt32().NotNullable().ForeignKey("FK_Table_AreaId", "Areas", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Tables_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("TableTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_TableTranslations_Id")
                .WithColumn("TableId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_TableTranslations_TableId_Tables_Id", "Tables", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_TableTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("TableName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_TableTranslations_TableId_LanguageId_TableName")
                .OnTable("TableTranslations")
                .Columns("TableId", "LanguageId", "TableName");

            #endregion

            #region Departments

            Create.Table("Departments").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Departments_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Departments_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("DepartmentTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_DepartmentTranslations_Id")
                .WithColumn("DepartmentId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_DepartmentTranslations_DepartmentId_Departments_Id", "Departments", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_DepartmentTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("DepartmentName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_DepartmentTranslations_DepartmentId_LanguageId_DepartmentName")
                .OnTable("DepartmentTranslations")
                .Columns("DepartmentId", "LanguageId", "DepartmentName");

            #endregion

            #region WareHouseTypes

            Create.Table("WareHouseTypes").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WareHouseTypes_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouseTypes_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("WareHouseTypeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WareHouseTypeTranslations_Id")
                .WithColumn("WareHouseTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouseTypeTranslations_WareHouseTypeId_WareHouseTypes_Id", "WareHouseTypes", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouseTypeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("WareHouseTypeName").AsString(50).NotNullable()
                .WithColumn("WareHouseTypeDescription").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_WareHouseTypeTranslations_WareHouseTypeId_LanguageId_WareHouseTypeName")
                .OnTable("WareHouseTypeTranslations")
                .Columns("WareHouseTypeId", "LanguageId", "WareHouseTypeName");

            #endregion

            #region WareHouses

            Create.Table("WareHouses").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WareHouses_Id").Identity()
                .WithColumn("WareHouseTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouse_WareHouseTypeId_WareHouseTypes_Id", "WareHouseTypes", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouses_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouses_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("WareHouseTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WareHouseTranslations_Id")
                .WithColumn("WareHouseId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouseTranslations_WareHouseId_WareHouses_Id", "WareHouses", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WareHouseTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("WareHouseName").AsString(50).NotNullable()
                .WithColumn("WareHouseDescription").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_WareHouseTranslations_WareHouseId_LanguageId_WareHouseName")
                .OnTable("WareHouseTranslations")
                .Columns("WareHouseId", "LanguageId", "WareHouseName");

            #endregion

            #region WageFees

            Create.Table("WageFees").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WageFees_Id").Identity()
                .WithColumn("Price").AsDecimal().NotNullable().WithDefaultValue(0)
                .WithColumn("DepartmentId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WageFees_DepartmentId_WageFees_Id", "Departments", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WageFees_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_WageFees_DepartmentId_Price")
                .OnTable("WageFees")
                .Columns("Price", "DepartmentId");

            Create.Table("WageFeeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_WageFeeTranslations_Id")
                .WithColumn("WageFeeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WageFeeTranslations_WageFeeId_WageFees_Id", "WageFees", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_WageFeeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("WageFeeName").AsString(50).NotNullable()
                .WithColumn("WageFeeDescription").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_WageFeeTranslations_WageFeeId_LanguageId_WageFeeName")
                .OnTable("WageFeeTranslations")
                .Columns("WageFeeId", "LanguageId", "WageFeeName");

            #endregion

            #region Employers

            Create.Table("Employers").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Employers_Id").Identity()
                .WithColumn("Dob").AsDateTimeOffset().Nullable()
                .WithColumn("IdCard").AsAnsiString(20).Nullable()
                .WithColumn("MobileNumber").AsString(20).Nullable()
                .WithColumn("PhoneNumber").AsString(20).Nullable()
                .WithColumn("DateWork").AsDateTimeOffset().NotNullable()
                .WithColumn("DepartmentId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Employers_DepartmentId_Departments_Id", "Departments", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Employers_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Employers_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("EmployerTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_EmployerTranslations_Id")
                .WithColumn("EmployerId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_EmployerTranslations_EmployerId_Employer_Id", "Employers", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_EmployerTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("MiddleName").AsString(50).NotNullable()
                .WithColumn("FullName").AsString(200).NotNullable()
                .WithColumn("Address").AsString(200).Nullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_EmployerTranslations_EmployerId_LanguageId")
                .OnTable("EmployerTranslations")
                .Columns("EmployerId", "LanguageId");

            #endregion



            #region Units

            Create.Table("Units").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Units_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Units_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("UnitTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_UnitTranslations_Id")
                .WithColumn("UnitId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_UnitTranslations_UnitId_Units_Id", "Units", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_UnitTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("UnitName").AsString(200).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_UnitTranslations_UnitId_LanguageId_UnitName")
                .OnTable("UnitTranslations")
                .Columns("UnitId", "LanguageId", "UnitName");

            #endregion

            #region Materials

            Create.Table("Materials").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Materials_Id").Identity()
                .WithColumn("UnitId").AsInt32().NotNullable().ForeignKey("FK_Materials_UnitId_Units_Id", "Units", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Materials_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("MaterialTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_MaterialTranslations_Id")
                .WithColumn("MaterialId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MaterialTranslations_MaterialId_Materials_Id", "Materials", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_MaterialTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("MaterialName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_MaterialTranslations_MaterialId_LanguageId_MaterialName")
                .OnTable("MaterialTranslations")
                .Columns("MaterialId", "LanguageId", "MaterialName");

            #endregion

            #region ItemTypes

            Create.Table("ItemTypes").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_ItemTypes_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemTypes_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("ItemTypeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_ItemTypeTranslations_Id")
                .WithColumn("ItemTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemTypeTranslations_ItemTypeId_ItemTypes_Id", "ItemTypes", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemTypeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("ItemTypeName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_ItemTypeTranslations_ItemTypeId_LanguageId_ItemTypeName")
                .OnTable("ItemTypeTranslations")
                .Columns("ItemTypeId", "LanguageId", "ItemTypeName");

            #endregion

            #region Items

            Create.Table("Items").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Items_Id").Identity()
                .WithColumn("IsDrink").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("ItemTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Items_ItemTypeId_ItemTypes_Id", "ItemTypes", "Id")
                .WithColumn("UnitId").AsInt32().NotNullable().ForeignKey("FK_Items_UnitId_Units_Id", "Units", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Items_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("ItemTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_ItemTranslations_Id")
                .WithColumn("ItemId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemTranslations_ItemId_Items_Id", "Items", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("ItemName").AsString(50).NotNullable()
                .WithColumn("Shortcut").AsAnsiString(50).Nullable().WithDefaultValue("")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_ItemTranslations_ItemId_LanguageId_ItemName")
                .OnTable("ItemTranslations")
                .Columns("ItemId", "LanguageId", "ItemName");

            #endregion

            #region ItemPrices

            Create.Table("ItemPrices").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_ItemPrices_Id").Identity()
                .WithColumn("ItemId").AsInt32().NotNullable().ForeignKey("FK_ItemPrices_ItemId_Items_Id", "Items", "Id")
                .WithColumn("IsCurrentPrice").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Value").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemPrices_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ItemPrices_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("EffectiveFromDate").AsDateTimeOffset().NotNullable()
                .WithColumn("EffectiveToDate").AsDateTimeOffset().Nullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion


            #region DetailItemWareHouses

            Create.Table("DetailItemWareHouses").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_DetailItemWareHouses_Id").Identity()
                .WithColumn("ItemId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_DetailItemWareHouses_ItemId_Items_Id", "Items", "Id")
                .WithColumn("WareHouseId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_DetailItemWareHouses_WareHouseId_WareHouses_Id", "WareHouses", "Id")
                .WithColumn("Quantity").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_DetailItemWareHouses_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region Imports

            Create.Table("Imports").InSchema("dbo")
                .WithColumn("Id").AsAnsiString(20).NotNullable().PrimaryKey("PK_Imports_Id")
                .WithColumn("Note").AsString(250).Nullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Imports_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Imports_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region ImportDetails

            Create.Table("ImportDetails").InSchema("dbo")
                .WithColumn("ImportId").AsAnsiString(20).NotNullable()
                .WithColumn("MaterialId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportDetails_MaterialId_Materials_Id", "Materials", "Id")
                .WithColumn("Quantity").AsFloat().NotNullable().WithDefaultValue(0)
                .WithColumn("Price").AsDecimal().NotNullable().WithDefaultValue(0)
                .WithColumn("UnitId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportDetails_UnitId_Units_Id", "Units", "Id")
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportDetails_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_ImportDetails_ImportId_ItemId")
                .OnTable("ImportDetails")
                .Columns("ImportId", "MaterialId");


            #endregion

            #region Exports

            Create.Table("Exports").InSchema("dbo")
                .WithColumn("Id").AsAnsiString(20).NotNullable().PrimaryKey("PK_Exports_Id")
                .WithColumn("TableId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Exports_TableId_Tables_Id", "Tables", "Id")
                .WithColumn("TableDiscount").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("IsPayAll").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("Vat").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("Service").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("DatePaid").AsDateTimeOffset().Nullable()
                .WithColumn("KulQuantity").AsInt32().NotNullable().WithDefaultValue(0)
                .WithColumn("MoneyExchangeByKul").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Exports_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("CompanyId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Exports_CompanyId_Companies_Id", "Companies", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion

            #region ExportDetails

            Create.Table("ExportDetails").InSchema("dbo")
                .WithColumn("ExportId")
                .AsAnsiString(20)
                .NotNullable()
                .ForeignKey("FK_ExportDetails_ExportId_Exports_Id", "Exports", "Id")
                .WithColumn("ItemId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ExportDetails_ItemId_Items_Id", "Items", "Id")
                .WithColumn("Quantity").AsFloat().NotNullable().WithDefaultValue(0)
                .WithColumn("Price").AsDecimal().NotNullable().WithDefaultValue(0)
                .WithColumn("ItemDiscount").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("IsItemPay").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("ItemPriceId")
                .AsInt32()
                .NotNullable()
                .WithDefaultValue(0)
                .ForeignKey("FK_ExportDetails_ItemPriceId_ItemPrices_Id", "ItemPrices", "Id")
                .WithColumn("Note").AsBoolean().WithDefaultValue(false)
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ExportDetails_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_ExportDetails_ExportId_ItemId").OnTable("ExportDetails").Columns("ExportId", "ItemId");

            #endregion

            #region GiftTypes

            Create.Table("GiftTypes").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_GiftTypes_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftTypes_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("GiftTypeTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_GiftTypeTranslations_Id")
                .WithColumn("GiftTypeId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftTypeTranslations_GiftTypeId_GiftTypes_Id", "GiftTypes", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftTypeTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("GiftTypeName").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_GiftTypeTranslations_GiftTypeId_LanguageId_GiftTypeName")
                .OnTable("GiftTypeTranslations")
                .Columns("GiftTypeId", "LanguageId", "GiftTypeName");

            #endregion

            #region Gifts

            Create.Table("Gifts").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_Gifts_Id").Identity()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_Gifts_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();


            Create.Table("GiftTranslations").InSchema("dbo")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey("PK_GiftTranslations_Id")
                .WithColumn("GiftId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftTranslations_GiftId_Gifts_Id", "Gifts", "Id")
                .WithColumn("LanguageId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftTranslations_LanguageId_Languages_Id", "Languages", "Id")
                .WithColumn("GiftName").AsString(50).NotNullable()
                .WithColumn("GiftDescription").AsString(50).NotNullable()
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.UniqueConstraint("UK_GiftTranslations_GiftId_LanguageId_GiftName")
                .OnTable("GiftTranslations")
                .Columns("GiftId", "LanguageId", "GiftName");

            #endregion


            #region GiftStores

            Create.Table("GiftStores").InSchema("dbo")
                .WithColumn("GiftId")
                .AsInt32()
                .NotNullable()
                .Identity()
                .ForeignKey("FK_GiftStores_GiftId_Gifts_Id", "Gifts", "Id")
                .WithColumn("PriceImportVnd").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("PriceExportVnd").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("PriceExportKul").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_GiftStores_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            #endregion


            #region ImportGifts

            Create.Table("ImportGifts").InSchema("dbo")
                .WithColumn("Id").AsAnsiString(20).NotNullable().PrimaryKey("FK_ImportGifts_Id")
                .WithColumn("Note").AsString(200).NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportGifts_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("ImportGiftDetails").InSchema("dbo")
                .WithColumn("ImportGiftId")
                .AsAnsiString(20)
                .NotNullable()
                .ForeignKey("FK_ImportGiftDetails_ImportGiftId_ImportGifts_Id", "ImportGifts", "Id")
                .WithColumn("GiftId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportGiftDetails_GiftId_Gifts_Id", "Gifts", "Id")
                .WithColumn("PriceImportVnd").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("PriceExportVnd").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("PriceExportKul").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ImportGiftDetails_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_ImportGiftDetails_ImportGiftId_GiftID")
                .OnTable("ImportGiftDetails")
                .Columns("ImportGiftId", "GiftId", "PriceImportVnd");


            #endregion

            #region ExportGifts

            Create.Table("ExportGifts").InSchema("dbo")
                .WithColumn("Id").AsAnsiString(20).NotNullable().PrimaryKey("FK_ExportGifts_Id")
                .WithColumn("MemberCardNumber").AsAnsiString(50).NotNullable()
                .WithColumn("IsMember").AsBoolean().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ExportGifts_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();

            Create.Table("ExportGiftDetails").InSchema("dbo")
                .WithColumn("ExportGiftId")
                .AsAnsiString(20)
                .NotNullable()
                .ForeignKey("FK_ExportGiftDetails_ExportGiftId_ExportGifts_Id", "ExportGifts", "Id")
                .WithColumn("GiftId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ExportGiftDetails_GiftId_Gifts_Id", "Gifts", "Id")
                .WithColumn("PriceVnd").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("PriceKul").AsDecimal(18, 2).NotNullable().WithDefaultValue(0)
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("StatusId")
                .AsInt32()
                .NotNullable()
                .ForeignKey("FK_ExportGiftDetails_StatusId_Statuses_Id", "Statuses", "Id")
                .WithColumn("Created").AsDateTimeOffset().NotNullable().WithDefaultValue(DateTime.UtcNow)
                .WithColumn("CreatedBy").AsGuid().NotNullable()
                .WithColumn("Updated").AsGuid().Nullable()
                .WithColumn("UpdatedBy").AsDateTimeOffset().Nullable();
            Create.PrimaryKey("PK_ExportGiftDetails_ExportGiftId_GiftID")
                .OnTable("ExportGiftDetails")
                .Columns("ExportGiftId", "GiftId");


            #endregion

        }

        public override void Down()
        {
            Delete.Table("ExportGiftDetails").InSchema("dbo");
            Delete.Table("ExportGifts").InSchema("dbo");
            Delete.Table("ImportGiftDetails").InSchema("dbo");
            Delete.Table("ImportGifts").InSchema("dbo");
            Delete.Table("GiftStores").InSchema("dbo");
            Delete.Table("GiftTranslations").InSchema("dbo");
            Delete.Table("Gifts").InSchema("dbo");
            Delete.Table("GiftTypeTranslations").InSchema("dbo");
            Delete.Table("GiftTypes").InSchema("dbo");
            Delete.Table("ExportDetails").InSchema("dbo");
            Delete.Table("Exports").InSchema("dbo");
            Delete.Table("ImportDetails").InSchema("dbo");
            Delete.Table("Imports").InSchema("dbo");
            Delete.Table("DetailItemWareHouses").InSchema("dbo");
            Delete.Table("ItemPrices").InSchema("dbo");
            Delete.Table("ItemTranslations").InSchema("dbo");
            Delete.Table("Items").InSchema("dbo");
            Delete.Table("ItemTypeTranslations").InSchema("dbo");
            Delete.Table("ItemTypes").InSchema("dbo");
            Delete.Table("MaterialTranslations").InSchema("dbo");
            Delete.Table("Materials").InSchema("dbo");
            Delete.Table("EmployerTranslations").InSchema("dbo");
            Delete.Table("Employers").InSchema("dbo");
            Delete.Table("WageFeeTranslations").InSchema("dbo");
            Delete.Table("WageFees").InSchema("dbo");
            Delete.Table("WareHouseTranslations").InSchema("dbo");
            Delete.Table("WareHouses").InSchema("dbo");
            Delete.Table("WareHouseTypeTranslations").InSchema("dbo");
            Delete.Table("WareHouseTypes").InSchema("dbo");
            Delete.Table("DepartmentTranslations").InSchema("dbo");
            Delete.Table("Departments").InSchema("dbo");
            Delete.Table("TableTranslations").InSchema("dbo");
            Delete.Table("Tables").InSchema("dbo");
            Delete.Table("KulExchangeDetailExports").InSchema("dbo");
            Delete.Table("CustomerHistorys").InSchema("dbo");
            Delete.Table("CustomerTranslations").InSchema("dbo");
            Delete.Table("Customers").InSchema("dbo");
            Delete.Table("MemberCards").InSchema("dbo");
            Delete.Table("MemberTypeTranslations").InSchema("dbo");
            Delete.Table("MemberTypes").InSchema("dbo");
            Delete.Table("KulExchangeTranslations").InSchema("dbo");
            Delete.Table("KulExchanges").InSchema("dbo");
            Delete.Table("AreaTranslations").InSchema("dbo");
            Delete.Table("Areas").InSchema("dbo");
            Delete.Table("CompanyTranslations").InSchema("dbo");
            Delete.Table("Companies").InSchema("dbo");
            Delete.Table("UnitTranslations").InSchema("dbo");
            Delete.Table("Units").InSchema("dbo");
            Delete.Table("StatusTranslations").InSchema("dbo");
            Delete.Table("Statuses").InSchema("dbo");


        }
    }
}