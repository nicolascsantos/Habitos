using Habitos.UnitTests.Common;

namespace Habitos.UnitTests.Domain.Habit
{
    [CollectionDefinition(nameof(HabitTestFixtureCollection))]
    public class HabitTestFixtureCollection : ICollectionFixture<HabitTestFixture>
    {}

    public class HabitTestFixture : BaseFixture
    {
    }
}
