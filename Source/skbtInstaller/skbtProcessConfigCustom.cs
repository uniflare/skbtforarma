using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigCustom : skbtProcessConfigBasic
    {
        public String LaunchParams;
        public String Name;
        public short ID;

        public skbtProcessConfigCustom(String exe, String pa, Boolean ka, String pr, String a, short id, String n, String lp)
            : base(exe, pa, ka, pr, a)
        {
            ID = id;
            Name = n;
            LaunchParams = lp;
        }
    }
}
