namespace LawyerOffice
{
    partial class Cases
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
            panel2 = new Panel();
            label1 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            clientIdLabel = new Label();
            clientidtb = new TextBox();
            lawyernamecb = new ComboBox();
            label = new Label();
            startdatest = new DateTimePicker();
            statuscasecb = new ComboBox();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox9 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dataGridViewCase = new DataGridView();
            panelGrid = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCase).BeginInit();
            panelGrid.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(clientIdLabel);
            panel2.Controls.Add(clientidtb);
            panel2.Controls.Add(lawyernamecb);
            panel2.Controls.Add(label);
            panel2.Controls.Add(startdatest);
            panel2.Controls.Add(statuscasecb);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(1, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 152);
            panel2.TabIndex = 56;
            panel2.Click += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 44;
            label1.Text = "Case Id:";
            label1.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(457, 68);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 19);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Do you want to delete";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(457, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 19);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Do you want to update";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new Point(44, 20);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new Size(54, 15);
            clientIdLabel.TabIndex = 40;
            clientIdLabel.Text = "Client Id:";
            // 
            // clientidtb
            // 
            clientidtb.Location = new Point(123, 19);
            clientidtb.Name = "clientidtb";
            clientidtb.Size = new Size(116, 23);
            clientidtb.TabIndex = 39;
            // 
            // lawyernamecb
            // 
            lawyernamecb.FormattingEnabled = true;
            lawyernamecb.Location = new Point(123, 48);
            lawyernamecb.Name = "lawyernamecb";
            lawyernamecb.Size = new Size(164, 23);
            lawyernamecb.TabIndex = 38;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(18, 48);
            label.Name = "label";
            label.Size = new Size(81, 15);
            label.TabIndex = 37;
            label.Text = "Lawyer Name:";
            // 
            // startdatest
            // 
            startdatest.Location = new Point(123, 112);
            startdatest.Name = "startdatest";
            startdatest.Size = new Size(200, 23);
            startdatest.TabIndex = 36;
            // 
            // statuscasecb
            // 
            statuscasecb.FormattingEnabled = true;
            statuscasecb.Items.AddRange(new object[] { "Active ", "Pending ", "Close" });
            statuscasecb.Location = new Point(123, 82);
            statuscasecb.Name = "statuscasecb";
            statuscasecb.Size = new Size(164, 23);
            statuscasecb.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 40, 45);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(693, 10);
            panel4.TabIndex = 34;
            // 
            // button1
            // 
            button1.Location = new Point(607, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(607, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(434, 118);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(515, 118);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(457, 32);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(144, 23);
            textBox9.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 82);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 29;
            label10.Text = "Status Case:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(38, 118);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 28;
            label11.Text = "Start Date:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 60);
            panel1.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(288, 20);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Case Datas";
            // 
            // dataGridViewCase
            // 
            dataGridViewCase.Location = new Point(86, 21);
            dataGridViewCase.Name = "dataGridViewCase";
            dataGridViewCase.RowTemplate.Height = 25;
            dataGridViewCase.Size = new Size(541, 198);
            dataGridViewCase.TabIndex = 54;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.GhostWhite;
            panelGrid.Controls.Add(dataGridViewCase);
            panelGrid.Location = new Point(4, 64);
            panelGrid.Margin = new Padding(0);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(0, 0, 0, 2);
            panelGrid.Size = new Size(693, 236);
            panelGrid.TabIndex = 57;
            // 
            // Cases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 454);
            Controls.Add(panelGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Cases";
            Text = "Cases";
            Load += Cases_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCase).EndInit();
            panelGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker startdatest;
        private ComboBox statuscasecb;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Label label2;
        private DataGridView dataGridViewCase;
        private ComboBox lawyernamecb;
        private Label label;
        private Label clientIdLabel;
        private TextBox clientidtb;
        private CheckBox checkBox1;
        private Panel panelGrid;
        private CheckBox checkBox2;
        private Label label1;
    }
}