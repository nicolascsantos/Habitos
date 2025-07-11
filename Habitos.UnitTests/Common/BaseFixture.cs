using Bogus;

namespace Habitos.UnitTests.Common
{
    public class BaseFixture
    {
        public BaseFixture()
        {
            Faker = new Faker("pt-BR");
        }

        public Faker Faker { get; set; }
    }
}
