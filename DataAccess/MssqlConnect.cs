using System.Data.SqlClient;

namespace fero.DataAccess
{
    public class MssqlConnect
    {
        private static MssqlConnect instance = null;
        public static MssqlConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MssqlConnect();
                }
                return instance;
            }
        }
        private static SqlConnection? connection;
        private SqlCommand? command;
        public void OpenConnection(string database)
        {
            try
            {
                connection = new SqlConnection(@"Server=.;Database=" + database + ";Encrypt=False;Integrated Security=SSPI;");
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int ExecuteCommand(string query)
        {
            command = new SqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
                return 200;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 500;
            }
        }
        public string ExecuteReader(string aftertoFrom, string columns)
        {
            command = new SqlCommand("select " + columns + " from " + aftertoFrom, connection);
            try
            {
                string str = "";

                SqlDataReader reader = command.ExecuteReader();

                //Tablo kolon isimleri

                //Tablo içindeki değerleri tablo şelinde stringe döküyor
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if(i%2!=0){
                        str += reader[i].ToString();

                        }
                    }
                }
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}