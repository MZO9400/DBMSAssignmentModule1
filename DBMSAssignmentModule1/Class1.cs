using System;
using System.Text;
using System.Data.SqlClient;

namespace DBMSAssignment1 {
    class Program {
        static void MXSain(String[] args) {
            try {
                const String databaseName = "SampleDB";
                String[,] data = new String[4, 2] {
                       { "Jared", "Australia"},
                       { "Nikita", "India"},
                       {"Tom", "Germany"},
                       {"Jake", "United States"}
                    };
                // Connect to SQL
                Console.WriteLine("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(DBMS.ConnectionString.getConnectionString())) {
                    connection.Open();
                    Console.WriteLine("Done.");
                    // Create a sample database
                    Console.Write(String.Format("Dropping and creating database {0} ... ", databaseName));
                    String sql = String.Format("DROP DATABASE IF EXISTS [{0}]; CREATE DATABASE [{0}]", databaseName);
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        _ = command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }

                    // Create a Table and insert some sample data
                    Console.Write("Creating sample table with data, press any key to continue...");
                    _ = Console.ReadKey(true);
                    StringBuilder sb = new StringBuilder();
                    _ = sb.Append("Use " + databaseName + "; ");
                    _ = sb.Append("CREATE TABLE Employees ( ");
                    _ = sb.Append(" Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
                    _ = sb.Append(" Name NVARCHAR(50), ");
                    _ = sb.Append(" Location NVARCHAR(50) ");
                    _ = sb.Append("); ");
                    _ = sb.Append("INSERT INTO Employees (Name, Location) VALUES ");
                    _ = sb.Append(String.Format("(N'{0}', N'{1}'), ", data[0, 0], data[0, 1]));
                    _ = sb.Append(String.Format("(N'{0}', N'{1}'), ", data[1, 0], data[1, 1]));
                    _ = sb.Append(String.Format("(N'{0}', N'{1}');", data[2, 0], data[2, 1]));
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        _ = command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }

                    // INSERT demo
                    Console.Write("Inserting a new row into table, press any key to continue...");
                    _ = Console.ReadKey(true);
                    _ = sb.Clear();
                    _ = sb.Append("INSERT Employees (Name, Location) ");
                    _ = sb.Append(String.Format("VALUES ('{0}', '{1}');", data[3, 0], data[3, 1]));
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        Int32 rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) inserted");
                    }

                    // UPDATE demo
                    String userToUpdate = data[1, 0];
                    Console.Write("Updating 'Location' for user '" + userToUpdate + "', press any key to continue...");
                    _ = Console.ReadKey(true);
                    _ = sb.Clear();
                    _ = sb.Append("UPDATE Employees SET Location = N'" + data[2, 1] + "' WHERE Name = @name");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        _ = command.Parameters.AddWithValue("@name", userToUpdate);
                        Int32 rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                    }

                    // DELETE demo
                    String userToDelete = data[0, 0];
                    Console.Write("Deleting user '" + userToDelete + "', press any key to continue...");
                    _ = Console.ReadKey(true);
                    _ = sb.Clear();
                    _ = sb.Append("DELETE FROM Employees WHERE Name = @name;");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        _ = command.Parameters.AddWithValue("@name", userToDelete);
                        Int32 rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) deleted");
                    }

                    // READ demo
                    Console.WriteLine("Reading data from table, press any key to continue...");
                    _ = Console.ReadKey(true);
                    sql = "SELECT Id, Name, Location FROM Employees;";
                    using (SqlCommand command = new SqlCommand(sql, connection)) {

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            }
                        }
                    }
                }
            }
            catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            _ = Console.ReadKey(true);
        }
    }
}