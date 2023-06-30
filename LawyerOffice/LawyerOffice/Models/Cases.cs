using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Models
{
     class Cases : database.DBconnection
    {
        public int caseId { get; set; }
        public int clientId {get; set; }
        public int lawyerId { get; set; }
        public string Lawyername { get; set; }
        public DateTime startDate {get; set;}
        public string statusCase {get; set;}

        public bool insertNewCase()
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `cases`(`clientId`, `lawyerId`, `startDate`, `statusCase`) VALUES (@clientId, (SELECT lawyerId FROM `lawyer` WHERE name = @lawyername), @startDate, @statusCase)", getconnection);

          //  MySqlCommand command = new MySqlCommand("INSERT INTO `cases`(`clientId`, `name`, `startDate`, `statusCase`) VALUES (@clientId,@lawyername,@startDate,@statusCase)", connect.getconnection);
            
            command.Parameters.Add("@clientId", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@lawyername", MySqlDbType.VarChar).Value = Lawyername;
            command.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
            command.Parameters.Add("@statusCase", MySqlDbType.VarChar).Value = statusCase;
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
        public bool updateAnExistingCase()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `cases` SET `startDate`=@startDate,`statusCase`=@statusCase WHERE `clientId`=@clientId AND `lawyerId`=@lawyerId", getconnection);

            command.Parameters.Add("@clientId", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@lawyerId", MySqlDbType.Int32).Value = lawyerId;
            command.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
            command.Parameters.Add("@statusCase", MySqlDbType.VarChar).Value = statusCase;

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

        public bool deleteTheExistingCase()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `cases` WHERE `CaseId`=@id", getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = caseId;

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

        public DataTable getThelistOfCases(MySqlCommand command)
        {
            command.Connection = getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
