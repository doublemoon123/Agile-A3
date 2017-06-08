using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUI
{
    class candidate
    {

        public int preferenceOrder { get; set; }
        public string candidateName { get; set; }
        public int firstPreference { get; set; }

        
        public override string ToString()
        {
            return candidateName;
        }
    }
}
