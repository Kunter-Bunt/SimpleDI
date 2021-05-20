using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mwo.SimpleDI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IMapper _mapper;

        [TestMethod]
        public void TestMethod1()
        {
            Initialize();
            var res = Map();

            Assert.IsTrue(true);
        }

        public AddressDTO Map()
        {
            return _mapper.Map<Address, AddressDTO>(new Address() { City = "istanbul", Country = "turkey", Id = 1, Street = "istiklal cad." });
        }

        public void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, Address>();
                cfg.CreateMap<Address, AddressDTO>();
            });
            config.AssertConfigurationIsValid();
            _mapper = config.CreateMapper();
        }

        public class Address
        {
            public int Id { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public class AddressDTO
        {
            public int Id { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }
    }
}
