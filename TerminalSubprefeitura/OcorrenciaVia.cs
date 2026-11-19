namespace TerminalSubprefeitura;

// Buraco na rua. O tipo é sempre Buraco, então já vai fixo para a base.
public class OcorrenciaVia : Ocorrencia
{
    public OcorrenciaVia(int id, string descricao, string bairro, string endereco, string solicitante)
        : base(id, TipoOcorrencia.Buraco, descricao, bairro, endereco, solicitante)
    {
    }

    public override int PrazoDias => 10;

    public override string ToString()
    {
        return "[Via pública] " + base.ToString();
    }
}
