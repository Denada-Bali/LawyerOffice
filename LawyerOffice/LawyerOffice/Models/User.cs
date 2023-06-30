using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace LawyerOffice.Models
{
    internal class User : database.DBconnection
    {

        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }


        public bool validate_User()
        {
            bool check = false;
                openConnection();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM user WHERE username=@user AND password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = getconnection;

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                    { 
                     Login  l = new Login();
                     l.Close();

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show(); 
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password","ERROR");
                }
            }
            closeConnection();
        
            return check;

        }

    }
}
