﻿using FluentAssertions;

namespace Habitos.UnitTests.Domain.Habit
{
    [Collection(nameof(HabitTestFixture))]
    public class HabitTests
    {
        private readonly HabitTestFixture _fixture;

        public HabitTests(HabitTestFixture fixture)
            => _fixture = fixture;


        [Fact(DisplayName = "Instantiate")]
        [Trait("Domain", "Habit - Entity")]
        public void Instantiate()
        {
            // Arrange
            var habit = _fixture.GetValidHabit();

            var newHabit = new Habit(
                habit.Name,
                habit.Description,
                habit.Frequency,
                habit.WeekDays,
                habit.StartDate,
                habit.EndDate,
                habit.IsActive
            );

            // Act
            newHabit.Should().NotBeNull();
            newHabit.Id.Should().NotBe(default(Guid));
            newHabit.Name.Should().Be(habit.Name);
            newHabit.Description.Should().Be(habit.Description);
            newHabit.WeekDays.Should().BeEquivalentTo(habit.WeekDays);
            newHabit.Frequency.Should().Be(habit.Frequency);
            newHabit.StartDate.Should().Be(habit.StartDate);
            newHabit.EndDate.Should().Be(habit.EndDate);
            newHabit.IsActive.Should().Be(true);
        }
    }
}
