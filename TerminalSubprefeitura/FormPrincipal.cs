namespace TerminalSubprefeitura;

public partial class FormPrincipal : Form
{
    // Lista com todas as ocorrências cadastradas enquanto o programa está aberto.
    private List<Ocorrencia> _ocorrencias = new List<Ocorrencia>();

    // Próximo Id a ser usado. Começa em 1 e sobe a cada cadastro.
    private int _proximoId = 1;

    public FormPrincipal()
    {
        InitializeComponent();

        cmbTipo.Items.Add(TipoOcorrencia.LixoIrregular);
        cmbTipo.Items.Add(TipoOcorrencia.LixeiraCheia);
        cmbTipo.Items.Add(TipoOcorrencia.Buraco);
        cmbTipo.Items.Add(TipoOcorrencia.PosteApagado);
        cmbTipo.Items.Add(TipoOcorrencia.Outro);
        cmbTipo.SelectedIndex = 0;

        // No filtro, a primeira opção é "Todos" (índice 0) e depois vêm os status.
        cmbFiltroStatus.Items.Add("Todos");
        cmbFiltroStatus.Items.Add(StatusOcorrencia.Aberta);
        cmbFiltroStatus.Items.Add(StatusOcorrencia.EmAndamento);
        cmbFiltroStatus.Items.Add(StatusOcorrencia.Resolvida);
        cmbFiltroStatus.SelectedIndex = 0;

        cmbNovoStatus.Items.Add(StatusOcorrencia.Aberta);
        cmbNovoStatus.Items.Add(StatusOcorrencia.EmAndamento);
        cmbNovoStatus.Items.Add(StatusOcorrencia.Resolvida);
        cmbNovoStatus.SelectedIndex = 1;

        // As colunas estão declaradas no designer, com os cabeçalhos com acento.
        // Assim a grade não cria colunas novas sozinha a partir das properties.
        dgvOcorrencias.AutoGenerateColumns = false;

        AtualizarGrade();
    }

    private void btnCadastrar_Click(object? sender, EventArgs e)
    {
        // try tenta executar o bloco; se uma property lançar ArgumentException,
        // o catch recebe o erro e mostra a mensagem dele no MessageBox.
        try
        {
            TipoOcorrencia tipo = (TipoOcorrencia)cmbTipo.SelectedItem!;

            Ocorrencia nova = new Ocorrencia(_proximoId, tipo, txtDescricao.Text,
                txtBairro.Text, txtEndereco.Text, txtSolicitante.Text);

            _ocorrencias.Add(nova);
            _proximoId++;

            AtualizarGrade();
            LimparFormulario();
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(erro.Message, "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnFiltrar_Click(object? sender, EventArgs e)
    {
        AtualizarGrade();
    }

    private void btnLimparFiltro_Click(object? sender, EventArgs e)
    {
        txtFiltroBairro.Text = "";
        cmbFiltroStatus.SelectedIndex = 0;
        AtualizarGrade();
    }

    private void btnMudarStatus_Click(object? sender, EventArgs e)
    {
        DataGridViewRow? linha = dgvOcorrencias.CurrentRow;
        if (linha == null)
        {
            MessageBox.Show("Selecione uma ocorrência na tabela.", "Nenhuma ocorrência selecionada",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // DataBoundItem é o objeto da lista que está por trás da linha da tabela.
        Ocorrencia selecionada = (Ocorrencia)linha.DataBoundItem!;
        StatusOcorrencia novoStatus = (StatusOcorrencia)cmbNovoStatus.SelectedItem!;

        try
        {
            selecionada.MudarStatus(novoStatus);
            AtualizarGrade();
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(erro.Message, "Não foi possível mudar o status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Monta uma lista nova só com as ocorrências que passam nos filtros da tela.
    private List<Ocorrencia> FiltrarOcorrencias()
    {
        List<Ocorrencia> resultado = new List<Ocorrencia>();
        string bairroFiltro = txtFiltroBairro.Text.Trim().ToUpper();

        foreach (Ocorrencia ocorrencia in _ocorrencias)
        {
            // Bairro vazio no filtro = não filtra por bairro. ToUpper ignora maiúsculas e minúsculas.
            bool passaBairro = bairroFiltro.Length == 0 || ocorrencia.Bairro.ToUpper() == bairroFiltro;

            // Índice 0 = "Todos". Senão, compara com o status escolhido.
            bool passaStatus = cmbFiltroStatus.SelectedIndex == 0
                || ocorrencia.Status == (StatusOcorrencia)cmbFiltroStatus.SelectedItem!;

            if (passaBairro && passaStatus)
                resultado.Add(ocorrencia);
        }

        return resultado;
    }

    // Mostra na grade a lista filtrada. O null antes força a grade a se redesenhar.
    private void AtualizarGrade()
    {
        dgvOcorrencias.DataSource = null;
        dgvOcorrencias.DataSource = FiltrarOcorrencias();
    }

    private void LimparFormulario()
    {
        txtSolicitante.Text = "";
        txtBairro.Text = "";
        txtEndereco.Text = "";
        txtDescricao.Text = "";
        cmbTipo.SelectedIndex = 0;
        txtSolicitante.Focus();
    }
}
