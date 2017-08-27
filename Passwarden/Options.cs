using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwarden
{
    class Options
    {
        public Boolean CaseSensitive { set; get; }
        public Boolean Nonsensitive { get; set; }
        public Boolean Numeric { get; set; }
        public Boolean Punctuation { get; set; }

        /// <summary>
        /// Creates an Options object that deafult all options to false
        /// </summary>
        public Options()
        {
            CaseSensitive = false;
            Nonsensitive = false;
            Numeric = false;
            Punctuation = false;
        }

        /// <summary>
        /// Creates an Options object with all options as specified parameters
        /// </summary>
        /// <param name="caseSensitive"></param>
        /// <param name="nonsensitive"></param>
        /// <param name="numeric"></param>
        /// <param name="punctuation"></param>
        public Options(bool caseSensitive, bool nonsensitive, bool numeric, bool punctuation)
        {
            CaseSensitive = caseSensitive;
            Nonsensitive = nonsensitive;
            Numeric = numeric;
            Punctuation = punctuation;
        }
    }
}
