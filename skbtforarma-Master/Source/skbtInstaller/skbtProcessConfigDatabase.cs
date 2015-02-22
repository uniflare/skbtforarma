using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skbtInstaller
{
    public class skbtProcessConfigDatabase : skbtProcessConfigBasic
    {
        public Boolean UseZipBackups;
        public String BackupFolder;
        public UInt32 DatabaseBackupInterval;
        public String DatabaseDumpFileName;
        public String DatabaseDumpFilePath;

        public skbtProcessConfigDatabase(String exe, String pa, Boolean ka, String pr, String a, Boolean uz, UInt32 bi, String bf, String df, String dp) 
            : base(exe, pa, ka, pr, a)
        {
            UseZipBackups = uz;
            DatabaseBackupInterval = bi;
            BackupFolder = bf;
            DatabaseDumpFileName = df;
            DatabaseDumpFilePath = dp;
        }
    }
}
