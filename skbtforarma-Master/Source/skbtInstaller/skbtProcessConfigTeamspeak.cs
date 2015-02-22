using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigTeamspeak : skbtProcessConfigBasic
    {
        public UInt16 PortNumber;

        public skbtProcessConfigTeamspeak(String exe, String pa, Boolean ka, String pr, String a, UInt16 pn) 
            : base(exe, pa, ka, pr, a)
        {
            PortNumber = pn;
        }
    }
}
