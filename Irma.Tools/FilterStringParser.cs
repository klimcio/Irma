using System.Linq;

namespace Irma.Tools
{
    public interface IParseFilterStrings
    {
        ParsedFilters Parse(string inputString);
    }

    public class FilterStringParser : IParseFilterStrings
    {
        public ParsedFilters Parse(string inputString)
        {
            var conditions = inputString
                .Split(',')
                .Select(x => x.Trim());

            return new ParsedFilters
            {
                Include = conditions.Where(x => !x.StartsWith("-")).ToList(),
                Exclude = conditions.Where(x => x.StartsWith("-")).Select(x => x.TrimStart('-')).ToList()
            };
        }
    }
}
