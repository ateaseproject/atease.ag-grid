using FluentAssertions;

namespace AtEase.AgGrid.Test
{
    public class SortModelTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("xyz")]
        public void SetSort_should_throw_exception_when_value_is_not_valid(string sort)
        {
            Action act = () => SortModelBuilder.CreateNew().SetSort(sort).Build();
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Create_should_set_values_when_values_are_valid()
        {
            SortModelBuilder.CreateNew().Build();
        }
    }
}