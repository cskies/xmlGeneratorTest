using System;
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
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select xml file";
            openFileDialog1.Filter = "XML files(*.xml) | *.xml";
            Console.WriteLine();
            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                
            }

            Console.WriteLine();
        }
    }
}
