using System.Data;
using System.Data.SQLite;

namespace Core;
public class DB : IDisposable
{
    private static readonly string DB_NAME = "MyDatabase.sqlite";
    private static readonly string connectionString = $"Data Source={DB_NAME};Version=3;";
    private readonly SQLiteConnection connection = new(connectionString);
    private static SQLiteCommand? command;

    public void Init()
    {
        if (!File.Exists(DB_NAME))
        {
            SQLiteConnection.CreateFile(DB_NAME);
        }
        Command("CREATE TABLE IF NOT EXISTS Produto ( " +
                "id                      INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "nome                    TEXT NOT NULL, " +
                "quantidade_estoque      INTEGER NOT NULL, " +
                "preco                   REAL NOT NULL," +
                "unidade                 TEXT NOT NULL);");
        Connect();
        Execute();
        Dispose();
    }
    public void Connect()
    {
        if(connection != null || connection.State == ConnectionState.Closed) {
            connection.Open();
        }
    }
    public void Command(string sql)
    {
        command = new(sql, connection);
    }
    public void Parameter(string key, object value)
    {
        command.Parameters.AddWithValue(key, value);
    }
    public dynamic Execute()
    {
        if (command.CommandText.ToUpper().Contains("SELECT"))
        {
            return command.ExecuteReader();
        }
        return command.ExecuteNonQuery();
    }
    public void Dispose()
    {
        if (connection != null || connection.State != ConnectionState.Closed)
        {
            connection.Close();
        }
    }
}
