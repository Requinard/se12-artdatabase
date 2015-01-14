using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1
{
    internal class Database
    {
        private const string db_file_name = "db.sqlite";
        private SQLiteConnection dbConnection;

        public Database()
        {
            if (!File.Exists(db_file_name))
            {
                SQLiteConnection.CreateFile(db_file_name);

                dbConnection = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                dbConnection.Open();

                InitialiseTable();

                dbConnection.Close();
            }

            dbConnection = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            dbConnection.Open();
        }

        public void InitialiseTable()
        {
            string query = "create table shapes (type int, p1x int, p1y int, p2x int, p2y int);";

            executeQueryString(query);
        }

        public void InsertShapeIntoDatabase(int shape, Point p1, Point p2)
        {
            string query =
                String.Format(
                    "INSERT INTO shapes (`type`, `p1x`, `p1y`, `p2x`, `p2y`) VALUES ({0}, {1}, {2}, {3}, {4});", shape,
                    p1.X, p1.Y, p2.X, p2.Y);

            executeQueryString(query);
        }

        public List<Shape> SelectAllShapes()
        {
            var ret = new List<Shape>();

            string query = "select * from shapes;";

            SQLiteDataReader reader = executeQueryString(query);

            while (reader.Read())
            {
                ret.Add(new Shape(reader));
            }

            return ret;
        }

        public void EmptyDatabase()
        {
            string query = "DELETE FROM `shapes`";
            executeQueryString(query);
        }

        private SQLiteDataReader executeQueryString(string query)
        {
            var command = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader;
        }
    }

    public class Shape
    {
        public Point p1;
        public Point p2;
        public int shape;

        public Shape(SQLiteDataReader reader)
        {
            shape = (int) reader["type"];
            p1 = new Point((int) reader["p1x"], (int) reader["p1y"]);
            p2 = new Point((int) reader["p2x"], (int) reader["p2y"]);
        }
    }
}