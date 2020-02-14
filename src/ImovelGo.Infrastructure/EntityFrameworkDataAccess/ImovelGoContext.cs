using System;
using ImovelGo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class ImovelGoContext : DbContext
    {
        public ImovelGoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAddress> AccountAddress { get; set; }
        public DbSet<CompanyAddress> CompanyAddress { get; set; }
        public DbSet<AccountFavorite> AccountFavorite { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Broker> Broker { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<CompanyPage> CompanyPage { get; set; }
        public DbSet<PropertyPhoto> PropertyPhoto { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyType> PropertyType { get; set; }
        public DbSet<PropertyFeature> PropertyFeature { get; set; }
        public DbSet<PropertyMessage> PropertyMessage { get; set; }
        public DbSet<PropertyTour> PropertyTour { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<BannerArea> BannerArea { get; set; }
        public DbSet<CompanyArea> CompanyArea { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<PostComment> PostComment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plan>().HasData(new Plan
            {
                Id = 1,
                Name = "Inicial",
                CicleDays = 30,
                QuantityProperties = 20,
                Price = 0,
                Description = "Plano gratuíto",
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Plan>().HasData(new Plan
            {
                Id = 2,
                Name = "Economy",
                CicleDays = 30,
                QuantityProperties = 30,
                Price = 39.99M,
                Description = "Plano econômico",
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Plan>().HasData(new Plan
            {
                Id = 3,
                Name = "Deluxe",
                CicleDays = 30,
                QuantityProperties = 50,
                Price = 59.99M,
                Description = "Plano Deluxe",
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Plan>().HasData(new Plan
            {
                Id = 4,
                Name = "Ultimate",
                QuantityProperties = 500,
                Price = 99.99M,
                Description = "Plano Ultimate",
                CicleDays = 30,
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Company>().HasData(new Company {
                Id = 1,
                TemplateId = 1,
                PlanId = 1,
                About = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip.</p>",
                ImageAbout = "https://localhost:5011/img/sb.png",
                CompanyId = Guid.NewGuid(),
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Domain = "imovelgo.com",
                Email = "contato@imovelgo.com",
                Enabled = true,
                Facebook = "facebook.com",
                Instagram = "instagram.com",
                Linkedin = "linkedin.com",
                Logo = "/img/logo.png",
                MinDescription = "Somos uma plataforma online de gestão de imóveis. Ferramenta para gestão de Construtoras, Imobiliárias e Corretores.",
                Name = "Imovel Go",
                Skype = "skype.com",
                Telephone = "(11) 3443.2243",
                Twitter = "twitter.com"
            });

            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = 1,
                AccountId = Guid.NewGuid(),
                AccountTypeId = 2, //Consultor imobiliário
                Avatar = "https://localhost:5011/img/user-1.jpg",
                CellPhone = "92344.09123",
                CompanyId = 1,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                DDDCellPhone = 11,
                Deleted = false,
                Email = "ricardo@imovelgo.com",
                Enabled = true,
                FistName = "Ricardo",
                LastName = "Morais",
                Position = "Co-Fundador",
                Facebook = "http://www.facebook.com",
                Linkedin = "http://www.linkedin.com",
                Instagram = "http://www.instagram.com",
                Twitter = "http://www.twitter.com",
                Password = "123",
                Terms = true
            });

            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = 2,
                AccountId = Guid.NewGuid(),
                AccountTypeId = 2, //Consultor imobiliário
                Avatar = "https://localhost:5011/img/user-2.jpg",
                CellPhone = "99123.1323",
                CompanyId = 1,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                DDDCellPhone = 11,
                Deleted = false,
                Email = "carla@imovelgo.com",
                Enabled = true,
                FistName = "Carla",
                Facebook = "http://www.facebook.com",
                Linkedin = "http://www.linkedin.com",
                LastName = "Ferreira",
                Position = "Consultora",
                Password = "123",
                Terms = true
            });

            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = 3,
                AccountId = Guid.NewGuid(),
                AccountTypeId = 2, //Consultor imobiliário
                Avatar = "https://localhost:5011/img/user-3.jpg",
                CellPhone = "12312.1312",
                CompanyId = 1,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                DDDCellPhone = 11,
                Deleted = false,
                Email = "consultor@imovelgo.com",
                Enabled = true,
                FistName = "Jaime",
                LastName = "Santos",
                Facebook = "http://www.facebook.com",
                Position = "Consultor",
                Password = "123",
                Terms = true
            });

            modelBuilder.Entity<Template>().HasData(new Template
            {
                Id = 1,
                Name = "Rikada",
                Html = String.Empty,
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 1,
                Html = String.Empty,
                Title = "Inicio",
                Router = "Home/Index",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Home/Index.cshtml",
                HeaderMenu = true
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 2,
                Html = String.Empty,
                Title = "About",
                Router = "Home/About",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Home/About.cshtml",
                HeaderMenu = true
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 3,
                Html = String.Empty,
                Title = "Comprar",
                Router = "Home/Buy",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Home/Buy.cshtml",
                HeaderMenu = true
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 4,
                Html = String.Empty,
                Title = "Alugar",
                Router = "Home/Rent",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Home/Rent.cshtml",
                HeaderMenu = true
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 5,
                Html = String.Empty,
                Title = "Minha conta",
                Router = "Account/Index",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Account/Index.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 6,
                Html = String.Empty,
                Title = "Publicar",
                Router = "Property/Publish",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Property/Publish.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 7,
                Html = String.Empty,
                Title = "Detalhes do imóvel",
                Router = "Property/Detail",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Property/Detail.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 8,
                Html = String.Empty,
                Title = "Resultado da Busca",
                Router = "Search/Index",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Search/Index.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 9,
                Html = String.Empty,
                Title = "Comentários",
                Router = "Reviews/Index",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Reviews/Index.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 10,
                Html = String.Empty,
                Title = "Blog",
                Router = "Blog/Index",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Blog/Index.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<Page>().HasData(new Page
            {
                Id = 11,
                Html = String.Empty,
                Title = "Postagem",
                Router = "Blog/Post",
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                File = "/Blog/Post.cshtml",
                HeaderMenu = false
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 1,
                CompanyId = 1,
                PageId = 1,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Home"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 2,
                CompanyId = 1,
                PageId = 2,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "About"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 3,
                CompanyId = 1,
                PageId = 3,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Comprar"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 4,
                CompanyId = 1,
                PageId = 4,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Alugar"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 5,
                CompanyId = 1,
                PageId = 5,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Minha conta"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 6,
                CompanyId = 1,
                PageId = 6,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Publicar"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 7,
                CompanyId = 1,
                PageId = 7,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Detalhes do imóvel"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 8,
                CompanyId = 1,
                PageId = 8,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Resultado da busca"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 9,
                CompanyId = 1,
                PageId = 9,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Comentários"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 10,
                CompanyId = 1,
                PageId = 10,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Blog"
            });

            modelBuilder.Entity<CompanyPage>().HasData(new CompanyPage
            {
                Id = 11,
                CompanyId = 1,
                PageId = 11,
                DateAdd = DateTime.Now,
                Enabled = true,
                Title = "Postagem"
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 1,
                Name = "TopFullBannerModel1",
                PageId = 1, //Home
                File = "_TopFullBannerHome1Partial.cshtml",
                Path = "Component/LoadTopFullBannerModel1",
                Html = String.Empty,
                Position = 1,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 2,
                Name = "Features",
                PageId = 1, //Home
                File = "_SlideFeaturePartial.cshtml",
                Path = "Component/LoadSlideFeature",
                Html = String.Empty,
                Position = 2,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 3,
                Name = "LocationByRegion",
                PageId = 1, //Home
                File = "_LocationByRegionPartial.cshtml",
                Path = "Component/LoadLocationByRegion",
                Html = String.Empty,
                Position = 3,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 4,
                Name = "BannerPlaceHome",
                PageId = 1, //Home
                File = "_BannerPlaceHomePartial.cshtml",
                Path = "Component/LoadBannerPlaceHome",
                Html = String.Empty,
                Position = 4,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 5,
                Name = "Testimonials",
                PageId = 1, //Home
                File = "_TestimonialsPartial.cshtml",
                Path = "Component/LoadTestimonials",
                Html = String.Empty,
                Position = 5,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 6,
                Name = "Agents",
                PageId = 1, //Home
                File = "_AgentsPartial.cshtml",
                Path = "Component/LoadAgents",
                Html = String.Empty,
                Position = 6,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 7,
                Name = "StepHowUse",
                PageId = 1, //Home
                File = "_StepHowUsePartial.cshtml",
                Path = "Component/LoadStepHowUser",
                Html = String.Empty,
                Position = 7,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 8,
                Name = "SmartTestimonials",
                PageId = 1, //Home
                File = "_SmartTestimonialsPartial.cshtml",
                Path = "Component/LoadSmartTestimonials",
                Html = String.Empty,
                Position = 8,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 9,
                Name = "PopularProperties",
                PageId = 1, //Home
                File = "_PopularPropertiesPartial.cshtml",
                Path = "Component/LoadPopularProperties",
                Html = String.Empty,
                Position = 9,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 10,
                Name = "SmartTestimonialsBig",
                PageId = 1, //Home
                File = "_SmartTestimonialsBigPartial.cshtml",
                Path = "Component/LoadSmartTestimonialsBig",
                Html = String.Empty,
                Position = 10,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 11,
                Name = "PostsBlog",
                PageId = 1, //Home
                File = "_PostsBlogPartial.cshtml",
                Path = "Component/LoadPostsBlog",
                Html = String.Empty,
                Position = 11,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Area>().HasData(new Area
            {
                Id = 12,
                Name = "SearchResult",
                PageId = 3, //Buy
                File = "_ResultPartial.cshtml",
                Path = "Component/LoadSearchResult",
                Html = String.Empty,
                Position = 1,
                Enabled = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 1,
                AreaId = 1,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 2,
                AreaId = 2,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 3,
                AreaId = 3,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 4,
                AreaId = 4,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 5,
                AreaId = 5,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 6,
                AreaId = 6,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 7,
                AreaId = 7,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 8,
                AreaId = 8,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 9,
                AreaId = 9,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 10,
                AreaId = 10,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 11,
                AreaId = 11,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<CompanyArea>().HasData(new CompanyArea
            {
                Id = 12,
                AreaId = 12,
                CompanyId = 1,
                Enabled = true,
                Html = String.Empty,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                Name = "Brasil",
                Abbreviation = "BR",
                DateAdd = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<State>().HasData(new State
            {
                Id = 1,
                Name = "São Paulo",
                Abbreviation = "SP",
                DateAdd = DateTime.Now,
                Enabled = true,
                CountryId = 1
            });

            modelBuilder.Entity<City>().HasData(new City
            {
                Id = 1,
                Name = "São Paulo",
                DateAdd = DateTime.Now,
                Enabled = true,
                StateId = 1
            });

            modelBuilder.Entity<Zone>().HasData(new Zone
            {
                Id = 1,
                Name = "Sul",
                DateAdd = DateTime.Now,
                Enabled = true,
                CityId = 1
            });

            modelBuilder.Entity<Neighborhood>().HasData(new Neighborhood
            {
                Id = 1,
                Name = "Morumbi",
                DateAdd = DateTime.Now,
                Enabled = true,
                CityId = 1,
                ZoneId = 1
            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                DateAdd = DateTime.Now,
                AddressId = Guid.NewGuid(),
                CityId = 1,
                StateId = 1,
                Complement = "Complemento",
                CountryId = 1,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true,
                Latitude = 121.13213123,
                Longitude = 134.42423423,
                Name = "Casa",
                NeighborhoodId = 1,
                Number = "123",
                PostalCode = 09123123,
                Street = "Rua Morumbi",
                Main = true
            });

            //Address to Property
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 2,
                DateAdd = DateTime.Now,
                AddressId = Guid.NewGuid(),
                CityId = 1,
                StateId = 1,
                Complement = "Complemento",
                CountryId = 1,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true,
                Latitude = 121.13213123,
                Longitude = 134.42423423,
                Name = "Casa",
                NeighborhoodId = 1,
                Number = "123",
                PostalCode = 09123123,
                Street = "Rua Morumbi",
                Main = true
            });

            modelBuilder.Entity<CompanyAddress>().HasData(new CompanyAddress
            {
                Id = 1,
                AddressId = 1,
                CompanyId = 1,
                DateAdd = DateTime.Now
            });

            //Properties
            modelBuilder.Entity<PropertyType>().HasData(new PropertyType
            {
                Id = 1,
                Name = "Apartamento",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true
            });

            modelBuilder.Entity<PropertyType>().HasData(new PropertyType
            {
                Id = 2,
                Name = "Casa",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true
            });

            modelBuilder.Entity<PropertyType>().HasData(new PropertyType
            {
                Id = 3,
                Name = "Kitnet/Studio",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true
            });

            modelBuilder.Entity<PropertyType>().HasData(new PropertyType
            {
                Id = 4,
                Name = "Casa de condomínio",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 1,
                PropertyTypeId = 1,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 2,
                SalePrice = 0,
                RentPrice = 1000,
                GoalId = 2, //Alugar
                Discount = 0,
                TaxPrice = 300, //Taxas (impostos)
                CondominiumPrice = 100,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi",
                Suite = 0,
                BathRoom = 1,
                Vacancies = 0,
                PageViews = 0,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 50, //Largura área útil
                UsefulAreaDepth = 50, //Profundidade área útil
                TotalAreaWidth = 70, //Largura área total,
                TotalAreaDepth = 70, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 10,
                PetAccept = true,
                Furnished = false,
                NearMetro = true,
                AirCondition = true,
                Heating = false,
                NearBeach = false,
                Published = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 1,
                PropertyId = 1,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-7.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 2,
                PropertyTypeId = 1,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 2,
                SalePrice = 0,
                RentPrice = 100,
                GoalId = 2, //Alugar
                Discount = 0,
                TaxPrice = 300, //Taxas (impostos)
                CondominiumPrice = 100,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 10",
                Suite = 0,
                BathRoom = 1,
                Vacancies = 0,
                PageViews = 10,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 50, //Largura área útil
                UsefulAreaDepth = 50, //Profundidade área útil
                TotalAreaWidth = 70, //Largura área total,
                TotalAreaDepth = 70, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 10,
                PetAccept = true,
                Furnished = false,
                NearMetro = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 2,
                PropertyId = 2,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-4.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 3,
                PropertyId = 2,
                Title = "Fachada 2",
                Path = "https://localhost:5011/img/p-5.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 3,
                PropertyTypeId = 1,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 2,
                SalePrice = 0,
                RentPrice = 1000,
                GoalId = 2, //Alugar
                Discount = 0,
                TaxPrice = 300, //Taxas (impostos)
                CondominiumPrice = 100,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 5",
                Suite = 0,
                BathRoom = 1,
                Vacancies = 0,
                PageViews = 5,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 50, //Largura área útil
                UsefulAreaDepth = 50, //Profundidade área útil
                TotalAreaWidth = 70, //Largura área total,
                TotalAreaDepth = 70, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 10,
                PetAccept = true,
                Furnished = false,
                NearMetro = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 4,
                PropertyId = 3,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-3.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 4,
                PropertyTypeId = 2,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 2,
                SalePrice = 0,
                RentPrice = 1500,
                GoalId = 2, //Alugar
                Discount = 0,
                TaxPrice = 300, //Taxas (impostos)
                CondominiumPrice = 100,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 15",
                Suite = 0,
                BathRoom = 1,
                Vacancies = 0,
                PageViews = 15,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 50, //Largura área útil
                UsefulAreaDepth = 50, //Profundidade área útil
                TotalAreaWidth = 70, //Largura área total,
                TotalAreaDepth = 70, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 10,
                PetAccept = true,
                Furnished = false,
                NearMetro = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 5,
                PropertyId = 4,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-2.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 5,
                PropertyTypeId = 2,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 3,
                SalePrice = 15000,
                RentPrice = 0,
                GoalId = 1, //Vender
                Discount = 0,
                TaxPrice = 0, //Taxas (impostos)
                CondominiumPrice = 1000,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 15",
                Suite = 1,
                BathRoom = 2,
                Vacancies = 1,
                PageViews = 105,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 150, //Largura área útil
                UsefulAreaDepth = 150, //Profundidade área útil
                TotalAreaWidth = 170, //Largura área total,
                TotalAreaDepth = 170, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = true,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 1,
                PetAccept = true,
                Furnished = false,
                NearMetro = true,
                AirCondition = true,
                NearBeach = false,
                Published = true,
                Heating = false
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 6,
                PropertyId = 5,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-1.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 6,
                PropertyTypeId = 1,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 3,
                SalePrice = 10000,
                RentPrice = 0,
                GoalId = 1, //Vender
                Discount = 0,
                TaxPrice = 0, //Taxas (impostos)
                CondominiumPrice = 1500,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 15",
                Suite = 1,
                BathRoom = 2,
                Vacancies = 1,
                PageViews = 105,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 170, //Largura área útil
                UsefulAreaDepth = 170, //Profundidade área útil
                TotalAreaWidth = 110, //Largura área total,
                TotalAreaDepth = 110, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 1,
                PetAccept = true,
                Furnished = false,
                NearMetro = true,
                AirCondition = true,
                NearBeach = false,
                Published = true,
                Heating = false
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 7,
                PropertyId = 6,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-9.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 8,
                PropertyId = 6,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-11.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 7,
                PropertyTypeId = 1,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 3,
                SalePrice = 20000,
                RentPrice = 0,
                GoalId = 1, //Vender
                Discount = 0,
                TaxPrice = 0, //Taxas (impostos)
                CondominiumPrice = 1500,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 15",
                Suite = 1,
                BathRoom = 2,
                Vacancies = 1,
                PageViews = 105,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 170, //Largura área útil
                UsefulAreaDepth = 170, //Profundidade área útil
                TotalAreaWidth = 110, //Largura área total,
                TotalAreaDepth = 110, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 1,
                PetAccept = true,
                Furnished = false,
                NearMetro = true,
                AirCondition = true,
                NearBeach = false,
                Published = true,
                Heating = false
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 9,
                PropertyId = 7,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-12.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 10,
                PropertyId = 7,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-13.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Property>().HasData(new Property
            {
                Id = 8,
                PropertyTypeId = 2,
                BrokerId = 1,
                CompanyId = 1,
                StatusId = 1, //Disponível
                AddressId = 2,
                Bedroom = 3,
                SalePrice = 410000,
                RentPrice = 0,
                GoalId = 1, //Vender
                Discount = 0,
                TaxPrice = 0, //Taxas (impostos)
                CondominiumPrice = 2500,
                Description = "Alugo apartamento na esquina com a principal rua da cidade de São Paulo",
                Title = "Apartamento no Morumbi 15",
                Suite = 1,
                BathRoom = 2,
                Vacancies = 1,
                PageViews = 145,
                VideoUrl = String.Empty,
                UsefulAreaWidth = 170, //Largura área útil
                UsefulAreaDepth = 170, //Profundidade área útil
                TotalAreaWidth = 110, //Largura área total,
                TotalAreaDepth = 110, //Profundidade área total,
                PrivateAreaWidth = 0, //Largura área privativa
                PrivateAreaDepth = 0, //Profundidade área privativa
                IsNew = false,
                Featured = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = 1,
                PetAccept = true,
                Furnished = false,
                NearMetro = true,
                AirCondition = true,
                NearBeach = false,
                Published = true,
                Heating = false
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 11,
                PropertyId = 8,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-14.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PropertyPhoto>().HasData(new PropertyPhoto
            {
                Id = 12,
                PropertyId = 8,
                Title = "Fachada",
                Path = "https://localhost:5011/img/p-15.jpg",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Review>().HasData(new Review
            {
                Id = 1,
                CompanyId = 1,
                AccountId = 1,
                Deleted = false,
                Name = "Ricardo Morais",
                Avatar = "https://localhost:5011/img/user-1.jpg",
                Title = "alugou um apartamento no Morumbi",
                Description = "Desde o primeito contato o corretor Gustavo sempre foi muito atencioso. O atendimento inicial até o fechamento do contrato foi tudo muito tranquilo e sem problemas. Recomendo a imobiliária para qualquer pessoa que queira fazer negócio sem dorres de cabeça.",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Review>().HasData(new Review
            {
                Id = 2,
                CompanyId = 1,
                AccountId = 2,
                Deleted = false,
                Name = "Carla Ferreira",
                Avatar = "https://localhost:5011/img/user-1.jpg",
                Title = "alugou um apartamento na Conceição",
                Description = "Desde o primeito contato o corretor Gustavo sempre foi muito atencioso. O atendimento inicial até o fechamento do contrato foi tudo muito tranquilo e sem problemas. Recomendo a imobiliária para qualquer pessoa que queira fazer negócio sem dorres de cabeça.",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PostCategory>().HasData(new PostCategory
            {
                Id = 1,
                CompanyId = 1,
                Deleted = false,
                Name = "Aluguel",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<PostCategory>().HasData(new PostCategory
            {
                Id = 2,
                CompanyId = 1,
                Deleted = false,
                Name = "Geral",
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 1,
                PostId = Guid.NewGuid(),
                CompanyId = 1,
                AccountId = 1,
                CategoryId = 1,
                PageViews = 1,
                Title = "Porque As Pessoas Preferem Morar Em Apartamento",
                PhotoUrl = "https://localhost:5011/img/p-11.jpg",
                Resume = "Por questões de segurança e imensas áreas de lazer, pessoas estão cada vez mais optando por morar em apartamento.",
                Tags = "aluguel, moradia, segurança, apartamento",
                HtmlContent = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor										incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud										exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure										dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.										Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt										mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit										voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo										inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim										ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur										magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui										dolorem. <br><br>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum										dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in										culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis										iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,										eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt										explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,										sed quia consequuntur magni dolores eos qui ratione voluptatem.</p><blockquote>										<span class='icon'><i class='fas fa - quote - left'></i></span>										<p class='text'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod											tem										ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud ullamco laboris nisi ut aliquip ex ea commodo onsequat.</p>										<h5 class='name'>- Rosalina Pong</h5>									</blockquote><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor										incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud										exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure										dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.										Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt										mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit										voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo										inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim										ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur										magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui										dolorem. <br><br>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum										dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in										culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis										iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,										eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt										explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,										sed quia consequuntur magni dolores eos qui ratione voluptatem.</p>",
                Published = true,
                Deleted = false,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true
            });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 2,
                PostId = Guid.NewGuid(),
                CompanyId = 1,
                AccountId = 1,
                CategoryId = 2,
                PageViews = 10,
                Title = "Porque As Pessoas Preferem Morar Em Apartamento 2",
                PhotoUrl = "https://localhost:5011/img/p-11.jpg",
                Resume = "Por questões de segurança e imensas áreas de lazer, pessoas estão cada vez mais optando por morar em apartamento.",
                Tags = "aluguel, moradia, segurança, apartamento",
                HtmlContent = "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor										incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud										exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure										dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.										Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt										mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit										voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo										inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim										ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur										magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui										dolorem. <br><br>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum										dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in										culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis										iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,										eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt										explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,										sed quia consequuntur magni dolores eos qui ratione voluptatem.</p><blockquote>										<span class='icon'><i class='fas fa - quote - left'></i></span>										<p class='text'>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod											tem										ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud ullamco laboris nisi ut aliquip ex ea commodo onsequat.</p>										<h5 class='name'>- Rosalina Pong</h5>									</blockquote><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor										incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud										exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure										dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.										Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt										mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit										voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo										inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim										ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur										magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui										dolorem. <br><br>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum										dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in										culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis										iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam,										eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt										explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,										sed quia consequuntur magni dolores eos qui ratione voluptatem.</p>",
                Published = true,
                Deleted = false,
                DateAdd = DateTime.Now.AddDays(1),
                DateUpdated = DateTime.Now,
                Enabled = true
            });

        }
    }
}
