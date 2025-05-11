using Basic_CRUD.Views;
using Controllers;
using Models;

namespace Basic_CRUD;

public partial class MainForm : Form
{
    private readonly ProdutoController _produtoController = new();
    private List<Produto> allProdutos = [];

    public MainForm()
    {
        InitializeComponent();
        FillGridView();
    }

    private void FillGridView()
    {
        allProdutos = _produtoController.GetAll();
        dataGridViewProdutos.DataSource = allProdutos;
    }

    private Produto? GetSelected()
    {
        int selected = dataGridViewProdutos.SelectedRows.Count;
        Produto? produto = null;
        if (selected == 1)
        {
            produto = (Produto?)dataGridViewProdutos.SelectedRows[0].DataBoundItem;
        }
        else
        {
            string message = selected == 0 ? "ao menos" : "somente";
            MessageBox.Show($"Selecione {message} 1 produto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return produto;
    }

    private void FilterGrid(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            dataGridViewProdutos.DataSource = allProdutos;
        }
        else
        {
            List<Produto> filtered = allProdutos
                .Where(p => p.nome.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewProdutos.DataSource = filtered;
        }
    }

    private void BtInsert_Click(object sender, EventArgs e)
    {
        InsertUpdateForm form = new();
        form.FormClosed += (s, args) =>
        {
            FillGridView();
        };
        form.Show();
    }

    private void BtUpdate_Click(object sender, EventArgs e)
    {
        Produto? p = GetSelected();
        if (p != null)
        {
            InsertUpdateForm form = new(p);
            form.FormClosed += (_, _) =>
            {
                FillGridView();
            };
            form.Show();
        }
    }

    private void BtDelete_Click(object sender, EventArgs e)
    {
        Produto? p = GetSelected();
        if (p != null)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _produtoController.Delete(p.id);
                MessageBox.Show("Produto excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGridView();
            }
        }
    }

    private void txtBoxSearch_TextChanged(object sender, EventArgs e)
    {
        FilterGrid(txtBoxSearch.Text);
    }
}
