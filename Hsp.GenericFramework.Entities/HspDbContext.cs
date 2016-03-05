using System;
using System.Data.Entity;
using System.Linq;
using Hsp.GenericFramework.Entities.Base;
using Hsp.GenericFramework.Entities.Models;

namespace Hsp.GenericFramework.Entities
{
    public class HspDbContext : DbContext
    {
        public HspDbContext()
            : base("HsbDefaultConnection")
        {
            Database.SetInitializer<HspDbContext>(null);
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<GroupUserRole> GroupUserRoles { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<MenuItemAuthorisation> MenuItemAuthorisations { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemTranslation> MenuItemTranslations { get; set; }
        public DbSet<MenuItemType> MenuItemTypes { get; set; }
        public DbSet<MenuItemTypeTranslation> MenuItemTypeTranslations { get; set; }
        public DbSet<PasswordRule> PasswordRules { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loopkup> Loopkups { get; set; }

        public DbSet<ExportGiftDetail> ExportGiftDetails { get; set; }public DbSet<ExportGift> ExportGifts { get; set; }
        public DbSet<ImportGiftDetail> ImportGiftDetails { get; set; }
        public DbSet<ImportGift> ImportGifts { get; set; }
        public DbSet<GiftStore> GiftStores { get; set; }
        public DbSet<GiftTranslation> GiftTranslations { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<GiftTypeTranslation> GiftTypeTranslations { get; set; }
        public DbSet<GiftType> GiftTypes { get; set; }
        public DbSet<ExportDetail> ExportDetails { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<ImportDetail> ImportDetails { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<DetailItemWareHouse> DetailItemWareHouses { get; set; }
        public DbSet<ItemPrice> ItemPrices { get; set; }
        public DbSet<ItemTranslation> ItemTranslations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemTypeTranslation> ItemTypeTranslations { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<MaterialTranslation> MaterialTranslations { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<EmployerTranslation> EmployerTranslations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<WageFeeTranslation> WageFeeTranslations { get; set; }
        public DbSet<WageFee> WageFees { get; set; }
        public DbSet<WareHouseTranslation> WareHouseTranslations { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<WareHouseTypeTranslation> WareHouseTypeTranslations { get; set; }
        public DbSet<WareHouseType> WareHouseTypes { get; set; }
        public DbSet<DepartmentTranslation> DepartmentTranslations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<TableTranslation> TableTranslations { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<KulExchangeDetailExport> KulExchangeDetailExports { get; set; }
        public DbSet<CustomerHistory> CustomerHistories { get; set; }
        public DbSet<CustomerTranslation> CustomerTranslations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MemberCard> MemberCards { get; set; }
        public DbSet<MemberTypeTranslation> MemberTypeTranslations { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<KulExchangeTranslation> KulExchangeTranslations { get; set; }
        public DbSet<KulExchange> KulExchanges { get; set; }
        public DbSet<AreaTranslation> AreaTranslations { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<CompanyTranslation> CompanyTranslations { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UnitTranslation> UnitTranslations { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<StatusTranslation> StatusTranslations { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Resource> Resources { get; set; }

        public override int SaveChanges()
        {
            try
            {
                var changeSets = ChangeTracker.Entries<BaseEntityWithUserInformation>();
                if (changeSets != null)
                {
                    foreach (var entry in changeSets.Where(ent => ent.State != EntityState.Unchanged))
                    {
                        if (entry.GetType().GetProperty("Created") != null && entry.GetType().GetProperty("Updated") != null)
                        {
                            if (entry.State == EntityState.Added)
                            {
                                entry.Entity.Created = DateTimeOffset.UtcNow;
                            }
                            else
                            {
                                entry.Entity.Updated = DateTimeOffset.UtcNow;
                            }
                        }
                       
                    }
                }
                return base.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
