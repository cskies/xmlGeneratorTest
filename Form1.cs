using System;
using System.IO;
using System.Windows.Forms;

namespace XmlGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //TODO: Conrado - Organize structure
            //transfer the logic below to a class diff this event. ie: another class outside this("presentation") proj


            /////////////////////////// app saved the xml file
            // Shows a dialog to select the xml file
            var file = new OpenFileDialog();
            file.Title = "Select xml file";
            file.Filter = "XML files(*.xml) | *.xml";
            Console.WriteLine();



            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                
            }

            Console.WriteLine();

            //File.Copy("C:\\Users\\conrado.moura\\Desktop\\books.xml", "C:\\Users\\conrado.moura\\Desktop\\books222.xml");
            var listagem = File.ReadAllText("C:\\Users\\conrado.moura\\Desktop\\7k.txt");
            Console.WriteLine();


        }
    }
}
