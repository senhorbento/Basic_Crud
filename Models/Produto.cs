namespace Models;
public class Produto {
    public int id { get; set; }
    public string nome { get; set; }
    public int quantidade_estoque { get; set; }
    public int preco { get; set; }
    public int id_fornecedor { get; set; }
}