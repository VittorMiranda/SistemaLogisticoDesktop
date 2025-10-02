using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace LogisticaApp.Utils
{
    public static class DatabaseHelper
    {
        private static string dbFile = @"T:\Publica\GSG\Stefanini\Proj_final\Vitor\Sistema_Logistico\Sistema_Logistico\Database\Logistica.db";
        private static string schemaFile = @"T:\Publica\GSG\Stefanini\Proj_final\Vitor\Sistema_Logistico\Sistema_Logistico\Database\schema.sql";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        /// <summary>
        /// Garante que o banco e as tabelas existam.
        /// </summary>
        public static void InitializeDatabase()
        {
            try
            {
                string databaseDir = Path.GetDirectoryName(dbFile)!;
                if (!Directory.Exists(databaseDir))
                    Directory.CreateDirectory(databaseDir);

                bool createSchema = !File.Exists(dbFile);
                if (createSchema)
                    SQLiteConnection.CreateFile(dbFile);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    if (createSchema && File.Exists(schemaFile))
                    {
                        string schemaSql = File.ReadAllText(schemaFile);
                        using (var command = new SQLiteCommand(schemaSql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inicializar o banco de dados: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Retorna uma nova conexão SQLite aberta.
        /// </summary>
        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Executa comandos (INSERT, UPDATE, DELETE).
        /// </summary>
        public static int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Executa consultas SELECT e retorna um DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
