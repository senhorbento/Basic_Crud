namespace Models;
public class Produto {
    public int id { get; set; }
    public string nome { get; set; }
    public int quantidade_estoque { get; set; }
    public decimal preco { get; set; }
    public string unidade { get; set; }
}