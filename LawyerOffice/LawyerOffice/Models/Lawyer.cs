using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Models
{
     class Lawyer : database.DBconnection
    {

        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string specialization { get; set; }
        public int salary { get; set; }

        public bool insertNewLawyer()
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `lawyer`(`name`, `surname`, `specialization`, `salary`) VALUES(@firstname, @lastname, @specialization, @salary)", getconnection);
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@specialization", MySqlDbType.VarChar).Value = specialization;
            command.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;

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

        public bool updateTheExistingLawyer()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `lawyer` SET `name`=@firstname,`surname`=@lastname,`specialization`=@specialization,`salary`=@salary WHERE  `lawyerId`= @id", getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@specialization", MySqlDbType.VarChar).Value = specialization;
            command.Parameters.Add("@salary", MySqlDbType.Int32).Value = salary;

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


        public bool deleteTheExistingLawyer()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `lawyer` WHERE `lawyerId`=@id", getconnection);

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

        public DataTable getThelistOfLawyers(MySqlCommand command)
        {
            command.Connection = getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
