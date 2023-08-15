using System.Data.Common;
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
        SQLiteConnection.CreateFile(DB_NAME);
        string sql = "CREATE TABLE Produto ( "+
                     "id                      INTEGER PRIMARY KEY AUTOINCREMENT, "+
                     "nome                    TEXT NOT NULL, "+
                     "quantidade_estoque      INTEGER NOT NULL, " +
                     "preco                   INTEGER NOT NULL, " +
                     "id_fornecedor           INTEGER NOT NULL); ";
        Command(sql);
        Connect();
        ExecuteRowReturn();
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
    public int ExecuteRowReturn()
    {
        return command.ExecuteNonQuery();
    }
    public SQLiteDataReader ExecuteReaderReturn()
    {
        return command.ExecuteReader();
    }
    public void Dispose()
    {
        if (connection != null || connection.State != ConnectionState.Closed)
        {
            connection.Close();
        }
    }
}
