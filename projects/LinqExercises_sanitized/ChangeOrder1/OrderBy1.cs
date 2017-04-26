using System.Collections.Generic;
using System.Linq;

namespace ChangeOrder1
{
    public interface Name
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }

    public static class OrderBy1
    {
        // Return the provided list of names, ordered by Last, in
        // descending order.
        public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            // Uncomment:
            // return names.???();
        }
    }
}