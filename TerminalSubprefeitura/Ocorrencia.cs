namespace TerminalSubprefeitura;

// Ocorrência recebida por telefone no terminal da subprefeitura.
// Os campos são privados e só mudam pelas properties, que validam o valor.
public class Ocorrencia
{
    private int _id;
    private string _descricao = "";
    private string _bairro = "";
    private string _endereco = "";
    private string _solicitante = "";

    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0)
                throw new ArgumentException("O Id precisa ser maior que zero.");
            _id = value;
        }
    }

    public TipoOcorrencia Tipo { get; set; }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = ValidarTexto(value, "Descrição", 10, 200);
    }

    public string Bairro
    {
        get => _bairro;
        set => _bairro = ValidarTexto(value, "Bairro", 2, 50);
    }

    public string Endereco
    {
        get => _endereco;
        set => _endereco = ValidarTexto(value, "Endereço", 5, 100);
    }

    public string Solicitante
    {
        get => _solicitante;
        set => _solicitante = ValidarTexto(value, "Solicitante", 3, 60);
    }

    // Só a própria classe muda o Status. De fora, use o método MudarStatus.
    public StatusOcorrencia Status { get; private set; }

    public Ocorrencia(int id, TipoOcorrencia tipo, string descricao, string bairro, string endereco, string solicitante)
    {
        // Passa pelas properties para que a validação valha também na criação.
        Id = id;
        Tipo = tipo;
        Descricao = descricao;
        Bairro = bairro;
        Endereco = endereco;
        Solicitante = solicitante;
        Status = StatusOcorrencia.Aberta;
    }

    public void MudarStatus(StatusOcorrencia novoStatus)
    {
        if (Status == StatusOcorrencia.Resolvida)
            throw new ArgumentException("Esta ocorrência já foi resolvida e não pode mudar de status.");
        Status = novoStatus;
    }

    // Regra comum dos campos de texto: obrigatório e com tamanho mínimo e máximo.
    // Devolve o texto sem espaços sobrando no começo e no fim.
    private static string ValidarTexto(string valor, string campo, int minimo, int maximo)
    {
        if (valor == null || valor.Trim().Length == 0)
            throw new ArgumentException($"O campo {campo} é obrigatório.");

        string texto = valor.Trim();

        if (texto.Length < minimo || texto.Length > maximo)
            throw new ArgumentException($"O campo {campo} deve ter entre {minimo} e {maximo} caracteres.");

        // O CSV usa ";" para separar colunas e uma linha por ocorrência,
        // então esses caracteres quebrariam o arquivo.
        foreach (char letra in texto)
        {
            if (letra == ';' || letra == '\n' || letra == '\r')
                throw new ArgumentException($"O campo {campo} não pode ter ponto e vírgula nem quebra de linha.");
        }

        return texto;
    }
}
