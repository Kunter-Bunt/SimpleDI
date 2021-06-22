using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IMapper _mapper;
        private Address address = new Address()
        {
            City = "Vienna",
            pub_Country = "Austria",
            Id = 1,
            Street = "Schottenring",
            MyProp = "Test"
        };

        [TestMethod]
        public void TestMethod1()
        {
            Initialize();
            var res = Map();

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DependencyContainerManager.Default.RegisterStrong<INamingConvention>(_ => new LowerNamingConvention());
            var mapper = new SuperMapper();

            var res = mapper.Map(address, new AddressDTO(), DependencyContainerManager.Default);

            Assert.IsNotNull(res);
        }

        public AddressDTO Map()
        {
            return _mapper.Map<Address, AddressDTO>(address, DependencyContainerManager.Default);
        }

        public void Initialize()
        {
            DependencyContainerManager.Default.RegisterStrong<INamingConvention>(_ => new LowerNamingConvention());

            var config = new MapperConfiguration(cfg =>
            {
                cfg.RecognizePrefixes("pub_");
                cfg.RecognizeDestinationPrefixes("dat_");
                cfg.CreateMap<Address, AddressDTO>()
                    //.ForMember(_ => _.unmapped, _ => _.Ignore())
                    //.ForMember(_ => _.unmapped, _ => _.MapWithDependency((_, dep) => dep.SeparatorCharacter, _ => _.Resolve<INamingConvention>()))
                    .ForMember(_ => _.line1, _ => _.MapFrom(_ => $"{_.Street} {_.Number}"));
            });
            config.AssertConfigurationIsValid();
            //var executionPlan = config.BuildExecutionPlan(typeof(Address), typeof(AddressDTO));
            _mapper = config.CreateMapper();
        }

        public class Address
        {
            public int Id { get; set; }
            public string Street { get; set; }
            public int Number { get; set; }
            public string City { get; set; }
            public string pub_Country { get; set; }
            public string MyProp { get; set; }
        }

        public class AddressDTO
        {
            public int id { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string dat_myprop { get; set; }
            public string unmapped { get; set; }
            public string line1 { get; set; }
        }

        public class LowerNamingConvention : INamingConvention
        {
            private static readonly Regex LowerCase = new Regex(@"(\p{Lu}+(?=$|\p{Lu}[\p{Ll}0-9])|\p{Lu}?[\p{Ll}0-9]+)");
            public Regex SplittingExpression { get; } = LowerCase;
            public string SeparatorCharacter => "Dependency";//string.Empty;
            public string ReplaceValue(Match match) => match.Value[0].ToString().ToUpper() + match.Value.Substring(1);
        }

        public interface IMapping<in TInput, TOutput>
        {
            TOutput Map(TInput input, TOutput output, IDependencyContainer dep);
        }

        public abstract class AutoMapperBase
        {
            protected bool IsInitialized => Mapper != null;
            protected IMapper Mapper { get; set; }
            protected TOutput Map<TInput, TOutput>(TInput input, TOutput output, IDependencyContainer dep)
            {
                if (!IsInitialized) InternalInitialize();

                return Mapper.Map(input, output, dep);
            }

            protected abstract void Initialize(IMapperConfigurationExpression cfg);

            private void InternalInitialize()
            {
                var config = new MapperConfiguration(cfg => Initialize(cfg));
                Mapper = config.CreateMapper();
#if DEBUG
                config.AssertConfigurationIsValid();
#endif
            }
        }

        public class SuperMapper : AutoMapperBase,
            IMapping<Address, AddressDTO>
        {
            public AddressDTO Map(Address input, AddressDTO output, IDependencyContainer dep) => base.Map(input, output, dep);

            protected override void Initialize(IMapperConfigurationExpression cfg)
            {
                cfg.RecognizePrefixes("pub_");
                cfg.RecognizeDestinationPrefixes("dat_");
                cfg.CreateMap<Address, AddressDTO>()
                    .ForMember(_ => _.unmapped, _ => _.MapWithDependency((_, dep) => dep.SeparatorCharacter, _ => _.Resolve<INamingConvention>()))
                    .ForMember(_ => _.line1, _ => _.MapFrom(_ => $"{_.Street} {_.Number}"));
            }
        }
    }
}
