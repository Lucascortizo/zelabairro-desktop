namespace TerminalSubprefeitura;

// Lixo irregular e lixeira cheia. Herda tudo de Ocorrencia e muda o prazo.
public class OcorrenciaLimpeza : Ocorrencia
{
    public OcorrenciaLimpeza(int id, TipoOcorrencia tipo, string descricao, string bairro, string endereco, string solicitante)
        : base(id, tipo, descricao, bairro, endereco, solicitante)
    {
        if (tipo != TipoOcorrencia.LixoIrregular && tipo != TipoOcorrencia.LixeiraCheia)
            throw new ArgumentException("Ocorrência de limpeza só pode ser LixoIrregular ou LixeiraCheia.");
    }

    public override int PrazoDias => 2;

    public override string ToString()
    {
        return "[Limpeza] " + base.ToString();
    }
}
