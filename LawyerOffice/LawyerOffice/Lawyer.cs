using LawyerOffice.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerOffice
{
    public partial class Lawyer : Form
    {
        Models.Lawyer lawyer = new Models.Lawyer();
  
        public Lawyer()
        {
            InitializeComponent();
        }

        private void init()
        {
            lawyer.firstname = lawyernametb.Text;
            lawyer.lastname = lawyersurnametb.Text;
            lawyer.specialization = lawyerspecializationtb.Text;
        }
        bool verification()
        {
            if ((lawyernametb.Text == "") || (lawyersurnametb.Text == "") ||
                (lawyerspecializationtb.Text == "") || (lawyersalary.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
            lawyer.salary = Convert.ToInt32(lawyersalary.Text);
            if (verification())
            {
                try
                {
                    if (lawyer.insertNewLawyer())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("The lawyer has been successfully added.", "Add Lawyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Add Lawyer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (idOfLawyertb.Text == "")
            {
                MessageBox.Show("Lawyer ID Required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                init();
                lawyer.id = Convert.ToInt32(idOfLawyertb.Text);
                lawyer.salary = Convert.ToInt32(lawyersalary.Text);
                if (verification())
                {
                    try
                    {
                        if (lawyer.updateTheExistingLawyer())
                        {
                            populateTheGridView();
                            clearTextBoxs();
                            MessageBox.Show("Lawyer Updated Successfully.", "Update Lawyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.", "Update Lawyer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idOfLawyertb.Text == "")
            {
                MessageBox.Show("Lawyer ID is required. Please provide the lawyer ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lawyer.id = Convert.ToInt32(idOfLawyertb.Text);
                init();
                if (MessageBox.Show("Are you sure you want to remove this lawyer?", "Remove Lawyer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lawyer.deleteTheExistingLawyer())
                    {
                        populateTheGridView();
                        clearTextBoxs();
                        MessageBox.Show("Lawyer successfully removed.", "Remove Lawyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                idOfLawyertb.Visible = true;
                label1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                idOfLawyertb.Visible = false;
                label1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }
        public void populateTheGridView()
        {
            dataGridViewLawyer.ReadOnly = true;
            //dataGridViewLawyer.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("SELECT * FROM `lawyer`"));
            dataGridViewLawyer.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("CALL GetLawyers();"));
            dataGridViewLawyer.Refresh(); 
        }
        private void Lawyer_Load(object sender, EventArgs e)
        {
            populateTheGridView();
            idOfLawyertb.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        public void clearTextBoxs()
        {
            lawyernametb.Clear();
            lawyersurnametb.Clear();
            lawyerspecializationtb.Clear();
            lawyersalary.Clear();
            idOfLawyertb.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewLawyer.DataSource = lawyer.getThelistOfLawyers(new MySqlCommand("SELECT * FROM `lawyer` WHERE `surname` LIKE '%" + textBox9.Text + "%' OR `name` LIKE '%" + textBox9.Text + "%' OR `specialization` LIKE '%" + textBox9.Text + "%'"));
            textBox9.Clear();
        }
    }
}
