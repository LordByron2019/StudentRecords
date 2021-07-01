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
    public partial class StudentMak : Form
    {

        public string _studentName;

        public int _assignment1;

        public int _assignment2;

        public int _assignment3;

        public int _assignment4;

        public int _midtermExam;

        public int _finalExam;



        public StudentMak()
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

        private int calculateMark()
        {
            int ass1 = this._assignment1 / 10;

            int ass2 = this._assignment2 / 10;

            int ass3 = this._assignment3 / 10;

            int ass4 = (this._assignment1 * 2) / 10;

            int mid = (this._midtermExam * 2) / 10;

            int final = (this._finalExam * 3) / 10;

            return ass1 + ass2 + ass3 + ass4 + mid + final;
        }

        private void clearInputs(){
            assignment1.Text = "";
            assignment2.Text = "";
            assignment3.Text = "";
            assignment4.Text = "";
            finalExam.Text = "";
            medtermExam.Text = "";
            StudentName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult res = MessageBox.Show(this._studentName + ":\t" + calculateMark(), "Save mark?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);  
            if (res == DialogResult.OK) {  
                this.createRecordText(calculateMark());  
                MessageBox.Show(this._studentName + "'s mark saved successfully!", "Success" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
                //Clear all textBoxes
                clearInputs();
            } 

            if (res == DialogResult.Cancel) {  
                MessageBox.Show("Mark not saved!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            this._studentName = objTextBox.Text;

        }

        private void finalExam_TextChanged(object sender, EventArgs e)
        {

            TextBox objTextBox = (TextBox)sender;

            this._finalExam = inputParser(objTextBox);

        }

        private void assignment4_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            this._assignment4 = inputParser(objTextBox);
        }


        private void assignment3_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            this._assignment3 = inputParser(objTextBox);
        }

        private void assignment2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            this._assignment2 = inputParser(objTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void assignment1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            this._assignment1 = inputParser(objTextBox);
        }
    
        private void medtermExam_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            this._midtermExam = inputParser(objTextBox);
        }


        public static void WriteFile()
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
        }

        
        private int inputParser(TextBox input)
        {
            int parsedValue;

            if (!int.TryParse(input.Text, out parsedValue) && !(input.Text == ""))
            {
                MessageBox.Show("This is a number only field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (parsedValue > 20 || parsedValue < 0)
            {
                MessageBox.Show("This field except only numbers between 0 and 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


          

            return parsedValue;
        }
        

        public void createRecordText(int finalMark)
        {
            string[] lines =
            {
                this._studentName + ":\t\t" + finalMark + "\n",
            };

            string path = @"C:\CMIS214\StudentMarks.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.AppendAllLines(path, lines);
            }
            else
            {
                TextWriter writer = new StreamWriter(path, true);
                writer.WriteLine(lines[0]);
                writer.Flush();
                writer.Close();
            }
            
        }

        private void student_name_Click(object sender, EventArgs e)
        {

        }

        private void SeeMark_Click(object sender, EventArgs e)
        {
            //Show File content in new window
            ShowMarks showMarks = new ShowMarks();
            showMarks.Show();

        }
    }
}