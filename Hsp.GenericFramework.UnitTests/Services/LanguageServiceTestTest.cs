using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Hsp.GenericFramework.Entities;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Hsp.GenericFramework.UnitTests.Services
{
    [TestClass]
    public class LanguageServiceTest
    {
        private ILanguageService _languageService;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private Mock<IGenericRepository<Language>> _mockLanguageRepository;
        private Mock<HspDbContext> _mockHspContext;
        private Mock<DbSet<Language>> _mockDbSet;
        private IQueryable<Language> _listLanguage;
        private Mock<IMappingEngine> mapper;
        private ServiceModules serviceModule;

        [TestInitialize]
        public void Initialize()
        {
            //_listLanguage = new List<Language>
            //{
            //    new Language { CultureCode= "vi-vn", CultureName = "VN", DisplayName = "Tiếng Việt"},
            //    new Language {CultureCode= "en-us", CultureName = "EN", DisplayName = "The United States"},
            //    new Language {CultureCode= "china", CultureName = "CN", DisplayName = "China"}
            //}.AsQueryable();

            //_mockDbSet = new Mock<DbSet<Language>>();
            //_mockDbSet.As<IQueryable<Language>>().Setup(x => x.Provider).Returns(_listLanguage.Provider);
            //_mockDbSet.As<IQueryable<Language>>().Setup(x => x.Expression).Returns(_listLanguage.Expression);
            //_mockDbSet.As<IQueryable<Language>>().Setup(x => x.ElementType).Returns(_listLanguage.ElementType);
            //_mockDbSet.As<IQueryable<Language>>().Setup(x => x.GetEnumerator()).Returns(_listLanguage.GetEnumerator);

            //_mockHspContext = new Mock<HspDbContext>();
            //_mockHspContext.Setup(x => x.Set<Language>()).Returns(_mockDbSet.Object);


            //_mockUnitOfWork = new Mock<IUnitOfWork>();
            //_mockLanguageRepository = new Mock<IGenericRepository<Language>>();

            //_languageService = new LanguageService(_mockUnitOfWork.Object, _mockLanguageRepository.Object);
            //mapper = new Mock<IMappingEngine>();
            //serviceModule =new ServiceModules("web");

        }
        [TestMethod]
        public void Service_GetAllLanguage()
        {
            //Arrange
            _mockLanguageRepository.Setup(x => x.Get(c=>c.IsActive,null, null, null, null)).Returns(_listLanguage);
           

            //Act
            var result = _languageService.GetAllLanguage();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
    }
}
