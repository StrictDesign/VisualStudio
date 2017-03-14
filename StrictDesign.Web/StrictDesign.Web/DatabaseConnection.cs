using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StrictDesign.Web
{
    public class DatabaseConnection
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pwd;

        // Connector
        public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "mjallby.net.mysql";
            database = "mjallby_net";
            uid = "mjallby_net";
            pwd = "_jm6960";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";

            connection = new MySqlConnection(connectionString);

        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new NotImplementedException();
                        break;

                    case 1045:
                        throw new NotImplementedException();
                        break;
                }
                return false;

            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new NotFiniteNumberException();
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Update statement
        public void Update()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Delete statement
        public void Delete()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Select statement
        public List<string>[] Select()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Count statement
        public int Count()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Backup
        public void Backup()
        {
            // TODO
            throw new NotImplementedException();
        }

        //Restore
        public void Restore()
        {
            // TODO
            throw new NotImplementedException();
        }


        //public static class MessageBox
        //{
        //    public static void Show(this Page Page, String Message)
        //    {
        //        Page.ClientScript.RegisterStartupScript(
        //           Page.GetType(),
        //           "MessageBox",
        //           "<script language='javascript'>alert('" + Message + "');</script>"
        //        );
        //    }
        //}
    }
}