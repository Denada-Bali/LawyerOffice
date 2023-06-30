using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LawyerOffice
{
    public partial class Cases : Form
    {
        Models.Cases cases = new Models.Cases();
        Models.Lawyer lawyer = new Models.Lawyer();
        //Models.Client client = new Models.Client();

        public Cases()
        {
            InitializeComponent();
        }

        private void init()
        {
            try {
                cases.clientId = Convert.ToInt32(clientidtb.Text);
                cases.startDate = startdatest.Value;
                cases.statusCase = statuscasecb.Text;
                cases.Lawyername = lawyernamecb.Text;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Exception: " + ex, "Error");
            }
        }
        bool verification()
        {
            if ((clientidtb.Text == "") || (statuscasecb.Text == "") || (lawyernamecb.Text == ""))
            {
                return false;
            }
            else
                return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int startedYear = startdatest.Value.Year;
            int currentYear = DateTime.Now.Year;
            int caseDuration = currentYear - startedYear;

            if (caseDuration > 10 && caseDuration < 100)
            {
                MessageBox.Show("The case has been ongoing for a long time.", "Long Case Duration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (verification())
            {
                init();

                if (cases.insertNewCase())
                {
                    populateTheGridView();
                    clearTextBoxs();
                    MessageBox.Show("Case successfully added.", "Add Case", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to add case.", "Add Case", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Add Case", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void populateTheGridView()
        {
            dataGridViewCase.ReadOnly = true;

            //string query = @"SELECT cases.*, lawyer.name AS LawyerName, client.name AS ClientName
            //         FROM cases
            //         INNER JOIN lawyer ON cases.lawyerId = lawyer.lawyerId
            //         INNER JOIN client ON cases.clientId = client.clientId";

            //dataGridViewCase.DataSource = cases.getThelistOfCases(new MySqlCommand(query));
            //dataGridViewCase.Refresh();

            DataTable table = cases.getThelistOfCases(new MySqlCommand("SELECT cases.*, lawyer.name AS LawyerName, client.name AS ClientName FROM cases INNER JOIN lawyer ON cases.lawyerId = lawyer.lawyerId INNER JOIN client ON cases.clientId = client.clientId"));

            table.Columns.Remove("lawyerId");
            //table.Columns.Remove("clientId");
            dataGridViewCase.DataSource = table;
            dataGridViewCase.Refresh();

        }

        private void Cases_Load(object sender, EventArgs e)
        {
            populateTheGridView(); 
            //lawyernamecb.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("SELECT * FROM `lawyer`"));
            //lawyernamecb.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("CALL getLawyers();"));
            //lawyernamecb.DisplayMember = "name";
            //lawyernamecb.ValueMember = "lawyerId";
            lawyernamecb.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("CALL getLawyersWithMaxThreeActiveClients();"));
            lawyernamecb.DisplayMember = "name";
            lawyernamecb.ValueMember = "lawyerId";

            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (verification())
            {
                init();
                try
                {
                    //DataRowView selectedLawyerRow = (DataRowView)lawyernamecb.SelectedItem;
                    //int selectedLawyerID = Convert.ToInt32(selectedLawyerRow["lawyerId"]);

                    DataRowView selectedLawyerRow = (DataRowView)lawyernamecb.SelectedItem;
                    cases.lawyerId = Convert.ToInt32(selectedLawyerRow["lawyerId"]);

                    if (cases.updateAnExistingCase())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("Cases successfully updated.", "Update Cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot edit the case. Administrator permission is required to change the lawyer.", "Update Cases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("You can only update the start date and status case.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Update Cases", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((clientidtb.Text == ""))
            {
                MessageBox.Show("Please provide the Case ID.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                cases.caseId = Convert.ToInt32(clientidtb.Text);
                if (MessageBox.Show("Are you sure you want to remove this case?", "Remove Case", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cases.deleteTheExistingCase())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("Case Removed successfully.", "Remove Case", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Visible = true;
                label1.Visible = true;
                clientIdLabel.Visible = false;
            }
            else
            {
                button4.Visible = false;
                label1.Visible = false;
                clientIdLabel.Visible = true;
            }
        }

        public void clearTextBoxs()
        {
            clientidtb.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridViewCase.DataSource = cases.getThelistOfCases(new MySqlCommand("SELECT * FROM `cases` c JOIN `lawyer` l ON c.lawyerId = l.lawyerId WHERE c.`statusCase` LIKE '%" + textBox9.Text + "%' OR c.`startDate` LIKE '%" + textBox9.Text + "%' OR l.`name` LIKE '%" + textBox9.Text + "%'"));
            string query = "SELECT c.caseId, c.clientId, c.startDate, c.statusCase, l.name AS LawyerName, cl.name AS clientName " +
                           "FROM `cases` c " +
                           "JOIN `lawyer` l ON c.lawyerId = l.lawyerId " +
                           "JOIN `client` cl ON c.clientId = cl.clientId " +
                           "WHERE c.`statusCase` LIKE '%" + textBox9.Text + "%' OR c.`startDate` LIKE '%" + textBox9.Text + "%' OR l.`name` LIKE '%" + textBox9.Text + "%'";

            dataGridViewCase.DataSource = cases.getThelistOfCases(new MySqlCommand(query));
            textBox9.Clear();
        }
    }
}