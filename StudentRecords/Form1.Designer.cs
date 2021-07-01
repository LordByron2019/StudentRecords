namespace StudentRecords
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignment2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assignment3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assignment4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.medtermExam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Assignment#1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Assignment#2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // assignment2
            // 
            this.assignment2.Location = new System.Drawing.Point(507, 200);
            this.assignment2.Name = "assignment2";
            this.assignment2.Size = new System.Drawing.Size(230, 20);
            this.assignment2.TabIndex = 8;
            this.assignment2.TextChanged += new System.EventHandler(this.assignment2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Assignment#3";
            // 
            // assignment3
            // 
            this.assignment3.Location = new System.Drawing.Point(167, 283);
            this.assignment3.Name = "assignment3";
            this.assignment3.Size = new System.Drawing.Size(230, 20);
            this.assignment3.TabIndex = 10;
            this.assignment3.TextChanged += new System.EventHandler(this.assignment3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Assignment#4";
            // 
            // assignment4
            // 
            this.assignment4.Location = new System.Drawing.Point(507, 283);
            this.assignment4.Name = "assignment4";
            this.assignment4.Size = new System.Drawing.Size(230, 20);
            this.assignment4.TabIndex = 12;
            this.assignment4.TextChanged += new System.EventHandler(this.assignment4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Midterm Exam";
            // 
            // medtermExam
            // 
            this.medtermExam.Location = new System.Drawing.Point(167, 364);
            this.medtermExam.Name = "medtermExam";
            this.medtermExam.Size = new System.Drawing.Size(230, 20);
            this.medtermExam.TabIndex = 14;
            this.medtermExam.TextChanged += new System.EventHandler(this.medtermExam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Final Exam";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 555);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finalExam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medtermExam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assignment4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assignment3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignment2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignment1);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StudentName);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assignment2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assignment3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assignment4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medtermExam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finalExam;
        private System.Windows.Forms.Button savebtn;
    }
}

