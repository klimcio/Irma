using Irma.Tools;
using NUnit.Framework;
using System.Linq;

namespace Irma.Tests
{
    public class FilterStringParserTests
    {
        [Test]
        public void FilterStringParser_returns_every_distinct_value_as_a_separate_filter()
        {
            var sut = new FilterStringParser();

            var result = sut.Parse("tomato, cucumber,oregano");

            Assert.AreEqual(result.Include.Count, 3);
            Assert.AreEqual(result.Exclude.Count, 0);
            Assert.Contains("tomato", result.Include);
            Assert.Contains("cucumber", result.Include);
            Assert.Contains("oregano", result.Include);
        }

        [Test]
        public void FilterStringParser_understands_minus_as_add_to_exclude_list()
        {
            var sut = new FilterStringParser();

            var result = sut.Parse("tomato, cucumber,-oregano");

            Assert.AreEqual(2, result.Include.Count);
            Assert.AreEqual(1, result.Exclude.Count);
            Assert.Contains("tomato", result.Include);
            Assert.Contains("cucumber", result.Include);
            Assert.Contains("oregano", result.Exclude);
        }
    }
}