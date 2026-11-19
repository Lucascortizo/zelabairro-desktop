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
        grpStatus = new GroupBox();
        cmbNovoStatus = new ComboBox();
        btnMudarStatus = new Button();
        grpFiltros = new GroupBox();
        lblFiltroBairro = new Label();
        txtFiltroBairro = new TextBox();
        lblFiltroStatus = new Label();
        cmbFiltroStatus = new ComboBox();
        btnFiltrar = new Button();
        btnLimparFiltro = new Button();
        dgvOcorrencias = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colTipo = new DataGridViewTextBoxColumn();
        colSolicitante = new DataGridViewTextBoxColumn();
        colBairro = new DataGridViewTextBoxColumn();
        colEndereco = new DataGridViewTextBoxColumn();
        colDescricao = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        colPrazo = new DataGridViewTextBoxColumn();
        grpCadastro.SuspendLayout();
        grpStatus.SuspendLayout();
        grpFiltros.SuspendLayout();
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
        // grpStatus
        //
        grpStatus.Controls.Add(cmbNovoStatus);
        grpStatus.Controls.Add(btnMudarStatus);
        grpStatus.Location = new Point(12, 440);
        grpStatus.Name = "grpStatus";
        grpStatus.Size = new Size(270, 105);
        grpStatus.TabIndex = 1;
        grpStatus.TabStop = false;
        grpStatus.Text = "Mudar status da ocorrência selecionada";
        //
        // cmbNovoStatus
        //
        cmbNovoStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbNovoStatus.Location = new Point(15, 28);
        cmbNovoStatus.Name = "cmbNovoStatus";
        cmbNovoStatus.Size = new Size(240, 23);
        cmbNovoStatus.TabIndex = 0;
        //
        // btnMudarStatus
        //
        btnMudarStatus.Location = new Point(15, 60);
        btnMudarStatus.Name = "btnMudarStatus";
        btnMudarStatus.Size = new Size(240, 32);
        btnMudarStatus.TabIndex = 1;
        btnMudarStatus.Text = "Mudar status";
        btnMudarStatus.UseVisualStyleBackColor = true;
        btnMudarStatus.Click += btnMudarStatus_Click;
        //
        // grpFiltros
        //
        grpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpFiltros.Controls.Add(lblFiltroBairro);
        grpFiltros.Controls.Add(txtFiltroBairro);
        grpFiltros.Controls.Add(lblFiltroStatus);
        grpFiltros.Controls.Add(cmbFiltroStatus);
        grpFiltros.Controls.Add(btnFiltrar);
        grpFiltros.Controls.Add(btnLimparFiltro);
        grpFiltros.Location = new Point(295, 12);
        grpFiltros.Name = "grpFiltros";
        grpFiltros.Size = new Size(693, 65);
        grpFiltros.TabIndex = 2;
        grpFiltros.TabStop = false;
        grpFiltros.Text = "Filtros";
        //
        // lblFiltroBairro
        //
        lblFiltroBairro.AutoSize = true;
        lblFiltroBairro.Location = new Point(15, 29);
        lblFiltroBairro.Name = "lblFiltroBairro";
        lblFiltroBairro.Text = "Bairro:";
        //
        // txtFiltroBairro
        //
        txtFiltroBairro.Location = new Point(70, 25);
        txtFiltroBairro.Name = "txtFiltroBairro";
        txtFiltroBairro.Size = new Size(180, 23);
        txtFiltroBairro.TabIndex = 0;
        //
        // lblFiltroStatus
        //
        lblFiltroStatus.AutoSize = true;
        lblFiltroStatus.Location = new Point(270, 29);
        lblFiltroStatus.Name = "lblFiltroStatus";
        lblFiltroStatus.Text = "Status:";
        //
        // cmbFiltroStatus
        //
        cmbFiltroStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFiltroStatus.Location = new Point(325, 25);
        cmbFiltroStatus.Name = "cmbFiltroStatus";
        cmbFiltroStatus.Size = new Size(150, 23);
        cmbFiltroStatus.TabIndex = 1;
        //
        // btnFiltrar
        //
        btnFiltrar.Location = new Point(490, 23);
        btnFiltrar.Name = "btnFiltrar";
        btnFiltrar.Size = new Size(90, 27);
        btnFiltrar.TabIndex = 2;
        btnFiltrar.Text = "Filtrar";
        btnFiltrar.UseVisualStyleBackColor = true;
        btnFiltrar.Click += btnFiltrar_Click;
        //
        // btnLimparFiltro
        //
        btnLimparFiltro.Location = new Point(590, 23);
        btnLimparFiltro.Name = "btnLimparFiltro";
        btnLimparFiltro.Size = new Size(90, 27);
        btnLimparFiltro.TabIndex = 3;
        btnLimparFiltro.Text = "Limpar";
        btnLimparFiltro.UseVisualStyleBackColor = true;
        btnLimparFiltro.Click += btnLimparFiltro_Click;
        //
        // dgvOcorrencias
        //
        dgvOcorrencias.AllowUserToAddRows = false;
        dgvOcorrencias.AllowUserToDeleteRows = false;
        dgvOcorrencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvOcorrencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOcorrencias.Columns.AddRange(new DataGridViewColumn[] { colId, colTipo, colSolicitante, colBairro, colEndereco, colDescricao, colStatus, colPrazo });
        dgvOcorrencias.Location = new Point(295, 85);
        dgvOcorrencias.MultiSelect = false;
        dgvOcorrencias.Name = "dgvOcorrencias";
        dgvOcorrencias.ReadOnly = true;
        dgvOcorrencias.RowHeadersVisible = false;
        dgvOcorrencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOcorrencias.Size = new Size(693, 460);
        dgvOcorrencias.TabIndex = 3;
        //
        // colId
        //
        colId.DataPropertyName = "Id";
        colId.FillWeight = 30F;
        colId.HeaderText = "Id";
        colId.Name = "colId";
        colId.ReadOnly = true;
        //
        // colTipo
        //
        colTipo.DataPropertyName = "Tipo";
        colTipo.FillWeight = 80F;
        colTipo.HeaderText = "Tipo";
        colTipo.Name = "colTipo";
        colTipo.ReadOnly = true;
        //
        // colSolicitante
        //
        colSolicitante.DataPropertyName = "Solicitante";
        colSolicitante.FillWeight = 80F;
        colSolicitante.HeaderText = "Solicitante";
        colSolicitante.Name = "colSolicitante";
        colSolicitante.ReadOnly = true;
        //
        // colBairro
        //
        colBairro.DataPropertyName = "Bairro";
        colBairro.FillWeight = 70F;
        colBairro.HeaderText = "Bairro";
        colBairro.Name = "colBairro";
        colBairro.ReadOnly = true;
        //
        // colEndereco
        //
        colEndereco.DataPropertyName = "Endereco";
        colEndereco.HeaderText = "Endereço";
        colEndereco.Name = "colEndereco";
        colEndereco.ReadOnly = true;
        //
        // colDescricao
        //
        colDescricao.DataPropertyName = "Descricao";
        colDescricao.FillWeight = 130F;
        colDescricao.HeaderText = "Descrição";
        colDescricao.Name = "colDescricao";
        colDescricao.ReadOnly = true;
        //
        // colStatus
        //
        colStatus.DataPropertyName = "Status";
        colStatus.FillWeight = 70F;
        colStatus.HeaderText = "Status";
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        //
        // colPrazo
        //
        colPrazo.DataPropertyName = "PrazoDias";
        colPrazo.FillWeight = 50F;
        colPrazo.HeaderText = "Prazo (dias)";
        colPrazo.Name = "colPrazo";
        colPrazo.ReadOnly = true;
        //
        // FormPrincipal
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 560);
        Controls.Add(grpCadastro);
        Controls.Add(grpStatus);
        Controls.Add(grpFiltros);
        Controls.Add(dgvOcorrencias);
        MinimumSize = new Size(1016, 599);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ZelaBairro - Terminal da Subprefeitura";
        grpCadastro.ResumeLayout(false);
        grpCadastro.PerformLayout();
        grpStatus.ResumeLayout(false);
        grpFiltros.ResumeLayout(false);
        grpFiltros.PerformLayout();
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
    private GroupBox grpStatus;
    private ComboBox cmbNovoStatus;
    private Button btnMudarStatus;
    private GroupBox grpFiltros;
    private Label lblFiltroBairro;
    private TextBox txtFiltroBairro;
    private Label lblFiltroStatus;
    private ComboBox cmbFiltroStatus;
    private Button btnFiltrar;
    private Button btnLimparFiltro;
    private DataGridView dgvOcorrencias;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colTipo;
    private DataGridViewTextBoxColumn colSolicitante;
    private DataGridViewTextBoxColumn colBairro;
    private DataGridViewTextBoxColumn colEndereco;
    private DataGridViewTextBoxColumn colDescricao;
    private DataGridViewTextBoxColumn colStatus;
    private DataGridViewTextBoxColumn colPrazo;
}
