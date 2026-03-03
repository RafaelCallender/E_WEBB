using E_WEBB.SERVICES.FILE_SERVICES.TEXTFILE;
using Microsoft.Data.SqlClient;
namespace E_WEBB.SERVICES.SQL.SQL_MANAGER.SQL_CLIENTS_MANAGER
{
    public class Sql_Manager01
    {
        private static int index = 1;
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static string client_info01 = Read_T01.Client_Textfile01.Split('\n')[1];
        private static string client_info02 = Read_T01.Client_Textfile01.Split('\n')[2];
        private static string client_info03 = Read_T01.Client_Textfile01.Split('\n')[3];
        private static string client_info04 = Read_T01.Client_Textfile01.Split('\n')[4];

        private static string[] connectionString_ = {
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=Clients01_Database;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30",

                @$"Data Source={client_info02};Initial Catalog={client_info03};User ID={client_info04};Password={client_info01};Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"
            };

        private static SqlConnection[] conn_ = {
                new SqlConnection(connectionString_[0]),
                new SqlConnection(connectionString_[1])
            };

        private static SqlCommand[] cmd_ = {
                new SqlCommand("delete_client_using_email", conn_[index]),
                new SqlCommand("delete_client_using_name", conn_[index]),
                new SqlCommand("find_client_email_by_email", conn_[index]),
                new SqlCommand("find_client_email_by_name", conn_[index]),
                new SqlCommand("find_client_email_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_name_by_email", conn_[index]),
                new SqlCommand("find_client_name_by_name", conn_[index]),
                new SqlCommand("find_client_name_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_phonenumber_by_email", conn_[index]),
                new SqlCommand("find_client_phonenumber_by_name", conn_[index]),
                new SqlCommand("find_client_phonenumber_by_phonenumber", conn_[index]),
                new SqlCommand("insert_client", conn_[index]),
                new SqlCommand("update_clients_email_using_email", conn_[index]),
                new SqlCommand("update_clients_email_using_name", conn_[index]),
                new SqlCommand("update_clients_email_using_phonenumber", conn_[index]),
                new SqlCommand("update_clients_name_using_email", conn_[index]),
                new SqlCommand("update_clients_name_using_name", conn_[index]),
                new SqlCommand("update_clients_name_using_phonenumber", conn_[index]),
                new SqlCommand("update_clients_phonenumber_using_email", conn_[index]),
                new SqlCommand("update_clients_phonenumber_using_name", conn_[index]),
                new SqlCommand("update_clients_phonenumber_using_phonenumber", conn_[index]),
                new SqlCommand("find_client_emailkey_by_name", conn_[index]),
                new SqlCommand("insert_user01", conn_[index]),
                new SqlCommand("delete_user_using_email", conn_[index]),
                new SqlCommand("delete_user_using_name", conn_[index]),
                new SqlCommand("delete_user_using_phonenumber", conn_[index]),
                new SqlCommand("find_user_email_by_email", conn_[index]),
                new SqlCommand("find_user_email_by_name", conn_[index]),
                new SqlCommand("find_user_email_by_phonenumber", conn_[index]),
                new SqlCommand("find_user_name_by_email", conn_[index]),
                new SqlCommand("find_user_name_by_name", conn_[index]),
                new SqlCommand("find_user_name_by_phonenumber", conn_[index]),
                new SqlCommand("find_user_phonenumber_by_email", conn_[index]),
                new SqlCommand("find_user_phonenumber_by_name", conn_[index]),
                new SqlCommand("find_user_phonenumber_by_phonenumber", conn_[index]),
                new SqlCommand("find_user_message_by_name", conn_[index]),
                new SqlCommand("find_user_message_by_email", conn_[index]),
                new SqlCommand("find_user_message_by_phonenumber", conn_[index]),
                new SqlCommand("find_user_name_by_email_by_name", conn_[index]),
                new SqlCommand("find_client_cashapp_by_name", conn_[index]),
                new SqlCommand("find_client_cashapp_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_cashapp_by_email", conn_[index]),
                new SqlCommand("find_client_data01_by_email", conn_[index]),
                new SqlCommand("find_client_data01_by_name", conn_[index]),
                new SqlCommand("find_client_data01_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_zelle_by_email", conn_[index]),
                new SqlCommand("find_client_zelle_by_name", conn_[index]),
                new SqlCommand("find_client_zelle_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_data02_by_email", conn_[index]),
                new SqlCommand("find_client_data02_by_phonenumber", conn_[index]),
                new SqlCommand("find_client_data02_by_name", conn_[index])
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
            find_client_emailkey_by_name = 21,
            insert_user01 = 22,
            delete_user_using_email = 23,
            delete_user_using_name = 24,
            delete_user_using_phonenumber = 25,
            find_user_email_by_email = 26,
            find_user_email_by_name = 27,
            find_user_email_by_phonenumber = 28,
            find_user_name_by_email = 29,
            find_user_name_by_name = 30,
            find_user_name_by_phonenumber = 31,
            find_user_phonenumber_by_email = 32,
            find_user_phonenumber_by_name = 33,
            find_user_phonenumber_by_phonenumber = 34,
            find_user_message_by_name = 35,
            find_user_message_by_email = 36,
            find_user_message_by_phonenumber = 37,
            find_user_name_by_email_by_name = 38,
            find_client_cashapp_by_name = 39,
            find_client_cashapp_by_phonenumber = 40,
            find_client_cashapp_by_email = 41,
            find_client_data01_by_email = 42,
            find_client_data01_by_name = 43,
            find_client_data01_by_phonenumber = 44,
            find_client_zelle_by_email = 45,
            find_client_zelle_by_name = 46,
            find_client_zelle_by_phonenumber = 47,
            find_client_data02_by_email = 48,
            find_client_data02_by_phonenumber = 49,
            find_client_data02_by_name = 50
        }
    }
}