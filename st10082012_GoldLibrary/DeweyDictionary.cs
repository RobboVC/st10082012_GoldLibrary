using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10082012_GoldLibrary
{
    class DeweyDictionary
    {
        /// <summary>
        /// A dictionary that maps Dewey Decimal Classification call numbers to their corresponding descriptions.
        /// </summary>
        public readonly Dictionary<string, string> Dictionary = new Dictionary<string, string>
    {
        { "000", "Computer Science, Information, and General Works" },
        { "100", "Philosophy and Psychology" },
        { "200", "Religion" },
        { "300", "Social Sciences" },
        { "400", "Language" },
        { "500", "Natural Sciences and Mathematics" },
        { "600", "Technology" },
        { "700", "Arts and Recreation" },
        { "800", "Literature" },
        { "900", "History and Geography" }
    };
    }
}
   
