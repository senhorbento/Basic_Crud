using Controllers;
using Models;
using System.Diagnostics;


namespace Basic_CRUD.Views
{
    public partial class InsertUpdateForm : Form
    {
        private Produto produto = new();
        private readonly ProdutoController _produtoController = new();
        public InsertUpdateForm(Produto? obj = null)
        {
            InitializeComponent();
            bool isProdutoEmpty = obj == null;
            Text = isProdutoEmpty ? "Inserir" : "Atualizar";
            LbId.Visible = !isProdutoEmpty;
            LbId.Text = isProdutoEmpty ? "" : $"Produto id: {obj?.id}";
            if (obj != null) produto = obj;
            txtBoxNome.DataBindings.Add("Text", produto, "nome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxQuantidade.DataBindings.Add("Text", produto, "quantidade_estoque", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxPreco.DataBindings.Add("Text", produto, "preco", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBoxUnidade.DataBindings.Add("Text", produto, "unidade", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if(Text == "Inserir")
                _produtoController.Insert(produto);
            if (Text == "Atualizar")
                _produtoController.Update(produto);
            MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            _produtoController.Update(produto);
            Close();
        }
    }
}
