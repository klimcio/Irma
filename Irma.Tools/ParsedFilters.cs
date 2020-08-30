using System.Collections.Generic;

namespace Irma.Tools
{
    public class ParsedFilters
    {
        public List<string> Include { get; set; }
        public List<string> Exclude { get; set; }

        public ParsedFilters(List<string> include = null, List<string> exclude = null)
        {
            Include = include ?? new List<string>();
            Exclude = exclude ?? new List<string>();
        }
    }
}
