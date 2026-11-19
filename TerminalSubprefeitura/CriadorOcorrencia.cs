namespace TerminalSubprefeitura;

// Escolhe qual classe criar a partir do tipo. O retorno é sempre Ocorrencia,
// mas o objeto de verdade pode ser uma das classes filhas (polimorfismo).
// Usado no cadastro da tela e no carregamento do CSV.
public static class CriadorOcorrencia
{
    public static Ocorrencia Criar(int id, TipoOcorrencia tipo, string descricao, string bairro, string endereco, string solicitante)
    {
        switch (tipo)
        {
            case TipoOcorrencia.LixoIrregular:
            case TipoOcorrencia.LixeiraCheia:
                return new OcorrenciaLimpeza(id, tipo, descricao, bairro, endereco, solicitante);
            case TipoOcorrencia.PosteApagado:
                return new OcorrenciaIluminacao(id, descricao, bairro, endereco, solicitante);
            case TipoOcorrencia.Buraco:
                return new OcorrenciaVia(id, descricao, bairro, endereco, solicitante);
            default:
                return new Ocorrencia(id, tipo, descricao, bairro, endereco, solicitante);
        }
    }
}
