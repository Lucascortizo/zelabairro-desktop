# ZelaBairro - Terminal da Subprefeitura

Projeto de C# da Global Solution FIAP 2026.2 (CitizenTech). Ele faz parte do ZelaBairro. O repositório principal, com a API, o app, a IoT, a IA e o portal, está aqui: https://github.com/Lucascortizo/zelabairro

Autor: Lucas Cortizo, RM 559734. Engenharia de Software, 3º ano.

## O problema

No bairro, lixeiras e caçambas transbordam antes da coleta. Também aparecem lixo jogado na rua, buracos e postes apagados. O morador não tem um jeito simples de avisar e nem de acompanhar se o problema foi resolvido.

Muita gente ainda avisa a subprefeitura por telefone. O atendente precisa registrar essas ligações em um lugar organizado, mesmo quando o computador está sem internet.

## Quem é beneficiado

Eu fiz este programa para o atendente da subprefeitura. Ele recebe a ligação, cadastra a ocorrência e depois atualiza o status.

O morador também ganha, principalmente quem não usa aplicativo e prefere ligar. O morador que usei como referência é uma persona baseada em dados públicos do SP156 e do GeoSampa. Não é uma pessoa entrevistada.

## O que o programa faz

- Cadastra ocorrências recebidas por telefone: solicitante, tipo, bairro, endereço e descrição.
- Valida os dados e mostra o erro em uma caixa de mensagem quando algo está errado.
- Mostra as ocorrências em uma tabela.
- Filtra por bairro e por status.
- Muda o status da ocorrência selecionada (Aberta, EmAndamento, Resolvida). Uma ocorrência resolvida não muda mais.
- Salva tudo no arquivo ocorrencias.csv a cada mudança e carrega esse arquivo sozinho quando o programa abre.

O programa funciona offline e não se conecta com a API do ZelaBairro. Escolhi assim porque ainda não vi HttpClient nas aulas, e porque um terminal que funciona sem internet também ajuda em lugares com conexão ruim.

## Como rodar

Precisa de:

- Windows 10 ou 11
- SDK do .NET 10
- Visual Studio 2026 ou mais novo com a carga de trabalho "Desenvolvimento para desktop com .NET" (só para rodar pelo Visual Studio)

Pelo Visual Studio:

1. Clone o repositório ou extraia o ZIP.
2. Abra o arquivo TerminalSubprefeitura.slnx.
3. Aperte F5.

Pelo terminal, sem Visual Studio. Só precisa do SDK do .NET 10. Na pasta do repositório, rode:

    dotnet run --project TerminalSubprefeitura

O arquivo ocorrencias.csv é criado na pasta do executável (bin\Debug\net10.0-windows) depois do primeiro cadastro. Se ele não existir, o programa abre com a lista vazia.

## Tecnologias

- C# com .NET 10
- Windows Forms (TextBox, ComboBox, Button, GroupBox, DataGridView e MessageBox)
- Classes com encapsulamento e properties com validação
- enum, List<T>, switch, TryParse e try/catch
- Arquivo CSV com File.WriteAllLines e File.ReadAllLines
- Git e GitHub com versionamento semântico

## Versões

Cada versão foi feita em uma branch feature, com pull request e tag.

- v0.1.0: projeto Windows Forms e classe Ocorrencia com validação
- v0.2.0: cadastro com validação e tabela
- v0.3.0: filtro por bairro e por status e mudança de status
- v1.0.0: salvar e carregar em CSV e este README
