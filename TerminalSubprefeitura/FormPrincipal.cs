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

    // Liga a lista ao DataGridView. O null antes força a grade a se redesenhar.
    private void AtualizarGrade()
    {
        dgvOcorrencias.DataSource = null;
        dgvOcorrencias.DataSource = _ocorrencias;
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
