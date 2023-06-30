using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerOffice.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace LawyerOffice
{
    public partial class Login : Form
    {
        database.DBconnection connect = new database.DBconnection();
        Models.User u = new Models.User();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            u.username = textBox1.Text;
            u.password = textBox2.Text;

           // u.validate_User();

            bool verify = u.validate_User();

            //if (verify)
            //{
            //    var d = new Dashboard();
            //    d.Show();
            //    var l = new Login();
            //    l.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid login details.");
            //}
        }
    }
}
