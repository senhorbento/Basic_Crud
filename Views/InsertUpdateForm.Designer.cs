namespace Basic_CRUD.Views
{
    partial class InsertUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbNome = new Label();
            LbQuantidade = new Label();
            LbPreco = new Label();
            LbUnidade = new Label();
            LbId = new Label();
            txtBoxNome = new TextBox();
            txtBoxQuantidade = new TextBox();
            txtBoxPreco = new TextBox();
            txtBoxUnidade = new TextBox();
            BtSalvar = new Button();
            BtCancelar = new Button();
            SuspendLayout();
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Location = new Point(12, 49);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(40, 15);
            LbNome.TabIndex = 0;
            LbNome.Text = "Nome";
            // 
            // LbQuantidade
            // 
            LbQuantidade.AutoSize = true;
            LbQuantidade.Location = new Point(12, 78);
            LbQuantidade.Name = "LbQuantidade";
            LbQuantidade.Size = new Size(69, 15);
            LbQuantidade.TabIndex = 1;
            LbQuantidade.Text = "Quantidade";
            // 
            // LbPreco
            // 
            LbPreco.AutoSize = true;
            LbPreco.Location = new Point(12, 107);
            LbPreco.Name = "LbPreco";
            LbPreco.Size = new Size(37, 15);
            LbPreco.TabIndex = 2;
            LbPreco.Text = "Preço";
            // 
            // LbUnidade
            // 
            LbUnidade.AutoSize = true;
            LbUnidade.Location = new Point(12, 136);
            LbUnidade.Name = "LbUnidade";
            LbUnidade.Size = new Size(51, 15);
            LbUnidade.TabIndex = 3;
            LbUnidade.Text = "Unidade";
            // 
            // LbId
            // 
            LbId.AutoSize = true;
            LbId.Location = new Point(12, 18);
            LbId.Name = "LbId";
            LbId.Size = new Size(38, 15);
            LbId.TabIndex = 4;
            LbId.Text = "label5";
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(87, 46);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(144, 23);
            txtBoxNome.TabIndex = 5;
            // 
            // txtBoxQuantidade
            // 
            txtBoxQuantidade.Location = new Point(87, 75);
            txtBoxQuantidade.Name = "txtBoxQuantidade";
            txtBoxQuantidade.Size = new Size(144, 23);
            txtBoxQuantidade.TabIndex = 6;
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Location = new Point(87, 104);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(144, 23);
            txtBoxPreco.TabIndex = 7;
            // 
            // txtBoxUnidade
            // 
            txtBoxUnidade.Location = new Point(87, 133);
            txtBoxUnidade.Name = "txtBoxUnidade";
            txtBoxUnidade.Size = new Size(144, 23);
            txtBoxUnidade.TabIndex = 8;
            // 
            // BtSalvar
            // 
            BtSalvar.Location = new Point(12, 196);
            BtSalvar.Name = "BtSalvar";
            BtSalvar.Size = new Size(75, 23);
            BtSalvar.TabIndex = 9;
            BtSalvar.Text = "Salvar";
            BtSalvar.UseVisualStyleBackColor = true;
            BtSalvar.Click += BtSalvar_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Location = new Point(156, 196);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 10;
            BtCancelar.Text = "Cancelar";
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += BtCancelar_Click;
            // 
            // InsertUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 231);
            Controls.Add(BtCancelar);
            Controls.Add(BtSalvar);
            Controls.Add(txtBoxUnidade);
            Controls.Add(txtBoxPreco);
            Controls.Add(txtBoxQuantidade);
            Controls.Add(txtBoxNome);
            Controls.Add(LbId);
            Controls.Add(LbUnidade);
            Controls.Add(LbPreco);
            Controls.Add(LbQuantidade);
            Controls.Add(LbNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "InsertUpdateForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertUpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbNome;
        private Label LbQuantidade;
        private Label LbPreco;
        private Label LbUnidade;
        private Label LbId;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button BtSalvar;
        private Button BtCancelar;
        private TextBox txtBoxNome;
        private TextBox txtBoxQuantidade;
        private TextBox txtBoxPreco;
        private TextBox txtBoxUnidade;
    }
}