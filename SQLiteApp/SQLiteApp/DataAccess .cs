using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteApp
{

    class DataAccess
    {
        public async static void InitializeDatabase()
        {   //create connection to sqlite database file
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteSample.db"))
            {
            //oepn database and creat Table name= Primary_key(integer)PK // Text_Entry(NVARCHAR 2048)
                db.Open();
                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                                      "Text_Entry NVARCHAR(2048) NULL)";
            // connect SQLiteDatabase with command (SQLkey, dabaseConnect)
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
            // run  
                createTable.ExecuteReader();
            }
        }

        public static void AddData(string inputText)
        {   //create connection to sqlite datanase file
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO MyTable VALUES (NULL, @Entry);";
                insertCommand.Parameters.AddWithValue("@Entry", inputText);
                // run sqlcommand
                insertCommand.ExecuteReader();
                db.Close();
            }
        }

        public static List<String> GetData()
        {   // create "entries" as string for get result from SQLite database
            List<String> entries = new List<string>();
            // declaration object
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteSample.db"))
            {
                db.Open();
                // use SQL Command
                SqliteCommand selectCommand = new SqliteCommand("SELECT Text_Entry from MyTable", db);
                // create "SqliteDataReader" to get data in case database return data to use someting
                SqliteDataReader query = selectCommand.ExecuteReader();
                //create while loop 
                // Read() -> return true if data remain in row
                //           return false if not have data
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
        }
    }
}