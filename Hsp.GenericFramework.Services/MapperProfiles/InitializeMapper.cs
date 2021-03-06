﻿using System.Linq;
using AutoMapper;
using Hsp.GenericFramework.Dto.Models.Models;
using Hsp.GenericFramework.Entities.Models;

namespace Hsp.GenericFramework.Services.MapperProfiles
{
    public static class InitializeMapper
    {
        public static void LoadProfileMapper()
        {            
            Mapper.CreateMap<LanguageModel, Language>();
            Mapper.CreateMap<Language, LanguageModel>();

            Mapper.CreateMap<GroupUserRoleModel, GroupUserRole>();
            Mapper.CreateMap<GroupUserRole, GroupUserRoleModel>();

            Mapper.CreateMap<GroupUserModel, GroupUser>();
            Mapper.CreateMap<GroupUser, GroupUserModel>();

            Mapper.CreateMap<MenuItemAuthorisationModel, MenuItemAuthorisation>();
            Mapper.CreateMap<MenuItemAuthorisation, MenuItemAuthorisationModel>();

            Mapper.CreateMap<MenuItemModel, MenuItem>();
            Mapper.CreateMap<MenuItem, MenuItemModel>().ForMember(to=>to.Label, from=>from.MapFrom(sourc => sourc.MenuItemTranslations.FirstOrDefault().Label));

            Mapper.CreateMap<MenuItemTranslationModel, MenuItemTranslation>();
            Mapper.CreateMap<MenuItemTranslation, MenuItemTranslationModel>();

            Mapper.CreateMap<MenuItemTranslation, MenuItemModel>()
                .ForMember(src=>src.Id, des=>des.MapFrom(x=>x.MenuItemId))
                .ForMember(src=>src.Label, des=>des.MapFrom(x=>x.Label))
                .ForMember(src=>src.ActionName, des=>des.MapFrom(x=>x.MenuItem.ActionName))
                .ForMember(src=>src.ControllerName, des=>des.MapFrom(x=>x.MenuItem.ControllerName))
                .ForMember(src=>src.IsRoot, des=>des.MapFrom(x=>x.MenuItem.IsRoot))
                .ForMember(src=>src.IsActive, des=>des.MapFrom(x=>x.MenuItem.IsActive))
                .ForMember(src=>src.IsLink, des=>des.MapFrom(x=>x.MenuItem.IsLink))
                .ForMember(src=>src.CssClassIcon, des=>des.MapFrom(x=>x.MenuItem.CssClassIcon))
                .ForMember(src=>src.IsTitle, des=>des.MapFrom(x=>x.MenuItem.IsTitle))
                .ForMember(src=>src.ParentId, des=>des.MapFrom(x=>x.MenuItem.ParentId))
                .ForMember(src=>src.Order, des=>des.MapFrom(x=>x.MenuItem.Order))
                .ForMember(src=>src.SectionParameter, des=>des.MapFrom(x=>x.MenuItem.SectionParameter))
                ;


            Mapper.CreateMap<UserModel, User>();
            Mapper.CreateMap<User, UserModel>();
            Mapper.CreateMap<Loopkup, LoopkupModel>();
            Mapper.CreateMap<LoopkupModel, Loopkup>();

            Mapper.CreateMap<Company, CompanyModel>();
            Mapper.CreateMap<CompanyModel, Company>();

            Mapper.CreateMap<CompanyTranslation, CompanyTranslationModel>();
            Mapper.CreateMap<CompanyTranslationModel, CompanyTranslation>();

            Mapper.CreateMap<Area, AreaModel>();
            Mapper.CreateMap<AreaModel, Area>();

            Mapper.CreateMap<AreaTranslation, AreaTranslationModel>();
            Mapper.CreateMap<AreaTranslationModel, AreaTranslation>();

            Mapper.CreateMap<Export, ExportModel>();
            Mapper.CreateMap<ExportModel, Export>();

            Mapper.CreateMap<ExportDetail, ExportDetailModel>();
            Mapper.CreateMap<ExportDetailModel, ExportDetail>();

            Mapper.CreateMap<Item, ItemModel>();
            Mapper.CreateMap<ItemModel, Item>();

            Mapper.CreateMap<ItemTranslation, ItemModel>()
                .ForMember(to => to.ItemName, src => src.MapFrom(x => x.ItemName))
                .ForMember(to => to.CurrentPriceId, src => src.MapFrom(x => x.Item.ItemPrice.Id))
                .ForMember(to => to.CurrentPriceValue, src => src.MapFrom(x => x.Item.ItemPrice.Value))
                .ForMember(to => to.ItemTypeName,
                    src => src.MapFrom(x => x.Item.ItemType.ItemTypeTranslations.FirstOrDefault().ItemTypeName))
                .ForMember(to => to.Id, src => src.MapFrom(x => x.ItemId))
                .ForMember(to => to.StatusId, src => src.MapFrom(x => x.Item.StatusId))
                .ForMember(to => to.ItemTypeId, src => src.MapFrom(x => x.Item.ItemTypeId))
                .ForMember(to => to.UnitId, src => src.MapFrom(x => x.Item.UnitId));




            Mapper.CreateMap<ItemTranslation, ItemTranslationModel>();
            Mapper.CreateMap<ItemTranslationModel, ItemTranslation>();

            Mapper.CreateMap<ItemPrice, ItemPriceModel>();
            Mapper.CreateMap<ItemPriceModel, ItemPrice>();

            Mapper.CreateMap<ItemType, ItemTypeModel>();
            Mapper.CreateMap<ItemTypeModel, ItemType>();

            Mapper.CreateMap<ItemType, ItemTypeTranslation>();
            Mapper.CreateMap<ItemTypeTranslation, ItemType>();

            Mapper.CreateMap<Table, TableModel>();
            Mapper.CreateMap<TableModel, Table>();
            Mapper.CreateMap<TableTranslation, TableModel>()
                .ForMember(to=>to.Id, src=>src.MapFrom(x=>x.TableId))
                .ForMember(to => to.TableName, src => src.MapFrom(x => x.TableName));
            Mapper.CreateMap<TableTranslation, TableTranslationModel>().ForMember(to=>to.AreaId, x=>x.MapFrom(c=>c.Table.AreaId));
            Mapper.CreateMap<TableTranslationModel, TableTranslation>();

            Mapper.CreateMap<Unit, UnitModel>();
            Mapper.CreateMap<UnitModel, Unit>();

            Mapper.CreateMap<UnitTranslation, UnitTranslationModel>();
            Mapper.CreateMap<UnitTranslationModel, UnitTranslation>();

            Mapper.CreateMap<ResourceModel, Resource>();
            Mapper.CreateMap<Resource, ResourceModel>();

            Mapper.CreateMap<MenuItemTypeModel, MenuItemType>();
            Mapper.CreateMap<MenuItemType, MenuItemTypeModel>().ForMember(to => to.MenuItemTypeName, from => from.MapFrom(sourc => sourc.MenuItemTypeTranslations.FirstOrDefault().MenuItemTypeName));

            Mapper.CreateMap<Customer, CustomerModel>();
            Mapper.CreateMap<CustomerModel, Customer>();
            Mapper.CreateMap<CustomerTranslation, CustomerModel>()
                .ForMember(des => des.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(des => des.KulPoint, src => src.MapFrom(x => x.Customer.KulPoint));

            Mapper.CreateMap<MenuItemTranslation, MenuItemModel>()
                .ForMember(to => to.Label, src => src.MapFrom(r => r.Label))
                .ForMember(to => to.Id, src => src.MapFrom(r => r.MenuItemId))
                .ForMember(to => to.IsLink, src => src.MapFrom(r => r.MenuItem.IsLink))
                .ForMember(to => to.IsTitle, src => src.MapFrom(r => r.MenuItem.IsTitle))
                .ForMember(to => to.IsRoot, src => src.MapFrom(r => r.MenuItem.IsRoot))
                .ForMember(to => to.IsActive, src => src.MapFrom(r => r.MenuItem.IsActive))
                .ForMember(to => to.ActionName, src => src.MapFrom(r => r.MenuItem.ActionName))
                .ForMember(to => to.ControllerName, src => src.MapFrom(r => r.MenuItem.ControllerName))
                .ForMember(to => to.Order, src => src.MapFrom(r => r.MenuItem.Order))
                .ForMember(to => to.ParentId, src => src.MapFrom(r => r.MenuItem.ParentId))
                .ForMember(to => to.SectionParameter, src => src.MapFrom(r => r.MenuItem.SectionParameter))
                .ForMember(to => to.CssClassIcon, src => src.MapFrom(r => r.MenuItem.CssClassIcon))
                ;
            //Mapper.CreateMap<MenuItemCreateViewModel, MenuItem>();
            //Mapper.CreateMap<MenuItemTranslationCreateViewModel, MenuItemTranslation>();
        }
    }
}
