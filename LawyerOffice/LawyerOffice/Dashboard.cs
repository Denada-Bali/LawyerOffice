namespace LawyerOffice
{
    public partial class Dashboard : Form
    {

        bool sidebarExpand;
        bool moreCollapse;
        private Form activeForm = null;

        database.DBconnection con = new database.DBconnection();

        public Dashboard()
        {
            InitializeComponent();

        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    quotePanel.Visible = true;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    quotePanel.Visible = false;
                }

            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void moreTimer_Tick(object sender, EventArgs e)
        {
            if (moreCollapse)
            {
                moreContainer.Height += 10;
                if (moreContainer.Height == moreContainer.MaximumSize.Height)
                {
                    moreCollapse = false;
                    moreTimer.Stop();
                }
            }
            else
            {
                moreContainer.Height -= 10;
                if (moreContainer.Height == moreContainer.MinimumSize.Height)
                {
                    moreCollapse = true;
                    moreTimer.Stop();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moreTimer.Start();
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            //openChildForm(new Client());

            Form parentForm = this;

            Form childForm = new Client();

            Panel containerPanel = mainDashboardPanel;


            FormHelper.OpenChildForm(parentForm, childForm, containerPanel);

        }

        private void lawyerbtn_Click(object sender, EventArgs e)
        {
            Form parentForm = this;

            Form childForm = new Lawyer();

            Panel containerPanel = mainDashboardPanel;


            FormHelper.OpenChildForm(parentForm, childForm, containerPanel);
        }

        private void casesbtn_Click(object sender, EventArgs e)
        {
            Form parentForm = this;

            Form childForm = new Cases();

            Panel containerPanel = mainDashboardPanel;


            FormHelper.OpenChildForm(parentForm, childForm, containerPanel);
        }

        private void importbtn_Click(object sender, EventArgs e)
        {
            Form parentForm = this;

            Form childForm = new ImportExcelFile();

            Panel containerPanel = mainDashboardPanel;


            FormHelper.OpenChildForm(parentForm, childForm, containerPanel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();
            mainDashboardPanel.Controls.Add(DashboardPanel_cover);
        }


    }
}
