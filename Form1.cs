using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace XmlGenerator
{
    public partial class FrmxmlOpenTest : Form
    {
        public FrmxmlOpenTest()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            //TODO: Conrado - Organize structure
            //transfer the logic below to a class diff this event. ie: another class outside this("presentation") proj

            fileXml.Title = "Select xml file";
            fileXml.Filter = "XML files(*.xml) | *.xml";

            if (fileXml.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(fileXml.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                //this.Cursor = new Cursor(fileXml.OpenFile());

                //sr.Close();

                var ds = new DataSet();
                ds.ReadXml(sr);
                ds.WriteXmlSchema("Books50.xsd");
                Console.WriteLine();
                this.Close();
            }
        }

        void ConnectionSql()
        {
            //set conn
            var myConnection = new SqlConnection("user id=AdminAuditorBPO ;" +
                                       "password=FMxYaKGC;server=SJCSRVVMDEV01;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Auditor_WHIRLPOOL; " +
                                       "connection timeout=30");

            //open conn
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.WriteLine();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// TODO: Conrado - step after save xlm in db. Is necessary to generate report.
        /// Probably in pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
