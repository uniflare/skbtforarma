using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{

    /*  class skbtServerMeta
     * 
     * Holds MetaData for the Application about a Server config Object.
     */
    public class skbtServerMeta
    {
        public String Identifier
        { get; private set; }
        public String textualName;
        public Boolean isInstalled;
        public String PathToEXE;
        public String PathToConfig;

        public skbtServerMeta(String i, String t, String pte, String ptc, Boolean ii)
        {
            Identifier = i;
            textualName = t;
            PathToEXE = pte;
            PathToConfig = ptc;
            isInstalled = ii;
        }
    }
}
;