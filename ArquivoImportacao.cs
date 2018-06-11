using System.Data;
using System.Xml.Linq;

/// <summary>
/// Class used for import files w/ xml extension
/// then a report will be generated
/// </summary>
namespace XmlGenerator
{
    public class ArquivoImportacao
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int MyProperty { get; set; }


        
        void LoadXmlFile()
        {
            XDocument doc;
        }

        



        public DataTable LoadData()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("xmltest.xml");
            return dataSet.Tables[0];
        }

    }
}
