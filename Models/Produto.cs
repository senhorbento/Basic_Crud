namespace Models;
public class Produto {
    public int id { get; set; } = 0;
    public string nome { get; set; } = string.Empty;
    public int quantidade_estoque { get; set; } = 0;
    public decimal preco { get; set; } = 0;
    public string unidade { get; set; } = string.Empty;
}