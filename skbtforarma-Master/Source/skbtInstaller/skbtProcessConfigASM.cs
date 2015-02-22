using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigASM : skbtProcessConfigBasic
    {
        public String LogFileName;
        public UInt16 LogInterval;

        public skbtProcessConfigASM(String exe, String pa, Boolean ka, String pr, String a, String lf, UInt16 li) 
            : base(exe, pa, ka, pr, a)
        {
            LogFileName = lf;
            LogInterval = li;
        }
    }
}
