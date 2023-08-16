using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Core;
using Models;

namespace Controllers;
public class ProdutoController
{
    public void Insert(Produto p)
    {
        using DB db = new();
        db.Connect();
        db.Command("INSERT INTO Produto (nome, quantidade_estoque, preco, unidade) " +
                   "VALUES (@nome, @quantidade_estoque, @preco, @unidade)");
        db.Parameter("@nome", p.nome);
        db.Parameter("@quantidade_estoque", p.quantidade_estoque);
        db.Parameter("@preco", p.preco);
        db.Parameter("@unidade", p.unidade);
        db.ExecuteRowReturn();
    }

    public List<Produto> GetAll()
    {
        List<Produto> list = new();
        using DB db = new();
        db.Connect();
        db.Command("SELECT * FROM Produto");
        using SQLiteDataReader reader = db.ExecuteReaderReturn();
        while (reader.Read())
        {
            list.Add(new Produto
            {
                id = int.Parse(reader["id"].ToString()!),
                nome = reader["nome"].ToString()!,
                quantidade_estoque = int.Parse(reader["quantidade_estoque"].ToString()!),
                preco = decimal.Parse(reader["preco"].ToString()!),
                unidade = reader["unidade"].ToString()!
            });
        }
        return list;
    }

    public Produto? GetById(int id)
    {
        using DB db = new();
        db.Connect();
        db.Command("SELECT * FROM Produto WHERE id = @id");
        db.Parameter("@id", id);
        using SQLiteDataReader reader = db.ExecuteReaderReturn();
        if (reader.Read())
        {
            return new Produto
            {
                id = int.Parse(reader["id"].ToString()!),
                nome = reader["nome"].ToString()!,
                quantidade_estoque = int.Parse(reader["quantidade_estoque"].ToString()!),
                preco = decimal.Parse(reader["preco"].ToString()!),
                unidade = reader["unidade"].ToString()!
            };
        }
        return null;
    }
    public void Update(Produto p)
    {
        using DB db = new();
        db.Connect();
        db.Command("UPDATE Produto SET nome = @nome, quantidade_estoque = @quantidade_estoque, preco = @preco, unidade = @unidade WHERE id = @id");
        db.Parameter("@id", p.id);
        db.Parameter("@nome", p.nome);
        db.Parameter("@quantidade_estoque", p.quantidade_estoque);
        db.Parameter("@preco", p.preco);
        db.Parameter("@unidade", p.unidade);
        db.ExecuteRowReturn();
    }
    public void Delete(int id)
    {
        using DB db = new();
        db.Connect();
        db.Command("DELETE FROM Produto WHERE id = @id");
        db.Parameter("@id", id);
        db.ExecuteRowReturn();
    }
}