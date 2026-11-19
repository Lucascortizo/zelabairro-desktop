namespace TerminalSubprefeitura;

// Salva e carrega as ocorrências em um arquivo CSV, separado por ";".
// Primeira linha: cabeçalho. Depois, uma linha por ocorrência.
public static class ArquivoCsv
{
    private const string Cabecalho = "Id;Tipo;Descricao;Bairro;Endereco;Solicitante;Status";

    public static void Salvar(string caminho, List<Ocorrencia> ocorrencias)
    {
        List<string> linhas = new List<string>();
        linhas.Add(Cabecalho);

        foreach (Ocorrencia o in ocorrencias)
        {
            linhas.Add($"{o.Id};{o.Tipo};{o.Descricao};{o.Bairro};{o.Endereco};{o.Solicitante};{o.Status}");
        }

        File.WriteAllLines(caminho, linhas);
    }

    // Devolve as ocorrências lidas. Linhas com defeito são puladas e contadas em linhasIgnoradas.
    public static List<Ocorrencia> Carregar(string caminho, out int linhasIgnoradas)
    {
        List<Ocorrencia> ocorrencias = new List<Ocorrencia>();
        linhasIgnoradas = 0;

        // Na primeira vez que o programa roda, o arquivo ainda não existe.
        if (!File.Exists(caminho))
            return ocorrencias;

        string[] linhas = File.ReadAllLines(caminho);

        // Começa em 1 para pular o cabeçalho.
        for (int i = 1; i < linhas.Length; i++)
        {
            if (linhas[i].Trim().Length == 0)
                continue;

            string[] partes = linhas[i].Split(';');

            if (partes.Length != 7
                || !int.TryParse(partes[0], out int id)
                || !TentarLerTipo(partes[1], out TipoOcorrencia tipo)
                || !TentarLerStatus(partes[6], out StatusOcorrencia status))
            {
                linhasIgnoradas++;
                continue;
            }

            // As properties validam de novo os textos lidos do arquivo.
            try
            {
                Ocorrencia ocorrencia = new Ocorrencia(id, tipo, partes[2], partes[3], partes[4], partes[5]);
                ocorrencia.MudarStatus(status);
                ocorrencias.Add(ocorrencia);
            }
            catch (ArgumentException)
            {
                linhasIgnoradas++;
            }
        }

        return ocorrencias;
    }

    // Converte o texto do arquivo no enum. Funciona como o TryParse: devolve false se não reconhecer.
    private static bool TentarLerTipo(string texto, out TipoOcorrencia tipo)
    {
        tipo = TipoOcorrencia.Outro;

        switch (texto)
        {
            case "LixoIrregular":
                tipo = TipoOcorrencia.LixoIrregular;
                return true;
            case "LixeiraCheia":
                tipo = TipoOcorrencia.LixeiraCheia;
                return true;
            case "Buraco":
                tipo = TipoOcorrencia.Buraco;
                return true;
            case "PosteApagado":
                tipo = TipoOcorrencia.PosteApagado;
                return true;
            case "Outro":
                tipo = TipoOcorrencia.Outro;
                return true;
            default:
                return false;
        }
    }

    private static bool TentarLerStatus(string texto, out StatusOcorrencia status)
    {
        status = StatusOcorrencia.Aberta;

        switch (texto)
        {
            case "Aberta":
                status = StatusOcorrencia.Aberta;
                return true;
            case "EmAndamento":
                status = StatusOcorrencia.EmAndamento;
                return true;
            case "Resolvida":
                status = StatusOcorrencia.Resolvida;
                return true;
            default:
                return false;
        }
    }
}
