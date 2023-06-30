using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;


namespace LawyerOffice
{
    public partial class ImportExcelFile : Form
    {
        database.DBconnection connect = new database.DBconnection();
        Models.Client client = new Models.Client();

        public ImportExcelFile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.FileName = textBox1.Text;
            openFileDialog.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1;\"";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.openConnection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string name = dataGridView1.Rows[i].Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                string surname = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                string address = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                string phoneNumber = dataGridView1.Rows[i].Cells[3].Value?.ToString();
                string email = dataGridView1.Rows[i].Cells[4].Value?.ToString();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO `client`(`name`, `surname`, `address`, `phoneNumber`, `email`) VALUES (@name, @surname, @address, @phoneNumber, @email)", connect.getconnection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }

            connect.closeConnection();
            MessageBox.Show("Data saved in the client table.");
            populateTheGridView();

        }

        public void populateTheGridView()
        {
            dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = client.getThelistOfClients(new MySqlCommand("SELECT * FROM `client`"));
            dataGridView1.DataSource = client.getThelistOfClients(new MySqlCommand("CALL GetClients();"));
        }
    }
}
