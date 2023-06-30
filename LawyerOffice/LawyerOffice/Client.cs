using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LawyerOffice
{
    public partial class Client : Form
    {
        Models.Client client = new Models.Client();

        public Client()
        {
            InitializeComponent();
        }


        private void init()
        {
            client.firstname = nametb.Text;
            client.lastname = surnametb.Text;
            client.address = addresstb.Text;
            client.phone = pnumbertb.Text;
            client.email = emailtb.Text;
        }


        bool verification()
        {
            if ((nametb.Text == "") || (surnametb.Text == "") ||
                (pnumbertb.Text == "") || (addresstb.Text == "") ||
                (emailtb.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            init();

            if (verification())
            {
                try
                {
                    if (client.insertNewClient())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("Client added successfully.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if ((idOfClienttb.Text == ""))
            {
                MessageBox.Show("Client ID Required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                client.id = Convert.ToInt32(idOfClienttb.Text);
                if (MessageBox.Show("Are you sure you want to remove this client?", "Remove Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (client.deleteTheExistingClient())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("Client successfully removed.", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if ((idOfClienttb.Text == ""))
            {
                MessageBox.Show("Client ID is required. Please provide the client ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                client.id = Convert.ToInt32(idOfClienttb.Text);

                init();
                if (verification())
                {
                    try
                    {
                        if (client.updateTheExistingClient())
                        {
                            populateTheGridView();
                            clearTextBoxs();
                            MessageBox.Show("Client data updated successfully.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                idOfClienttb.Visible = true;
                label1.Visible = true;
                updatebtn.Visible = true;
                deletebtn.Visible = true;
            }
            else
            {
                idOfClienttb.Visible = false;
                label1.Visible = false;
                updatebtn.Visible = false;
                deletebtn.Visible = false;
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            populateTheGridView();

            idOfClienttb.Visible = false;
            label1.Visible = false;
            updatebtn.Visible = false;
            deletebtn.Visible = false;
        }

        public void populateTheGridView()
        {
            dataGridViewClient.ReadOnly = true;
            //dataGridViewClient.DataSource = client.getThelistOfClients(new MySqlCommand("SELECT * FROM `client`"));
            dataGridViewClient.DataSource = client.getThelistOfClients(new MySqlCommand("CALL GetClients();"));
        }

        public void clearTextBoxs()
        {
            nametb.Clear();
            surnametb.Clear();
            pnumbertb.Clear();
            addresstb.Clear();
            emailtb.Clear();
            idOfClienttb.Clear();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dataGridViewClient.DataSource = client.getThelistOfClients(new MySqlCommand("SELECT * FROM `client` WHERE `surname` LIKE '%" + searchboxtb.Text + "%' OR `address` LIKE '%" + searchboxtb.Text + "%' OR `name` LIKE '%" + searchboxtb.Text + "%'"));
            searchboxtb.Clear();
        }
    }
}

