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
- Mostra o prazo para resolver cada ocorrência, que muda conforme o tipo.
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

## Programação orientada a objetos

### Encapsulamento

Na classe Ocorrencia (Ocorrencia.cs), os dados ficam em campos privados, como _descricao e _bairro. Quem está fora da classe só mexe neles pelas properties. Cada property confere o valor antes de guardar. Se a descrição tiver menos de 10 caracteres, por exemplo, ela lança um erro e a tela mostra a mensagem.

O status também é protegido. Ele tem private set e só muda pelo método MudarStatus, que não deixa mudar uma ocorrência que já foi resolvida.

### Herança

Ocorrencia é a classe base. Dela herdam três classes:

- OcorrenciaLimpeza, para lixo irregular e lixeira cheia
- OcorrenciaIluminacao, para poste apagado
- OcorrenciaVia, para buraco

As classes filhas recebem da base os campos, as properties, a validação e o MudarStatus, sem repetir código. O construtor de cada uma chama o construtor da base com : base(...). O tipo Outro usa a própria Ocorrencia.

### Polimorfismo

Cada tipo de ocorrência tem um prazo diferente para ser resolvido. Na base, a property PrazoDias é virtual e vale 7 dias. Cada classe filha faz override com o próprio prazo: 2 dias para limpeza, 5 para iluminação e 10 para buraco.

O ToString também é sobrescrito. A base monta um texto com os dados da ocorrência e cada filha coloca a sua área na frente, usando base.ToString().

O método Criar, da classe CriadorOcorrencia, usa um switch no tipo para decidir qual classe criar, mas sempre devolve uma Ocorrencia. Ele é usado no cadastro e quando o programa lê o CSV. Por isso o programa tem uma lista só, List<Ocorrencia>, com objetos das quatro classes misturados.

Quando a tabela mostra a coluna Prazo (dias), ou quando a mensagem de confirmação mostra o ToString, o C# chama a versão da classe de verdade de cada objeto. Assim cada linha mostra o seu prazo sem nenhum if na tela.

## Evidências

Os prints ficam na pasta evidencias/.

- 01-tela-principal.png: o programa aberto de novo, com as ocorrências carregadas do CSV e prazos diferentes para cada tipo.
- 02-cadastro-confirmado.png: mensagem de confirmação de um cadastro, com o texto do ToString da classe filha.
- 03-erro-validacao.png: mensagem de erro de validação ao cadastrar com uma descrição curta.
- 04-filtro.png: tabela filtrada por bairro e por status.
- 05-status-alterado.png: mensagem de confirmação da mudança de status.
- 06-resolvida-bloqueada.png: erro ao tentar mudar o status de uma ocorrência já resolvida.
- 07-arquivo-csv.png: o arquivo ocorrencias.csv aberto no Bloco de Notas.
- 08-codigo-heranca.png: a classe OcorrenciaLimpeza, com a herança, o construtor chamando a base e os override.
- 09-codigo-polimorfismo.png: o método Criar, que escolhe a classe pelo tipo.
- 10-pull-requests.png: os pull requests das versões no GitHub.
- 11-tags.png: as tags das versões no GitHub.

## Tecnologias

- C# com .NET 10
- Windows Forms (TextBox, ComboBox, Button, GroupBox, DataGridView e MessageBox)
- Programação orientada a objetos: classes, encapsulamento, herança e polimorfismo
- enum, List<T>, switch, TryParse e try/catch
- Arquivo CSV com File.WriteAllLines e File.ReadAllLines
- Git e GitHub com versionamento semântico

## Versões

Cada versão foi feita em uma branch feature, com pull request e tag.

- v0.1.0: projeto Windows Forms e classe Ocorrencia com validação
- v0.2.0: cadastro com validação e tabela
- v0.3.0: filtro por bairro e por status e mudança de status
- v1.0.0: salvar e carregar em CSV e este README
- v1.1.0: herança, polimorfismo, coluna de prazo e evidências
