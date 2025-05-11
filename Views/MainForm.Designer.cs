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
        dataGridView1 = new DataGridView();
        BtSearch = new Button();
        BtInsert = new Button();
        BtDelete = new Button();
        BtUpdate = new Button();
        txtBoxSearch = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(dataGridView1, "dataGridView1");
        dataGridView1.Name = "dataGridView1";
        // 
        // BtSearch
        // 
        resources.ApplyResources(BtSearch, "BtSearch");
        BtSearch.Name = "BtSearch";
        BtSearch.UseVisualStyleBackColor = true;
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
        // 
        // MainForm
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtBoxSearch);
        Controls.Add(BtUpdate);
        Controls.Add(BtDelete);
        Controls.Add(BtInsert);
        Controls.Add(BtSearch);
        Controls.Add(dataGridView1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "MainForm";
        ShowIcon = false;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Button BtSearch;
    private Button BtInsert;
    private Button BtDelete;
    private Button BtUpdate;
    private TextBox textBox1;
    private TextBox txtBoxSearch;
}
