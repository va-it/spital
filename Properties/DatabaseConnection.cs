using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital.Properties
{
    class DatabaseConnection
    {
        //Lecture notes Software Engineering by Dr. Cristina Luca

        /* 
         * ATTRIBUTES
         */

        // one instance of the class DatabaseConnection
        private static DatabaseConnection _instance;

        // variables to store connection strings defined in the project's properties/settings
        private static string spitalDbConnectionString;
        private SqlConnection sqlconn;
        private SqlDataAdapter sqlAdapter;

        /*
         * PROPERTIES
         */

        //property for the instance of the class DatabaseConnection
        //creates a UNIQUE object
        public static DatabaseConnection Instance
        {
            get
            {
                //check if the object was created 
                if (_instance == null)
                {
                    //create the object
                    _instance = new DatabaseConnection();

                    //set the connection string 
                    DatabaseConnection.SpitalDbConnectionString = Settings.Default.SpitalDBConnStr;

                }
                return _instance;
            }
        }

        //property for the connection string
        //used just in this class
        public static string SpitalDbConnectionString
        {
            set
            {
                spitalDbConnectionString = value;
            }
        }

        /*
         * METHODS
         */ 

        //open the connection to the DB
        public void OpenConnection()
        {
           //create the connection
           sqlconn = new SqlConnection(spitalDbConnectionString);

           //open the connection
           sqlconn.Open();
        }

        //close the connection to db
        public void CloseConnection()
        {
            //close the connection
            sqlconn.Close();
        }

        //create and run a data set
        public DataSet GetDataSet(string sqlStatement)
        {
            //initialize a new instance of the DataSet Class
            DataSet dataSet = new DataSet();

            //open connection
            OpenConnection();

            //create table adapter using the connection string and the sql statement
            sqlAdapter = new SqlDataAdapter(sqlStatement, spitalDbConnectionString);

            //fills in the data set
            sqlAdapter.Fill(dataSet);

            //close the connection
            CloseConnection();
            return dataSet;
        }

        //Dr. Cristina Luca uploaded on canvas 
        //insert record in database
        public void RecordInDb()
        {
            //create the oblect sql command
            SqlCommand sqlCommand = new SqlCommand();

            //set its property
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = Constants.Insert; //set the sql query
            sqlCommand.Parameters.Add(new SqlParameter()); //pass in the parameter
        }
    }
}
