using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XmlGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            XDocument doc = XDocument.Load("books.xml");
            var authors = doc.Descendants("Author");

            foreach (var author in authors)
            {
                Console.WriteLine(author.Value);
            }

            Console.ReadLine();

        }
    }
}
