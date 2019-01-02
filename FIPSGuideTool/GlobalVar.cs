

namespace USPSVerify
{
    public static class GlobalVar
    {
        public const int SCANNERBUFFERSIZE = 400;           //Scanner Buffer = 400-bytes
        public const int INDICIABUFFERSIZE = 250;           //Indicia Buffer should be enough for 125 actual bytes
        public const string CONNECTIONSTRING = "Data Source=tcp:sql2k801.discountasp.net; Initial Catalog=SQL2008_790582_pensec;User ID=SQL2008_790582_pensec_user;Password=225573md;";
        public const string DBNAME = "USPSIndiciaDB V4.8.accdb";

        //ScanReport Vars
        public static bool SAVED = false;
        public static bool EXCEL = true;

        //MainForm General
        public static bool RECORD = false;
        public static int icount = 0;       //NEWF #1:PAIRING COUNTER 11/14/17


        //ErrorLogWindow
        public static bool ERRLOGSAVED = false;

        //Parser
        public static bool DATEERROR = false;
    }
}
