namespace fero.DataAccess
{
    public class DbRequests
    {
        public string TakeData(string dbname, string tablename)
        {
            MssqlConnect.Instance.OpenConnection(dbname);
            string str=MssqlConnect.Instance.ExecuteReader(tablename,"*");
            MssqlConnect.Instance.CloseConnection();
            return str;
        }
    }
}