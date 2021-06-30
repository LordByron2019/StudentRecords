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
    public partial class Form1 : Form
    {

        public string _studentName;

        public int _assignment1;

        public int _assignment2;

        public int _assignment3;

        public int _assignment4;

        public int _midtermExam;

        public int _finalExam;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*int parsedValue;

            TextBox objTextBox = (TextBox)sender;
            if (!int.TryParse(objTextBox.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            MessageBox.Show(this._studentName);*/

            //this.createRecordText();


        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            this._studentName = objTextBox.Text;

        }

        private void finalExam_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void assignment3_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignment2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void assignment1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void medtermExam_TextChanged(object sender, EventArgs e)
        {

        }


        /*public static void WriteFile()
        {
            string path = @"c:\temp\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }*/


        public void createRecordText()
        {
            string[] lines =
            {
                "First line", "Second line", "Third line"
            };

            //SaveFileDialog emplacement = new SaveFileDialog();

            //emplacement.

            string path = @"d:\MyTest.txt";

            File.AppendAllLines(path, lines);
        }
    }
}