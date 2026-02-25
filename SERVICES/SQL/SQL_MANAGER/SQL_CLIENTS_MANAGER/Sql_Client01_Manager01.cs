using Microsoft.Data.SqlClient;
namespace E_WEBB.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER
{
    public class Sql_Client01_Manager01
    {
        private static string[] connectionString_ = {
                 @"Data Source=(localdb)\ProjectModels;
                  Initial Catalog=Clients01_Database;
                  Integrated Security=True;
                  Connect Timeout=30;
                  Encrypt=True;
                  TrustServerCertificate=False;
                  ApplicationIntent=ReadWrite;
                  MultiSubnetFailover=False;
                  Command Timeout=30",

 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };

        private static SqlCommand[] cmd_ = { new SqlCommand("delete_client_using_email", conn_[0]),

new SqlCommand("delete_client_using_name", conn_[0]),
new SqlCommand("find_client_email_by_email", conn_[0]),
new SqlCommand("find_client_email_by_name", conn_[0]),
new SqlCommand("find_client_email_by_phonenumber", conn_[0]),
new SqlCommand("find_client_name_by_email", conn_[0]),
new SqlCommand("find_client_name_by_name", conn_[0]),
new SqlCommand("find_client_name_by_phonenumber", conn_[0]),
new SqlCommand("find_client_phonenumber_by_email", conn_[0]),
new SqlCommand("find_client_phonenumber_by_name", conn_[0]),
new SqlCommand("find_client_phonenumber_by_phonenumber", conn_[0]),
new SqlCommand("insert_client", conn_[0]),
new SqlCommand("update_clients_email_using_email", conn_[0]),
new SqlCommand("update_clients_email_using_name", conn_[0]),
new SqlCommand("update_clients_email_using_phonenumber", conn_[0]),
new SqlCommand("update_clients_name_using_email", conn_[0]),
new SqlCommand("update_clients_name_using_name", conn_[0]),
new SqlCommand("update_clients_name_using_phonenumber", conn_[0]),
new SqlCommand("update_clients_phonenumber_using_email", conn_[0]),
new SqlCommand("update_clients_phonenumber_using_name", conn_[0]),
new SqlCommand("update_clients_phonenumber_using_phonenumber", conn_[0]),
new SqlCommand("find_client_emailkey_by_name", conn_[0]),


        };

        public static SqlCommand[] cmd
        {
            get { return cmd_; }
            set { cmd_ = value; }
        }

        public static SqlConnection[] conn
        {
            get { return conn_; }
            set { conn_ = value; }
        }
        public enum Connection_strings
        {
            Connection01 = 0
        }
        public enum command_strings
        {

            delete_client_using_email = 0,
            delete_client_using_name = 1,
            find_client_email_by_email = 2,
            find_client_email_by_name = 3,
            find_client_email_by_phonenumber = 4,
            find_client_name_by_email = 5,
            find_client_name_by_name = 6,
            find_client_name_by_phonenumber = 7,
            find_client_phonenumber_by_email = 8,
            find_client_phonenumber_by_name = 9,
            find_client_phonenumber_by_phonenumber = 10,
            insert_client = 11,
            update_clients_email_using_email = 12,
            update_clients_email_using_name = 13,
            update_clients_email_using_phonenumber = 14,
            update_clients_name_using_email = 15,
            update_clients_name_using_name = 16,
            update_clients_name_using_phonenumber = 17,
            update_clients_phonenumber_using_email = 18,
            update_clients_phonenumber_using_name = 19,
            update_clients_phonenumber_using_phonenumber = 20,
            find_client_emailkey_by_name=21
        }
    }
}