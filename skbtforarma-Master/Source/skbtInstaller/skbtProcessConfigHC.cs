using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigHC : skbtProcessConfigBasic
    {
        public String LaunchParams;

        public skbtProcessConfigHC(String exe, String pa, Boolean ka, String pr, String a, String lp) 
            : base(exe, pa, ka, pr, a)
        {
            LaunchParams = lp;
        }
    }
}
