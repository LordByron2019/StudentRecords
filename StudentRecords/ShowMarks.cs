using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentRecords
{
    public partial class ShowMarks : Form
    {
        public ShowMarks()
        {
            InitializeComponent();
            
        }

        private void ShowMarks_Load(object sender, EventArgs e)
        {
            string path = @"C:\CMIS214\StudentMarks.txt";
            string marks = File.ReadAllText(path);


            marksText.Text = marks;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You can't edit this file. All modifications will be lose!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string path = @"C:\CMIS214\StudentMarks.txt";
            string marks = File.ReadAllText(path);
            marksText.Text = "";

            marksText.Text = marks;
        }
    }
}
