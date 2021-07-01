namespace StudentRecords
{
    partial class StudentMak
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.assignment1 = new System.Windows.Forms.TextBox();
            this.ass1 = new System.Windows.Forms.Label();
            this.ass2 = new System.Windows.Forms.Label();
            this.assignment2 = new System.Windows.Forms.TextBox();
            this.ass3 = new System.Windows.Forms.Label();
            this.assignment3 = new System.Windows.Forms.TextBox();
            this.ass4 = new System.Windows.Forms.Label();
            this.assignment4 = new System.Windows.Forms.TextBox();
            this.midterm = new System.Windows.Forms.Label();
            this.medtermExam = new System.Windows.Forms.TextBox();
            this.finalex = new System.Windows.Forms.Label();
            this.finalExam = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(248, 127);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(377, 20);
            this.StudentName.TabIndex = 0;
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.No;
            this.Title.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Title.Location = new System.Drawing.Point(196, 18);
            this.Title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(5);
            this.Title.Size = new System.Drawing.Size(473, 55);
            this.Title.TabIndex = 4;
            this.Title.Text = "Record a student marks";
            this.Title.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Cursor = System.Windows.Forms.Cursors.No;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(244, 91);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(153, 24);
            this.student_name.TabIndex = 5;
            this.student_name.Text = "Student\'s Name :";
            // 
            // assignment1
            // 
            this.assignment1.Location = new System.Drawing.Point(167, 200);
            this.assignment1.Name = "assignment1";
            this.assignment1.Size = new System.Drawing.Size(230, 20);
            this.assignment1.TabIndex = 6;
            this.assignment1.TextChanged += new System.EventHandler(this.assignment1_TextChanged);
            // 
            // ass1
            // 
            this.ass1.AutoSize = true;
            this.ass1.Cursor = System.Windows.Forms.Cursors.No;
            this.ass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ass1.Location = new System.Drawing.Point(166, 171);
            this.ass1.Name = "ass1";
            this.ass1.Size = new System.Drawing.Size(111, 20);
            this.ass1.TabIndex = 7;
            this.ass1.Text = "Assignment#1";
            this.ass1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ass2
            // 
            this.ass2.AutoSize = true;
            this.ass2.Cursor = System.Windows.Forms.Cursors.No;
            this.ass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ass2.Location = new System.Drawing.Point(507, 171);
            this.ass2.Name = "ass2";
            this.ass2.Size = new System.Drawing.Size(111, 20);
            this.ass2.TabIndex = 9;
            this.ass2.Text = "Assignment#2";
            this.ass2.Click += new System.EventHandler(this.label2_Click);
            // 
            // assignment2
            // 
            this.assignment2.Location = new System.Drawing.Point(507, 200);
            this.assignment2.Name = "assignment2";
            this.assignment2.Size = new System.Drawing.Size(230, 20);
            this.assignment2.TabIndex = 8;
            this.assignment2.TextChanged += new System.EventHandler(this.assignment2_TextChanged);
            // 
            // ass3
            // 
            this.ass3.AutoSize = true;
            this.ass3.Cursor = System.Windows.Forms.Cursors.No;
            this.ass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ass3.Location = new System.Drawing.Point(167, 254);
            this.ass3.Name = "ass3";
            this.ass3.Size = new System.Drawing.Size(111, 20);
            this.ass3.TabIndex = 11;
            this.ass3.Text = "Assignment#3";
            // 
            // assignment3
            // 
            this.assignment3.Location = new System.Drawing.Point(167, 283);
            this.assignment3.Name = "assignment3";
            this.assignment3.Size = new System.Drawing.Size(230, 20);
            this.assignment3.TabIndex = 10;
            this.assignment3.TextChanged += new System.EventHandler(this.assignment3_TextChanged);
            // 
            // ass4
            // 
            this.ass4.AutoSize = true;
            this.ass4.Cursor = System.Windows.Forms.Cursors.No;
            this.ass4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ass4.Location = new System.Drawing.Point(507, 254);
            this.ass4.Name = "ass4";
            this.ass4.Size = new System.Drawing.Size(111, 20);
            this.ass4.TabIndex = 13;
            this.ass4.Text = "Assignment#4";
            // 
            // assignment4
            // 
            this.assignment4.Location = new System.Drawing.Point(507, 283);
            this.assignment4.Name = "assignment4";
            this.assignment4.Size = new System.Drawing.Size(230, 20);
            this.assignment4.TabIndex = 12;
            this.assignment4.TextChanged += new System.EventHandler(this.assignment4_TextChanged);
            // 
            // midterm
            // 
            this.midterm.AutoSize = true;
            this.midterm.Cursor = System.Windows.Forms.Cursors.No;
            this.midterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midterm.Location = new System.Drawing.Point(167, 335);
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(110, 20);
            this.midterm.TabIndex = 15;
            this.midterm.Text = "Midterm Exam";
            // 
            // medtermExam
            // 
            this.medtermExam.Location = new System.Drawing.Point(167, 364);
            this.medtermExam.Name = "medtermExam";
            this.medtermExam.Size = new System.Drawing.Size(230, 20);
            this.medtermExam.TabIndex = 14;
            this.medtermExam.TextChanged += new System.EventHandler(this.medtermExam_TextChanged);
            // 
            // finalex
            // 
            this.finalex.AutoSize = true;
            this.finalex.Cursor = System.Windows.Forms.Cursors.No;
            this.finalex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalex.Location = new System.Drawing.Point(507, 335);
            this.finalex.Name = "finalex";
            this.finalex.Size = new System.Drawing.Size(87, 20);
            this.finalex.TabIndex = 17;
            this.finalex.Text = "Final Exam";
            // 
            // finalExam
            // 
            this.finalExam.Location = new System.Drawing.Point(507, 364);
            this.finalExam.Name = "finalExam";
            this.finalExam.Size = new System.Drawing.Size(230, 20);
            this.finalExam.TabIndex = 16;
            this.finalExam.TextChanged += new System.EventHandler(this.finalExam_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Green;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebtn.Location = new System.Drawing.Point(507, 458);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(230, 37);
            this.savebtn.TabIndex = 18;
            this.savebtn.Text = "Save Marks";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentMak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 555);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.finalex);
            this.Controls.Add(this.finalExam);
            this.Controls.Add(this.midterm);
            this.Controls.Add(this.medtermExam);
            this.Controls.Add(this.ass4);
            this.Controls.Add(this.assignment4);
            this.Controls.Add(this.ass3);
            this.Controls.Add(this.assignment3);
            this.Controls.Add(this.ass2);
            this.Controls.Add(this.assignment2);
            this.Controls.Add(this.ass1);
            this.Controls.Add(this.assignment1);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StudentName);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "StudentMak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "StudentRecords";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.TextBox assignment1;
        private System.Windows.Forms.Label ass1;
        private System.Windows.Forms.Label ass2;
        private System.Windows.Forms.TextBox assignment2;
        private System.Windows.Forms.Label ass3;
        private System.Windows.Forms.TextBox assignment3;
        private System.Windows.Forms.Label ass4;
        private System.Windows.Forms.TextBox assignment4;
        private System.Windows.Forms.Label midterm;
        private System.Windows.Forms.TextBox medtermExam;
        private System.Windows.Forms.Label finalex;
        private System.Windows.Forms.TextBox finalExam;
        private System.Windows.Forms.Button savebtn;
    }
}

