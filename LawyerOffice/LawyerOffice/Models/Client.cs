using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities.Collections;
using System.Xml.Linq;

namespace LawyerOffice.Models
{
    class Client : database.DBconnection
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public bool insertNewClient()
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `client`(`name`, `surname`, `address`, `phoneNumber`, `email`) VALUES(@firstname, @lastname, @address, @phone, @email)", getconnection);
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
               closeConnection();
                return true;
            }
            else
            {
               closeConnection();
                return false;
            }

        }

        public bool updateTheExistingClient()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `client` SET `name`=@firstname,`surname`=@lastname,`address`=@address,`phoneNumber`=@phone,`email`=@email WHERE  `clientId`= @id", getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
               closeConnection();
                return true;
            }
            else
            {
              closeConnection();
                return false;
            }

        }

        public bool deleteTheExistingClient()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `client` WHERE `clientId`=@id", getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }

        }

        public DataTable getThelistOfClients(MySqlCommand command)
        {
            command.Connection = getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);// per te ekzekutuar komandën SQL (e mer komanden si parameter)
            DataTable table = new DataTable();// e perdorim per te mare te dhenat 
            adapter.Fill(table); // per te mbushur tabelen
            return table;
        }

    }
}
