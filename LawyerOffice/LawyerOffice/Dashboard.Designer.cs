namespace LawyerOffice
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel6 = new Panel();
            clientbtn = new Button();
            panel3 = new Panel();
            lawyerbtn = new Button();
            panel4 = new Panel();
            casesbtn = new Button();
            moreContainer = new Panel();
            panel5 = new Panel();
            importbtn = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            moreTimer = new System.Windows.Forms.Timer(components);
            panel7 = new Panel();
            label2 = new Label();
            mainDashboardPanel = new Panel();
            DashboardPanel_cover = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            quotePanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel10 = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            moreContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            mainDashboardPanel.SuspendLayout();
            DashboardPanel_cover.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            quotePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(moreContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(200, 487);
            sidebar.MinimumSize = new Size(57, 487);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 487);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(9, 23);
            menuButton.Name = "menuButton";
            menuButton.Padding = new Padding(0, 10, 0, 10);
            menuButton.Size = new Size(32, 46);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 40, 45);
            panel6.Controls.Add(clientbtn);
            panel6.Location = new Point(3, 109);
            panel6.Name = "panel6";
            panel6.Size = new Size(199, 43);
            panel6.TabIndex = 5;
            // 
            // clientbtn
            // 
            clientbtn.FlatStyle = FlatStyle.Flat;
            clientbtn.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            clientbtn.ForeColor = SystemColors.Control;
            clientbtn.Image = (Image)resources.GetObject("clientbtn.Image");
            clientbtn.ImageAlign = ContentAlignment.MiddleLeft;
            clientbtn.Location = new Point(-3, -9);
            clientbtn.Name = "clientbtn";
            clientbtn.Padding = new Padding(5, 15, 0, 15);
            clientbtn.Size = new Size(227, 59);
            clientbtn.TabIndex = 4;
            clientbtn.Text = "                Client";
            clientbtn.TextAlign = ContentAlignment.MiddleLeft;
            clientbtn.UseVisualStyleBackColor = true;
            clientbtn.Click += clientbtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 40, 45);
            panel3.Controls.Add(lawyerbtn);
            panel3.Location = new Point(3, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 43);
            panel3.TabIndex = 2;
            // 
            // lawyerbtn
            // 
            lawyerbtn.FlatStyle = FlatStyle.Flat;
            lawyerbtn.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lawyerbtn.ForeColor = SystemColors.Control;
            lawyerbtn.Image = (Image)resources.GetObject("lawyerbtn.Image");
            lawyerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            lawyerbtn.Location = new Point(-3, -9);
            lawyerbtn.Name = "lawyerbtn";
            lawyerbtn.Padding = new Padding(5, 15, 0, 15);
            lawyerbtn.Size = new Size(224, 57);
            lawyerbtn.TabIndex = 1;
            lawyerbtn.Text = "                Lawyer";
            lawyerbtn.TextAlign = ContentAlignment.MiddleLeft;
            lawyerbtn.UseVisualStyleBackColor = true;
            lawyerbtn.Click += lawyerbtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 40, 45);
            panel4.Controls.Add(casesbtn);
            panel4.Location = new Point(3, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 43);
            panel4.TabIndex = 3;
            // 
            // casesbtn
            // 
            casesbtn.FlatStyle = FlatStyle.Flat;
            casesbtn.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            casesbtn.ForeColor = SystemColors.Control;
            casesbtn.Image = (Image)resources.GetObject("casesbtn.Image");
            casesbtn.ImageAlign = ContentAlignment.MiddleLeft;
            casesbtn.Location = new Point(-3, -9);
            casesbtn.Name = "casesbtn";
            casesbtn.Padding = new Padding(5, 15, 0, 15);
            casesbtn.Size = new Size(224, 59);
            casesbtn.TabIndex = 1;
            casesbtn.Text = "                Cases";
            casesbtn.TextAlign = ContentAlignment.MiddleLeft;
            casesbtn.UseVisualStyleBackColor = true;
            casesbtn.Click += casesbtn_Click;
            // 
            // moreContainer
            // 
            moreContainer.BackColor = Color.FromArgb(50, 55, 60);
            moreContainer.Controls.Add(panel5);
            moreContainer.Controls.Add(panel2);
            moreContainer.Location = new Point(3, 256);
            moreContainer.MaximumSize = new Size(197, 82);
            moreContainer.MinimumSize = new Size(197, 45);
            moreContainer.Name = "moreContainer";
            moreContainer.Size = new Size(197, 45);
            moreContainer.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 55, 60);
            panel5.Controls.Add(importbtn);
            panel5.Location = new Point(0, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 33);
            panel5.TabIndex = 2;
            // 
            // importbtn
            // 
            importbtn.FlatStyle = FlatStyle.Flat;
            importbtn.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            importbtn.ForeColor = SystemColors.Control;
            importbtn.Image = (Image)resources.GetObject("importbtn.Image");
            importbtn.ImageAlign = ContentAlignment.MiddleLeft;
            importbtn.Location = new Point(-3, -20);
            importbtn.Name = "importbtn";
            importbtn.Padding = new Padding(30, 15, 0, 15);
            importbtn.Size = new Size(227, 63);
            importbtn.TabIndex = 1;
            importbtn.Text = "            Import Excel";
            importbtn.TextAlign = ContentAlignment.MiddleLeft;
            importbtn.UseVisualStyleBackColor = true;
            importbtn.Click += importbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 40, 45);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 43);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, -16);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 15, 0, 15);
            button1.Size = new Size(224, 69);
            button1.TabIndex = 1;
            button1.Text = "                More";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(622, 42);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 6;
            label3.Text = "Lawyer Office";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // moreTimer
            // 
            moreTimer.Interval = 10;
            moreTimer.Tick += moreTimer_Tick;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(label2);
            panel7.Location = new Point(2, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(722, 66);
            panel7.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(5, 40, 45);
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "Lawyer Office";
            // 
            // mainDashboardPanel
            // 
            mainDashboardPanel.BackColor = SystemColors.Control;
            mainDashboardPanel.Controls.Add(DashboardPanel_cover);
            mainDashboardPanel.Location = new Point(206, 0);
            mainDashboardPanel.Name = "mainDashboardPanel";
            mainDashboardPanel.Size = new Size(728, 487);
            mainDashboardPanel.TabIndex = 3;
            // 
            // DashboardPanel_cover
            // 
            DashboardPanel_cover.BackColor = SystemColors.Control;
            DashboardPanel_cover.Controls.Add(panel9);
            DashboardPanel_cover.Controls.Add(panel7);
            DashboardPanel_cover.Controls.Add(panel8);
            DashboardPanel_cover.Location = new Point(2, 0);
            DashboardPanel_cover.Name = "DashboardPanel_cover";
            DashboardPanel_cover.Size = new Size(726, 484);
            DashboardPanel_cover.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(35, 40, 45);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(2, 413);
            panel9.Name = "panel9";
            panel9.Size = new Size(722, 67);
            panel9.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.Controls.Add(panel10);
            panel8.Location = new Point(2, 71);
            panel8.Name = "panel8";
            panel8.Size = new Size(722, 336);
            panel8.TabIndex = 3;
            // 
            // quotePanel
            // 
            quotePanel.BackColor = Color.FromArgb(35, 40, 45);
            quotePanel.Controls.Add(label6);
            quotePanel.Controls.Add(label5);
            quotePanel.Controls.Add(label4);
            quotePanel.Location = new Point(63, 3);
            quotePanel.Name = "quotePanel";
            quotePanel.Size = new Size(140, 481);
            quotePanel.TabIndex = 4;
            quotePanel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 197);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 2;
            label6.Text = "* * *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 44);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 1;
            label5.Text = "* * *";
            // 
            // label4
            // 
            label4.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 68);
            label4.Name = "label4";
            label4.Size = new Size(126, 113);
            label4.TabIndex = 0;
            label4.Text = "   \" Like skilled chess players, Deals lawyers are masters of seeing the next move \"";
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.white_logo;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(520, 342);
            panel10.Name = "panel10";
            panel10.Size = new Size(96, 64);
            panel10.TabIndex = 6;
            // 
            // Dashboard
            // 
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(935, 487);
            Controls.Add(sidebar);
            Controls.Add(quotePanel);
            Controls.Add(mainDashboardPanel);
            Name = "Dashboard";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            moreContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            mainDashboardPanel.ResumeLayout(false);
            DashboardPanel_cover.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            quotePanel.ResumeLayout(false);
            quotePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button lawyerbtn;
        private Panel panel4;
        private Button casesbtn;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel moreContainer;
        private Panel panel6;
        private Button clientbtn;
        private Panel panel5;
        private System.Windows.Forms.Timer moreTimer;
        private Panel panel7;
        private Label label2;
        private Panel mainDashboardPanel;
        private Button importbtn;
        private Panel panel9;
        private Panel panel8;
        private Label label3;
        private Panel quotePanel;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel DashboardPanel_cover;
        private Panel panel10;
    }
}