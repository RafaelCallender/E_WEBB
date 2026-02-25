using E_WEBB.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace E_WEBB.SERVICES.SQL.SQL_SERVICES.SQL_CLIENT_SERVICES
{
    public class Sql_Client_Services01
    {
        private static string[] data01 = new string[100];
        private static bool status = true;
        public bool insert_client(string input01, string input02, string input03,
                                  string input04, string input05, string input06,
                                  out string output)
        {

            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue("@username", input01);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue(" @client_name", input02);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_email_key", input03);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_api_key", input04);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_email_address", input05);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].Parameters.AddWithValue("@client_phonenumber", input06);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.insert_client].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool delete_client_using_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_email].Parameters.AddWithValue("@client_email_address", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_email].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_client_using_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_name].Parameters.AddWithValue("@client_name", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.delete_client_using_name].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_client_email_by_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_email].Parameters.AddWithValue("@client_email_address", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_email_by_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_email_by_phonenumber(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_email_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_email_address"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_name_by_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_email].Parameters.AddWithValue("@client_email", input.Trim());
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_name_by_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_name_by_phonenumber(string input, out string output)
        {

            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_name_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_name"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_phonenumber_by_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_email].Parameters.AddWithValue("@client_email", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_phonenumber_by_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_name].Parameters.AddWithValue("@client_name", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_client_phonenumber_by_phonenumber(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_phonenumber].Parameters.AddWithValue("@client_phonenumber", input);
            using (SqlDataReader reader = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.find_client_phonenumber_by_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["client_phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_email_using_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_email].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_email_using_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_name].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_email_using_phonenumber(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_email_using_phonenumber].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_name_using_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_email].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_name_using_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_name].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_name_using_phonenumber(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_name_using_phonenumber].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_email(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_email].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_name(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_name].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_clients_phonenumber_using_phonenumber(string input, out string output)
        {
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Open();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.Clear();
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.AddWithValue("@email", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.AddWithValue("@longitude", input);
            Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Client01_Manager01.cmd[(int)Sql_Client01_Manager01.command_strings.update_clients_phonenumber_using_phonenumber].ExecuteNonQuery();
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
            Sql_Client01_Manager01.conn[(int)Sql_Client01_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
    }
}
