namespace TerminalSubprefeitura;

partial class FormPrincipal
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
        grpCadastro = new GroupBox();
        lblSolicitante = new Label();
        txtSolicitante = new TextBox();
        lblTipo = new Label();
        cmbTipo = new ComboBox();
        lblBairro = new Label();
        txtBairro = new TextBox();
        lblEndereco = new Label();
        txtEndereco = new TextBox();
        lblDescricao = new Label();
        txtDescricao = new TextBox();
        btnCadastrar = new Button();
        dgvOcorrencias = new DataGridView();
        grpCadastro.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOcorrencias).BeginInit();
        SuspendLayout();
        //
        // grpCadastro
        //
        grpCadastro.Controls.Add(lblSolicitante);
        grpCadastro.Controls.Add(txtSolicitante);
        grpCadastro.Controls.Add(lblTipo);
        grpCadastro.Controls.Add(cmbTipo);
        grpCadastro.Controls.Add(lblBairro);
        grpCadastro.Controls.Add(txtBairro);
        grpCadastro.Controls.Add(lblEndereco);
        grpCadastro.Controls.Add(txtEndereco);
        grpCadastro.Controls.Add(lblDescricao);
        grpCadastro.Controls.Add(txtDescricao);
        grpCadastro.Controls.Add(btnCadastrar);
        grpCadastro.Location = new Point(12, 12);
        grpCadastro.Name = "grpCadastro";
        grpCadastro.Size = new Size(270, 420);
        grpCadastro.TabIndex = 0;
        grpCadastro.TabStop = false;
        grpCadastro.Text = "Nova ocorrência";
        //
        // lblSolicitante
        //
        lblSolicitante.AutoSize = true;
        lblSolicitante.Location = new Point(15, 28);
        lblSolicitante.Name = "lblSolicitante";
        lblSolicitante.Text = "Solicitante (quem ligou)";
        //
        // txtSolicitante
        //
        txtSolicitante.Location = new Point(15, 48);
        txtSolicitante.Name = "txtSolicitante";
        txtSolicitante.Size = new Size(240, 23);
        txtSolicitante.TabIndex = 1;
        //
        // lblTipo
        //
        lblTipo.AutoSize = true;
        lblTipo.Location = new Point(15, 82);
        lblTipo.Name = "lblTipo";
        lblTipo.Text = "Tipo";
        //
        // cmbTipo
        //
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.Location = new Point(15, 102);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.Size = new Size(240, 23);
        cmbTipo.TabIndex = 2;
        //
        // lblBairro
        //
        lblBairro.AutoSize = true;
        lblBairro.Location = new Point(15, 136);
        lblBairro.Name = "lblBairro";
        lblBairro.Text = "Bairro";
        //
        // txtBairro
        //
        txtBairro.Location = new Point(15, 156);
        txtBairro.Name = "txtBairro";
        txtBairro.Size = new Size(240, 23);
        txtBairro.TabIndex = 3;
        //
        // lblEndereco
        //
        lblEndereco.AutoSize = true;
        lblEndereco.Location = new Point(15, 190);
        lblEndereco.Name = "lblEndereco";
        lblEndereco.Text = "Endereço";
        //
        // txtEndereco
        //
        txtEndereco.Location = new Point(15, 210);
        txtEndereco.Name = "txtEndereco";
        txtEndereco.Size = new Size(240, 23);
        txtEndereco.TabIndex = 4;
        //
        // lblDescricao
        //
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new Point(15, 244);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Text = "Descrição";
        //
        // txtDescricao
        //
        txtDescricao.Location = new Point(15, 264);
        txtDescricao.Multiline = true;
        txtDescricao.Name = "txtDescricao";
        txtDescricao.ScrollBars = ScrollBars.Vertical;
        txtDescricao.Size = new Size(240, 90);
        txtDescricao.TabIndex = 5;
        //
        // btnCadastrar
        //
        btnCadastrar.Location = new Point(15, 368);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(240, 35);
        btnCadastrar.TabIndex = 6;
        btnCadastrar.Text = "Cadastrar";
        btnCadastrar.UseVisualStyleBackColor = true;
        btnCadastrar.Click += btnCadastrar_Click;
        //
        // dgvOcorrencias
        //
        dgvOcorrencias.AllowUserToAddRows = false;
        dgvOcorrencias.AllowUserToDeleteRows = false;
        dgvOcorrencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvOcorrencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOcorrencias.Location = new Point(295, 12);
        dgvOcorrencias.MultiSelect = false;
        dgvOcorrencias.Name = "dgvOcorrencias";
        dgvOcorrencias.ReadOnly = true;
        dgvOcorrencias.RowHeadersVisible = false;
        dgvOcorrencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOcorrencias.Size = new Size(593, 526);
        dgvOcorrencias.TabIndex = 7;
        //
        // FormPrincipal
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 550);
        Controls.Add(grpCadastro);
        Controls.Add(dgvOcorrencias);
        MinimumSize = new Size(800, 500);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ZelaBairro - Terminal da Subprefeitura";
        grpCadastro.ResumeLayout(false);
        grpCadastro.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOcorrencias).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpCadastro;
    private Label lblSolicitante;
    private TextBox txtSolicitante;
    private Label lblTipo;
    private ComboBox cmbTipo;
    private Label lblBairro;
    private TextBox txtBairro;
    private Label lblEndereco;
    private TextBox txtEndereco;
    private Label lblDescricao;
    private TextBox txtDescricao;
    private Button btnCadastrar;
    private DataGridView dgvOcorrencias;
}
