namespace LawyerOffice
{
    partial class Lawyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            panel1 = new Panel();
            dataGridViewLawyer = new DataGridView();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            idOfLawyertb = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            lawyersurnametb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            lawyernametb = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            lawyerspecializationtb = new TextBox();
            label11 = new Label();
            lawyersalary = new TextBox();
            panelGridForLawyer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLawyer).BeginInit();
            panel2.SuspendLayout();
            panelGridForLawyer.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(288, 20);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Lawyer Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 60);
            panel1.TabIndex = 52;
            // 
            // dataGridViewLawyer
            // 
            dataGridViewLawyer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLawyer.Location = new Point(78, 16);
            dataGridViewLawyer.Name = "dataGridViewLawyer";
            dataGridViewLawyer.RowTemplate.Height = 25;
            dataGridViewLawyer.Size = new Size(543, 200);
            dataGridViewLawyer.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(idOfLawyertb);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lawyersurnametb);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lawyernametb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lawyerspecializationtb);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lawyersalary);
            panel2.Location = new Point(1, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 152);
            panel2.TabIndex = 53;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(457, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(222, 19);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "check if you want to delete or update";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // idOfLawyertb
            // 
            idOfLawyertb.Location = new Point(98, 25);
            idOfLawyertb.Name = "idOfLawyertb";
            idOfLawyertb.Size = new Size(126, 23);
            idOfLawyertb.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 35;
            label1.Text = "Id: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 40, 45);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(693, 10);
            panel4.TabIndex = 34;
            // 
            // lawyersurnametb
            // 
            lawyersurnametb.Location = new Point(296, 53);
            lawyersurnametb.Name = "lawyersurnametb";
            lawyersurnametb.Size = new Size(126, 23);
            lawyersurnametb.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(612, 122);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(607, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(439, 122);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(526, 122);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(249, 99);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 31;
            label8.Text = "Salary:";
            // 
            // lawyernametb
            // 
            lawyernametb.Location = new Point(98, 58);
            lawyernametb.Name = "lawyernametb";
            lawyernametb.Size = new Size(126, 23);
            lawyernametb.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 92);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 30;
            label9.Text = "Specialization:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(457, 53);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(144, 23);
            textBox9.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(234, 61);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 29;
            label10.Text = "Surname:";
            // 
            // lawyerspecializationtb
            // 
            lawyerspecializationtb.Location = new Point(98, 89);
            lawyerspecializationtb.Name = "lawyerspecializationtb";
            lawyerspecializationtb.Size = new Size(126, 23);
            lawyerspecializationtb.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(51, 61);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 28;
            label11.Text = "Name:";
            // 
            // lawyersalary
            // 
            lawyersalary.Location = new Point(296, 96);
            lawyersalary.Name = "lawyersalary";
            lawyersalary.Size = new Size(126, 23);
            lawyersalary.TabIndex = 27;
            // 
            // panelGridForLawyer
            // 
            panelGridForLawyer.BackColor = Color.GhostWhite;
            panelGridForLawyer.Controls.Add(dataGridViewLawyer);
            panelGridForLawyer.Location = new Point(4, 63);
            panelGridForLawyer.Margin = new Padding(0);
            panelGridForLawyer.Name = "panelGridForLawyer";
            panelGridForLawyer.Padding = new Padding(0, 0, 0, 2);
            panelGridForLawyer.Size = new Size(697, 233);
            panelGridForLawyer.TabIndex = 54;
            // 
            // Lawyer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 456);
            Controls.Add(panelGridForLawyer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Lawyer";
            Text = "Lawyer";
            Load += Lawyer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLawyer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGridForLawyer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private DataGridView dataGridViewLawyer;
        private Panel panel2;
        private Panel panel4;
        private TextBox lawyersurnametb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label8;
        private TextBox lawyernametb;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox lawyerspecializationtb;
        private Label label11;
        private TextBox lawyersalary;
        private TextBox idOfLawyertb;
        private Label label1;
        private CheckBox checkBox1;
        private Panel panelGridForLawyer;
    }
}