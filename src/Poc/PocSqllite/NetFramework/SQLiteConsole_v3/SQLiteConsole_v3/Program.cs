using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteConsole_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string database = @"D:\ccp_wrks\SDETools\src\Poc\PocSqllite\NetFramework\SQLiteConsole_v3\PocSQLite.db";
            using (var connection = new SQLiteConnection("Data Source=" + database))
            {
                connection.Open();


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = @"INSERT INTO list 
                   (code, label) VALUES('Test Text ', 'this is a label'); ";
         sqlite_cmd.ExecuteNonQuery();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
        SELECT id, code, label
        FROM list
           ";
                //command.Parameters.AddWithValue("$id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var code = reader.GetString(1);

                        Console.WriteLine($"Hello, {code}!");
                    }
                }
            }

        }
    }
}
