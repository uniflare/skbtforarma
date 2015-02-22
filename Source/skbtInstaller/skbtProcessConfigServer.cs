using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigServer : skbtProcessConfigBasic
    {
        public UInt16 Port;
        public String ConfigPathBasic;
        public String ConfigPathServer;
        public String ProfileName;
        public String ProfilePath;
        public String CommandLine;
        public String ModLine;
        public String LogFilePath;
        public String LogFileBackupPath;
        public Boolean UseZipLogs;

        public skbtProcessConfigServer(String exe, String pa, Boolean ka, String pr, String a, UInt16 po, String cb, String cs, String pn, String pp, String cl, String ml, String lp, String lf, Boolean uz) 
            : base(exe, pa, ka, pr, a)
        {
            Port = po;
            ConfigPathBasic = cb;
            ConfigPathServer = cs;
            ProfileName = pn;
            ProfilePath = pp;
            CommandLine = cl;
            ModLine = ml;
            LogFilePath = lp;
            LogFileBackupPath = lf;
            UseZipLogs = uz;
        }
    }
}
