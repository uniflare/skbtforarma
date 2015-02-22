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

        public skbtProcessConfigBEC(String exe, String pa, Boolean ka, String pr, String a, String BEPath) 
            : base(exe, pa, ka, pr, a)
        {
            this.BEPath = BEPath;
        }
    }
}
