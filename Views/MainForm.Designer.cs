namespace Basic_CRUD;
partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        dataGridViewProdutos = new DataGridView();
        BtInsert = new Button();
        BtDelete = new Button();
        BtUpdate = new Button();
        txtBoxSearch = new TextBox();
        LbFiltro = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewProdutos
        // 
        dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(dataGridViewProdutos, "dataGridViewProdutos");
        dataGridViewProdutos.Name = "dataGridViewProdutos";
        // 
        // BtInsert
        // 
        resources.ApplyResources(BtInsert, "BtInsert");
        BtInsert.Name = "BtInsert";
        BtInsert.UseVisualStyleBackColor = true;
        BtInsert.Click += BtInsert_Click;
        // 
        // BtDelete
        // 
        resources.ApplyResources(BtDelete, "BtDelete");
        BtDelete.Name = "BtDelete";
        BtDelete.UseVisualStyleBackColor = true;
        BtDelete.Click += BtDelete_Click;
        // 
        // BtUpdate
        // 
        resources.ApplyResources(BtUpdate, "BtUpdate");
        BtUpdate.Name = "BtUpdate";
        BtUpdate.UseVisualStyleBackColor = true;
        BtUpdate.Click += BtUpdate_Click;
        // 
        // txtBoxSearch
        // 
        resources.ApplyResources(txtBoxSearch, "txtBoxSearch");
        txtBoxSearch.Name = "txtBoxSearch";
        txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
        // 
        // LbFiltro
        // 
        resources.ApplyResources(LbFiltro, "LbFiltro");
        LbFiltro.Name = "LbFiltro";
        // 
        // MainForm
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(LbFiltro);
        Controls.Add(txtBoxSearch);
        Controls.Add(BtUpdate);
        Controls.Add(BtDelete);
        Controls.Add(BtInsert);
        Controls.Add(dataGridViewProdutos);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "MainForm";
        ShowIcon = false;
        ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewProdutos;
    private Button BtInsert;
    private Button BtDelete;
    private Button BtUpdate;
    private TextBox textBox1;
    private TextBox txtBoxSearch;
    private Label LbFiltro;
}
