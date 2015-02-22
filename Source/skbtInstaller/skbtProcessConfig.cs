using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigBasic
    {
        public String EXEFile;
        public String Path;
        public Boolean Keepalive;
        public String Priority;
        public String Affinity;

        public skbtProcessConfigBasic(String exe, String pa, Boolean ka, String pr, String a)
        {
            EXEFile = exe;
            Path = pa;
            Keepalive = ka;
            Priority = pr;
            Affinity = a;
        }
    }
}
