using System;
using System.Data;
using System.Data.SqlClient;

namespace ServiceAutoMVP.Model.Repository
{

    public class Repository
    {
        protected SqlConnection connection;

        public Repository()
        {
            string s = "Data Source=DESKTOP-FAUD35Q\\SQLEXPRESS;Initial Catalog=ServiceAutoMVP_DB;Integrated Security=True;";
            //s += "";
            this.connection = new SqlConnection(s);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
            set { this.connection = value; }
        }

        public void OpeningConnection()
        {
            if (this.connection.State != ConnectionState.Open)
                this.connection.Open();
        }

        public void ClosingConnection()
        {
            if (this.connection.State != ConnectionState.Closed)
                this.connection.Close();
        }

        public bool CommandSQL(string commandSQL)
        {
            bool result = true;
            try
            {
                this.OpeningConnection();
                SqlCommand command = new SqlCommand(commandSQL, this.connection);
                if (command.ExecuteNonQuery() == 0)
                    result = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                this.ClosingConnection();
            }
            return result;
        }

        public DataTable GetTable(string commandSQL)
        {
            DataTable result = null;
            try
            {
                this.OpeningConnection();
                SqlCommand command = new SqlCommand(commandSQL, this.connection);
                SqlDataAdapter readData = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                readData.Fill(table);
                result = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.ClosingConnection();
            }
            return result;
        }
    }
}