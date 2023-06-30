namespace LawyerOffice
{
    partial class Client
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
            searchbtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnumbertb = new TextBox();
            emailtb = new TextBox();
            addresstb = new TextBox();
            searchboxtb = new TextBox();
            surnametb = new TextBox();
            nametb = new TextBox();
            addbtn = new Button();
            panel1 = new Panel();
            panelGrid = new Panel();
            label2 = new Label();
            clientsPanel = new Panel();
            label1 = new Label();
            idOfClienttb = new TextBox();
            checkBox1 = new CheckBox();
            deletebtn = new Button();
            updatebtn = new Button();
            panel3 = new Panel();
            dataGridViewClient = new DataGridView();
            panelGridForClient = new Panel();
            panel1.SuspendLayout();
            clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            panelGridForClient.SuspendLayout();
            SuspendLayout();
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(612, 34);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 33;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(228, 52);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 32;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(228, 101);
            label6.Name = "label6";
            label6.Size = new Size(54, 44);
            label6.TabIndex = 31;
            label6.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(228, 83);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 30;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 99);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 29;
            label4.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 70);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 28;
            label3.Text = "Name:";
            // 
            // pnumbertb
            // 
            pnumbertb.Location = new Point(288, 112);
            pnumbertb.Name = "pnumbertb";
            pnumbertb.Size = new Size(126, 23);
            pnumbertb.TabIndex = 27;
            // 
            // emailtb
            // 
            emailtb.Location = new Point(285, 46);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(126, 23);
            emailtb.TabIndex = 26;
            // 
            // addresstb
            // 
            addresstb.Location = new Point(285, 80);
            addresstb.Name = "addresstb";
            addresstb.Size = new Size(126, 23);
            addresstb.TabIndex = 25;
            // 
            // searchboxtb
            // 
            searchboxtb.Location = new Point(462, 34);
            searchboxtb.Name = "searchboxtb";
            searchboxtb.Size = new Size(144, 23);
            searchboxtb.TabIndex = 24;
            // 
            // surnametb
            // 
            surnametb.Location = new Point(83, 99);
            surnametb.Name = "surnametb";
            surnametb.Size = new Size(126, 23);
            surnametb.TabIndex = 23;
            // 
            // nametb
            // 
            nametb.Location = new Point(83, 68);
            nametb.Name = "nametb";
            nametb.Size = new Size(126, 23);
            nametb.TabIndex = 22;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(604, 119);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(84, 23);
            addbtn.TabIndex = 19;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(panelGrid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 60);
            panel1.TabIndex = 34;
            // 
            // panelGrid
            // 
            panelGrid.Location = new Point(3, 66);
            panelGrid.Margin = new Padding(0);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(0, 0, 0, 2);
            panelGrid.Size = new Size(696, 222);
            panelGrid.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(288, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Clients Data";
            // 
            // clientsPanel
            // 
            clientsPanel.BackColor = Color.White;
            clientsPanel.Controls.Add(label1);
            clientsPanel.Controls.Add(idOfClienttb);
            clientsPanel.Controls.Add(checkBox1);
            clientsPanel.Controls.Add(deletebtn);
            clientsPanel.Controls.Add(updatebtn);
            clientsPanel.Controls.Add(panel3);
            clientsPanel.Controls.Add(surnametb);
            clientsPanel.Controls.Add(addbtn);
            clientsPanel.Controls.Add(searchbtn);
            clientsPanel.Controls.Add(label7);
            clientsPanel.Controls.Add(label6);
            clientsPanel.Controls.Add(nametb);
            clientsPanel.Controls.Add(label5);
            clientsPanel.Controls.Add(searchboxtb);
            clientsPanel.Controls.Add(label4);
            clientsPanel.Controls.Add(addresstb);
            clientsPanel.Controls.Add(label3);
            clientsPanel.Controls.Add(emailtb);
            clientsPanel.Controls.Add(pnumbertb);
            clientsPanel.Location = new Point(3, 292);
            clientsPanel.Name = "clientsPanel";
            clientsPanel.Size = new Size(700, 152);
            clientsPanel.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 43;
            label1.Text = "Id of Client:";
            // 
            // idOfClienttb
            // 
            idOfClienttb.Location = new Point(81, 36);
            idOfClienttb.Name = "idOfClienttb";
            idOfClienttb.Size = new Size(126, 23);
            idOfClienttb.TabIndex = 42;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 91);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(222, 19);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "check if you want to delete or update";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(520, 119);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(78, 23);
            deletebtn.TabIndex = 40;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(432, 119);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(82, 23);
            updatebtn.TabIndex = 39;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 40, 45);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(693, 10);
            panel3.TabIndex = 34;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.GridColor = Color.DarkGray;
            dataGridViewClient.Location = new Point(27, 15);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowTemplate.Height = 25;
            dataGridViewClient.Size = new Size(630, 188);
            dataGridViewClient.TabIndex = 36;
            // 
            // panelGridForClient
            // 
            panelGridForClient.BackColor = Color.GhostWhite;
            panelGridForClient.Controls.Add(dataGridViewClient);
            panelGridForClient.Location = new Point(6, 67);
            panelGridForClient.Margin = new Padding(0);
            panelGridForClient.Name = "panelGridForClient";
            panelGridForClient.Padding = new Padding(0, 0, 0, 2);
            panelGridForClient.Size = new Size(693, 222);
            panelGridForClient.TabIndex = 37;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 446);
            Controls.Add(panelGridForClient);
            Controls.Add(clientsPanel);
            Controls.Add(panel1);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            clientsPanel.ResumeLayout(false);
            clientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            panelGridForClient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button searchbtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox pnumbertb;
        private TextBox emailtb;
        private TextBox addresstb;
        private TextBox searchboxtb;
        private TextBox surnametb;
        private TextBox nametb;
        private Button addbtn;
        private Panel panel1;
        private Label label2;
        private Panel clientsPanel;
        private Panel panel3;
        private CheckBox checkBox1;
        private Button deletebtn;
        private Button updatebtn;
        private Label label1;
        private TextBox idOfClienttb;
        private Panel panelGrid;
        private DataGridView dataGridViewClient;
        private Panel panelGridForClient;
    }
}