using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Media;
using System.Windows.Forms;

namespace USPSVerify
{
    class DBConnection
    {
        //public string mcdescription;
        public string indiciaversion;
        static string connstring;
        private bool online = false;

        Parser parsedata = new Parser();

        public DBConnection()
        {
            loadDB();
        }


        public void loadDB()            //Get DB location by prompting user
        {
            connstring = "Data source= " + Properties.Settings.Default.DBLocationSetting;
        }

        public bool DBSelfTest()
        {
            bool err = false;
            
            DataSet DBDataSet = new DataSet();

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @connstring + @";Jet OLEDB:Database Password=Penumbra;";

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Failed to connect to the USPS Verify Database!  Please ensure the database path is configured in SETTINGS, and that the appropriate Microsoft Access DB drivers are installed.", "Critical Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err = true;
            }
            finally
            {
                conn.Close();
            }

            return err;
        }


        //Connect to Access Database
        public DataSet ConnectToDB(string TableName, string SelectStatement)
        {
            string connectionString = "Data Source=tcp:sql2k801.discountasp.net; Initial Catalog=SQL2008_790582_pensec;User ID=SQL2008_790582_pensec_user;Password=225573md;";

            DataSet DBDataSet = new DataSet();

            if (!online)
            {
                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @connstring + @";Jet OLEDB:Database Password=Penumbra;";
                //conn.ConnectionString = @"Provider=Micorsoft.ACE.OLEDB" + @connstring + @";Jet OLEDB:Database Password=Penumbra;";
                try
                {
                    conn.Open();

                    OleDbCommand AccessCmd = new OleDbCommand(SelectStatement, conn);
                    OleDbDataAdapter ProviderDataAdapter = new OleDbDataAdapter(AccessCmd);
                    ProviderDataAdapter.Fill(DBDataSet, TableName);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Failed to connect to local data source: " + ex.ToString());
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Failed to connect to the USPS Verify Database!  Please ensure the database path is configured in SETTINGS, and that the appropriate Microsoft Access DB drivers are installed.", "Critical Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    SqlDataAdapter myadapter = new SqlDataAdapter(SelectStatement, conn);

                    myadapter.Fill(DBDataSet, TableName);
                }
                catch (Exception ex)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Failed to connect to online data source, please check your Internet connection! " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }

            return (DBDataSet);
        }

        //Determines the Provider Name
        public string getProviderName(byte[] data, char indiciaType)  
        {
            char c;
            string PName = "";
            string getProviders = "SELECT * FROM Providers";

            DataSet ProviderDataSet = ConnectToDB("Providers", getProviders); //Create DataSet of Providers
            DataTable ProviderList = ProviderDataSet.Tables["Providers"];
            
            System.Text.StringBuilder vendorID = new System.Text.StringBuilder();

            if (indiciaType == 'f')             //IBI-FULL
            {
                c = (Char)data[6];                  //Get Provider ID
                vendorID.Append(c.ToString());
                
                c = (Char)data[7];
                vendorID.Append(c.ToString());
                
            }
            else if (indiciaType == 'y')        //IBI/IMI Hybrid (PSD Farm)
            {
                c = (Char)data[2];                  //Get Provider ID
                vendorID.Append(c.ToString());

                c = (Char)data[3];
                vendorID.Append(c.ToString());
            }
            else if (indiciaType == 'w')        //Withdrawal
            {
                c = (Char)data[0];                  //Get Provider ID
                vendorID.Append(c.ToString());

                c = (Char)data[1];
                vendorID.Append(c.ToString());
            }
            else if (indiciaType == 'l' && (!indiciaversion.ToString().Equals("ForeverPoD")))        //IBI-LITE but not Forever PoD
            {
                vendorID.Append("0");
               
                vendorID.Append(parsedata.parseHex(5, 6, data).ToString());
                vendorID.Remove(2,1);
            }
            else if (indiciaType == 'l' && (indiciaversion.ToString().Equals("ForeverPoD")))        //IBI-LITE but not Forever PoD
            {
                vendorID.Append("0");

                vendorID.Append(parsedata.parseHex(6, 7, data).ToString());
                vendorID.Remove(2, 1);
            }
            else                    // Must be IMI compliant
            {
                c = (Char)data[1];                  //Get Provider ID
                vendorID.Append(c.ToString());

                c = (Char)data[2];
                vendorID.Append(c.ToString());
            }

            if (ProviderDataSet != null)                
            {
                DataRow r = ProviderList.Rows[0];

                for (int i = 0; i < ProviderList.Rows.Count; i++)
                {
                    r = ProviderDataSet.Tables["Providers"].Rows[i];
                    
                    if (vendorID.ToString().Equals(r["ID"]))  //Search Provider ID from DB
                        PName = (string)r["ProviderName"];    
                }
            }

            return (PName.ToString()); //Return Provider Name
            
        }

        //Determines the IBI Version per Data Dictionary
        public string getIBIVersion(byte[] data, ref char type)
        {
            char c;

            System.Text.StringBuilder ibiVersion = new System.Text.StringBuilder();

            if (type != 'w')
            {
                //Determine IBI-Version <IBIVersion><ProviderID><Model ID>
                if (parsedata.parseDec(0, 1, data) < 10)  //If less than 10 then a zero must be appended to the string
                {
                    ibiVersion.Append("0");
                    ibiVersion.Append(parsedata.parseDec(0, 1, data).ToString());    //Begin Indicia Version String
                }
                else
                    ibiVersion.Append(parsedata.parseDec(0, 1, data).ToString());

                //If IBI-Version is 255 then it is an IBI-Lite Indicia i.e. 255XX
                /*if (ibiVersion.ToString() == "255" || ibiVersion.ToString() == "140" || ibiVersion.ToString() == "141" || ibiVersion.ToString() == "145") //Check for IBI-Lite or Forever PoD
                {
                    indiciaversion = ibiVersion.ToString();     //Store indicia version to ascertain IBI or IMI
                    ibiVersion.Append(parsedata.parseDec(5, 6, data).ToString());  //Append Provider ID
                }*/

                //If IBI-Version is >99 then it is an IMI or IBI-Lite
                if (parsedata.parseDec(0, 1, data) > 99) //Check for IMI Versions
                {
                    indiciaversion = getiVersion(ibiVersion.ToString());     //Store indicia version to ascertain IBI or IMI

                    //if(ibiVersion.ToString() == "255")
                    if (type == 'l' && (!ibiVersion.ToString().Equals("141")))
                        ibiVersion.Append(parsedata.parseDec(5, 6, data).ToString());  //Append Provider ID
                    else if (type == 'l' && (ibiVersion.ToString().Equals("141")))
                        ibiVersion.Append(parsedata.parseDec(6, 7, data).ToString());  //Append Provider ID
                    else
                        type = 'x';             //set type to x if IMI-STD, MIN or MAX
                }
                else
                {

                    indiciaversion = "IBI-FULL";        //Store indicia version to ascertain IBI or IMI
                    if (type != 'y')
                    {
                        c = (Char)data[6];                  //Append Provider ID
                        ibiVersion.Append(c.ToString());
                        c = (Char)data[7];
                        ibiVersion.Append(c.ToString());

                        c = (Char)data[8];                  //Append Model ID
                        ibiVersion.Append(parsedata.parseAscii(8, 10, data).ToString());
                    }
                    else                                                       //NEW CODE OCT 1 2013 for 107 byte IOP PSD Farm Hybrid Indicia
                    {
                        c = (Char)data[2];                  //Append Provider ID
                        ibiVersion.Append(c.ToString());
                        c = (Char)data[3];
                        ibiVersion.Append(c.ToString());

                        c = (Char)data[4];                  //Append Model ID
                        ibiVersion.Append(parsedata.parseAscii(4, 6, data).ToString());
                    }
                }
            }
            else
            {
                ibiVersion.Append("999");
                indiciaversion = "WITHDRAWAL";
            }

            return(ibiVersion.ToString()); //Return IBI Version per Data Dictionary
        }

        //Determines the Data Mapping per IBI Version
        public int getIBIDataMap(string IBIVersion, ref string[] DataValue, ref string[] DataFields)
        {
            int j = 0;
            int count = 0;      //Column count
            
            string getIBIData = "SELECT * FROM IBIData";

            DataSet IBIDataSet = ConnectToDB("IBIData", getIBIData); //Create DataSet
            DataTable IBIData = IBIDataSet.Tables["IBIData"];
            DataRow r;

            if (IBIDataSet != null)
            {
                for (int i = 0; i < IBIData.Rows.Count; i++)
                {
                    r = IBIData.Rows[i];
                    if (IBIVersion.ToString().Equals(r["ID2"]))    //Search IBIVersion from DB
                    {                        
                        foreach (DataColumn column in IBIData.Columns)      //Iterate through columns
                        {
                            if (r[column].ToString() != "0")
                            {
                                if (j > 1)              //Insures that the first two columns are ignored
                                {
                                    DataFields[count] = IBIData.Columns[j].ColumnName.ToString();
                                    DataValue[count] = r[column].ToString();
                                    count++;            //Count the columns that have data assigned
                                }
                            }
                            j++;
                        }
                    }
                    
                }
            }
            else
                return (-2);
            

            return (count - 1);                     // Ignore last column or returns -1 for not found
        }

        public int getIMIDataMap(ref string[] DataValue, ref string[] DataFields, int bufferlength)
        {
            int j = 0;
            int count = 0;      //Column count

            string getIMIData = "SELECT * FROM IMIData";

            DataSet IMIDataSet = ConnectToDB("IMIData", getIMIData); //Create DataSet
            DataTable IMIData = IMIDataSet.Tables["IMIData"];
            DataRow r;

            if (IMIDataSet != null)
            {
                for (int i = 0; i < IMIData.Rows.Count; i++)
                {
                    r = IMIData.Rows[i];
                    if (indiciaversion.ToString().Equals(r["ID2"]) && bufferlength.ToString().Equals(r["Total"]))    //Search IMIVersion from DB
                    {
                        foreach (DataColumn column in IMIData.Columns)      //Iterate through columns
                        {
                            if (r[column].ToString() != "0")
                            {
                                if (j > 1)              //Insures that the first two columns are ignored
                                {
                                    DataFields[count] = IMIData.Columns[j].ColumnName.ToString();
                                    DataValue[count] = r[column].ToString();
                                    count++;            //Count the columns that have data assigned
                                }
                            }
                            j++;
                        }
                    }

                }
            }
            else
                return (-2);


            return (count - 1);                     // Ignore last column
        }


        public int getWithdrawalDataMap(ref string[] DataValue, ref string[] DataFields, int bufferlength)
        {
            int j = 0;
            int count = 0;      //Column count

            string getWithdrawData = "SELECT * FROM IMIWithdrawal";

            DataSet WithdrawalDataSet = ConnectToDB("IMIWithdrawal", getWithdrawData); //Create DataSet
            DataTable WData = WithdrawalDataSet.Tables["IMIWithdrawal"];
            DataRow r;

            if (WithdrawalDataSet != null)
            {
                for (int i = 0; i < WData.Rows.Count; i++)
                {
                    r = WData.Rows[i];
                    if (indiciaversion.ToString().Equals(r["ID2"]))    //Search correct record from DB
                    {
                        foreach (DataColumn column in WData.Columns)      //Iterate through columns
                        {
                            if (r[column].ToString() != "0")
                            {
                                if (j > 1)              //Insures that the first two columns are ignored
                                {
                                    DataFields[count] = WData.Columns[j].ColumnName.ToString();
                                    DataValue[count] = r[column].ToString();
                                    count++;            //Count the columns that have data assigned
                                }
                            }
                            j++;
                        }
                    }

                }
            }
            else
                return (-2);


            return (count - 1);                     // Ignore last column
        }







        // Attempts to find closest match within the DB
        public int getIBIDataDefault(ref string[] DataValue, ref string[] DataFields, int bufsize)
        {
            int j = 0;
            int count = 0;      //Column count

            string getIBIData = "SELECT * FROM IBIData";

            DataSet IBIDataSet = ConnectToDB("IBIData", getIBIData); //Create DataSet
            DataTable IBIData = IBIDataSet.Tables["IBIData"];
            DataRow r;

            if (IBIDataSet != null)
            {
                //DataRow r = IBIData.Rows[0];                //Load first row

                for (int i = 0; i < IBIData.Rows.Count; i++)
                {
                    r = IBIData.Rows[i];

                    if (bufsize.ToString().Equals(r["ID2"]))    //Search closest match from DB
                    {
                        foreach (DataColumn column in IBIData.Columns)      //Iterate through columns
                        {
                            if (r[column].ToString() != "0")
                            {
                                if (j > 1)              //Insures that the first two columns are ignored
                                {
                                    DataFields[count] = IBIData.Columns[j].ColumnName.ToString();
                                    DataValue[count] = r[column].ToString();
                                    count++;            //Count the columns that have data assigned
                                }
                            }
                            j++;
                        }
                    }


                }

            }
            else
                return (-2);


            return (count - 1);                     // Ignore last column
        }

        // Attempts to find closest match within the DB
        public int getIMIDataDefault(ref string[] DataValue, ref string[] DataFields, int bufsize)
        {
            int j = 0;
            int count = 0;      //Column count

            string getIMIData = "SELECT * FROM IMIData";

            DataSet IMIDataSet = ConnectToDB("IMIData", getIMIData); //Create DataSet
            DataTable IMIData = IMIDataSet.Tables["IMIData"];
            DataRow r;

            if (IMIDataSet != null)
            {
                //DataRow r = IBIData.Rows[0];                //Load first row

                for (int i = 0; i < IMIData.Rows.Count; i++)
                {
                    r = IMIData.Rows[i];

                    if (bufsize.ToString().Equals(r["Total"]))    //Search closest match from DB
                    {
                        foreach (DataColumn column in IMIData.Columns)      //Iterate through columns
                        {
                            if (r[column].ToString() != "0")
                            {
                                if (j > 1)              //Insures that the first two columns are ignored
                                {
                                    DataFields[count] = IMIData.Columns[j].ColumnName.ToString();
                                    DataValue[count] = r[column].ToString();
                                    count++;            //Count the columns that have data assigned
                                }
                            }
                            j++;
                        }
                    }


                }

            }
            else
                return (-2);


            return (count - 1);                     // Ignore last column
        }


    //Determines the IVN
        private string getiVersion(string IVN)  
        {
            string iType = "";
            string getiVersion = "SELECT * FROM iVersion";

            DataSet IVNDataSet = ConnectToDB("iVersion", getiVersion); //Create DataSet of IVN
            DataTable IVNList = IVNDataSet.Tables["iVersion"];


            if (IVNDataSet != null)
            {
                DataRow r = IVNList.Rows[0];

                for (int i = 0; i < IVNList.Rows.Count; i++)
                {
                    r = IVNDataSet.Tables["iVersion"].Rows[i];

                    if (IVN.ToString().Equals(r["IVN"]))  //Search ID from DB
                        iType = (string)r["Type"];
                }
            }
            else
                iType = "Not Found";

            return (iType.ToString()); //Return iVersion
            
        }



        public string getMailClass(string MCID, ref string[] mcinfo, ref bool mcstatus)
        {
            string MCDesc = "";
            string MCPricing = "";
            string MCType = "";
            string getMC = "SELECT * FROM MailClass";
            bool active = true;
            bool found = false;

            DataSet MCDataSet = ConnectToDB("MailClass", getMC); //Create DataSet of Mail Categories
            DataTable MailCodes = MCDataSet.Tables["MailClass"];

            System.Text.StringBuilder MCb = new System.Text.StringBuilder();

            if (MCDataSet != null)
            {
                DataRow r = MailCodes.Rows[0];

                for (int i = 0; i < MailCodes.Rows.Count - 1; ++i)
                {
                    if (MCID.Equals(r["ID"].ToString()))        //Search Mail Class from DB
                    {
                        mcinfo[1] = MCDesc = (string)r["Description"];
                        mcinfo[0] = MCType = (string)r["Type"];
                        mcinfo[2] = MCPricing = (string)r["Pricing"];
                        mcstatus = active = (bool)r["Active"];
                        found = true;
                        MCb.Append("Mail Class: " + MCType + "\n" + MCDesc + "\n\n" + "Pricing Type: " + MCPricing + "\n");
                    }

                    r = MCDataSet.Tables["MailClass"].Rows[i + 1];
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("DB Mail Class Table Error!", "DB Error");
                mcstatus = false;
            }

            if (!found)
            {
                MCb.Append("Mail Class Not Valid\n");

                if (!GlobalVar.RECORD)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("The Indicium Incorporates an Invalid Mail Class!", "Mail Class Error");
                }

                mcstatus = false;
            }
            else if (!active)
            {
                if (!GlobalVar.RECORD)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("The Indicium Incorporates an Invalid Mail Class!", "Mail Class Error");
                }

                MCb.Length = 0;
                MCb.Append("Mail Class Has Been Retired.\n");
                mcstatus = false;
            }

            return (MCb.ToString());                            //Return Mail Class

        }

        public string getMailClassHex(string MCID, ref string[] mcinfo, ref bool mcstatus)
        {
            string MCDesc = "";
            string MCPricing = "";
            string MCType = "";
            string getMC = "SELECT * FROM MailClass";
            bool found = false;
            bool active = true;

            DataSet MCDataSet = ConnectToDB("MailClass", getMC); //Create DataSet of Mail Categories
            DataTable MailCodes = MCDataSet.Tables["MailClass"];

            System.Text.StringBuilder MCb = new System.Text.StringBuilder();

            if (MCDataSet != null)
            {
                DataRow r = MailCodes.Rows[0];

                for (int i = 0; i < MailCodes.Rows.Count - 1; i++)
                {
                    if (MCID.Equals(r["HexID"].ToString()))        //Search Mail Class from DB
                    {
                        mcinfo[1] = MCDesc = (string)r["Description"];
                        mcinfo[0] = MCType = (string)r["Type"];
                        mcinfo[2] = MCPricing = (string)r["Pricing"];
                        mcstatus = active = (bool)r["Active"];
                        found = true;
                        MCb.Append("Mail Class: " + MCType + "\n" + MCDesc + "\n\n" + "Pricing Type: " + MCPricing + "\n");
                    }

                    r = MCDataSet.Tables["MailClass"].Rows[i + 1];
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("DB Mail Class Table Error!", "DB Error");
            }

            if (!found)
            {
                MCb.Append("Mail Class Not Valid\n");

                if (!GlobalVar.RECORD)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("The Indicium Incorporates an Invalid Mail Class!", "Mail Class Error");
                }

                mcstatus = false;
            }
            else if (!active)
            {
                if (!GlobalVar.RECORD)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("The Indicium Incorporates an Invalid Mail Class!", "Mail Class Error");
                }

                MCb.Length = 0;
                MCb.Append("Mail Class Has Been Retired.\n");
                mcstatus = false;
            }


            return (MCb.ToString());                            //Return Mail Class

        }


        //Connect to Server for Registration
        public DataSet ConnectToServer (string TableName, string SelectStatement)
        {
            string connectionString = "Data Source=tcp:sql2k801.discountasp.net; Initial Catalog=SQL2008_790582_pensec;User ID=SQL2008_790582_pensec_user;Password=225573md;";

            DataSet DBDataSet = new DataSet();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                SqlDataAdapter myadapter = new SqlDataAdapter(SelectStatement, conn);

                myadapter.Fill(DBDataSet, TableName);
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Failed to connect to registration server! " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            
            return (DBDataSet);
        }

    }
}
