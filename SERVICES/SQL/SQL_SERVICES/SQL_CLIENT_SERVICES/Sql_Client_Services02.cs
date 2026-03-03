using E_WEBB.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES
{
    public class Sql_Client_Services02
    {
        private static string[] data01 = new string[100];
        private static bool status = true;
        private static DateTime now = DateTime.Now;
        private string nowdatetime = now.ToString("yyyy-MM-dd HH:mm:ss");
        public bool insert_user01(string input01, string input02, string input03,
                                  string input04, out string output)
        {

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].Parameters.AddWithValue("@user_name", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].Parameters.AddWithValue("@user_email", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].Parameters.AddWithValue("@user_phonenumber", input03);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].Parameters.AddWithValue("@user_message", input04);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].Parameters.AddWithValue("@user_datecreated", nowdatetime);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user01].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.AddWithValue("@user_email", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_name].Parameters.AddWithValue("@user_name", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_name].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.AddWithValue("@user_phonenumber", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_user_email_by_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_email].Parameters.AddWithValue("@user_email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
      
        public bool find_user_email_by_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_name].Parameters.AddWithValue("@user_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_email_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_phonenumber].Parameters.AddWithValue("@user_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_email_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_name_by_email_by_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_email_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_email_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_email_by_name].Parameters.AddWithValue("@user_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_email_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_name_by_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_name].Parameters.AddWithValue("@user_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_name_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_phonenumber].Parameters.AddWithValue("@user_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_name_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_phonenumber_by_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_email].Parameters.AddWithValue("@user_email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_phonenumber_by_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_name].Parameters.AddWithValue("@user_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_phonenumber_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_phonenumber].Parameters.AddWithValue("@user_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_phonenumber_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_message_by_name(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_name].Parameters.AddWithValue("@cuser_namelient_email_address", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_message"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_message_by_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_email].Parameters.AddWithValue("@user_email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_message"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_message_by_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_phonenumber].Parameters.AddWithValue("@user_phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_message_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["user_message"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
    }
}
