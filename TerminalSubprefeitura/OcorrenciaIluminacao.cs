namespace TerminalSubprefeitura;

// Poste apagado. O tipo é sempre PosteApagado, então já vai fixo para a base.
public class OcorrenciaIluminacao : Ocorrencia
{
    public OcorrenciaIluminacao(int id, string descricao, string bairro, string endereco, string solicitante)
        : base(id, TipoOcorrencia.PosteApagado, descricao, bairro, endereco, solicitante)
    {
    }

    public override int PrazoDias => 5;

    public override string ToString()
    {
        return "[Iluminação] " + base.ToString();
    }
}
