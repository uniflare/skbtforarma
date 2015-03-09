using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigBEC : skbtProcessConfigBasic
    {
        public String BEPath;
        public Boolean useDSC;

        public skbtProcessConfigBEC(String exe, String pa, Boolean ka, String pr, String a, String BEPath, Boolean d) 
            : base(exe, pa, ka, pr, a)
        {
            this.BEPath = BEPath;
            this.useDSC = d;
        }
    }
}
