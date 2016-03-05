using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class ItemService : BaseService, IItemService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Item> _itemRepository;
        readonly IGenericRepository<ItemTranslation> _itemTranslationRepository;
        public UserProfileLogin _currentUser;
        readonly IGenericRepository<Export> _exportRepository;
        public ItemService(IUnitOfWork unitOfWork, IGenericRepository<Item> itemRepository, IGenericRepository<ItemTranslation> itemTranslationRepository) : base(unitOfWork)
        {
            _itemRepository = itemRepository;
            _itemTranslationRepository = itemTranslationRepository;
            _unitOfWork = unitOfWork;
        }


        public List<ItemModel> ListItem(int languageId)
        {
            //var listItem = _itemRepository.Get(x => x.StatusId != (int)Consts.Status.Deleted && x.ItemTranslations.FirstOrDefault(c=>c.LanguageId == languageId) != null).ToList();
            var listItem = _itemTranslationRepository.Get(x => x.Item.StatusId != (int)Consts.Status.Deleted && x.LanguageId == languageId).ToList();
            foreach (var item in listItem)
            {
                var price = item.Item.ItemPrices.FirstOrDefault(x => x.StatusId != (int) Consts.Status.Deleted && !x.IsCurrentPrice && x.EffectiveFromDate.Date <= DateTimeOffset.UtcNow.Date && (x.EffectiveToDate >= DateTimeOffset.UtcNow.Date || x.EffectiveToDate == null));
                if (price != null)
                {
                    item.Item.ItemPrice = price;
                }
                else
                {
                    price = item.Item.ItemPrices.FirstOrDefault(x => x.StatusId != (int)Consts.Status.Deleted && x.IsCurrentPrice);
                    item.Item.ItemPrice = price;
                }
            }

            return listItem.Select(Mapper.Map<ItemModel>).ToList();
        }

    }
}