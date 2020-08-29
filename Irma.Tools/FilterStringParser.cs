using System;

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
            throw new NotImplementedException();
        }
    }
}
