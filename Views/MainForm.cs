using Basic_CRUD.Views;
using Controllers;

namespace Basic_CRUD;

public partial class MainForm : Form
{
    private readonly ProdutoController _produtoController = new();
    public MainForm()
    {
        InitializeComponent();
    }

    private void BtInsert_Click(object sender, EventArgs e)
    {
        InsertUpdateForm form = new();
        form.FormClosed += (s, args) =>
        {
            _produtoController.GetAll();
        };
        form.Show();
    }

    private void BtUpdate_Click(object sender, EventArgs e)
    {
        InsertUpdateForm form = new(new());
        form.FormClosed += (_, _) =>
        {
            _produtoController.GetAll();
        };
        form.Show();
    }

    private void BtDelete_Click(object sender, EventArgs e)
    {

    }
}
