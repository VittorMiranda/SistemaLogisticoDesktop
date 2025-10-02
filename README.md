# Sistema Log�stico

## Descri��o

O **Sistema Log�stico** � uma aplica��o desktop desenvolvida em C# (.NET 8) para gerenciamento de opera��es log�sticas. O sistema permite o cadastro, consulta, edi��o e exclus�o l�gica de ve�culos, motoristas, rotas, pre�os de combust�veis e viagens. Seu objetivo � facilitar o controle e a organiza��o das informa��es essenciais para empresas de transporte ou log�stica.

## Funcionalidades

- **Cadastro de Ve�culos:** Permite registrar ve�culos com modelo, placa, consumo m�dio e carga m�xima.
- **Cadastro de Motoristas:** Gerencia motoristas com nome, CNH e telefone.
- **Cadastro de Rotas:** Armazena rotas com origem, destino e dist�ncia.
- **Cadastro de Pre�os de Combust�vel:** Registra pre�os de combust�veis por data.
- **Cadastro de Viagens:** Controla viagens, associando motorista, ve�culo, rota, datas de sa�da/chegada e situa��o.
- **Edi��o e Exclus�o L�gica:** Atualize ou desative registros sem remov�-los fisicamente do banco de dados.
- **Busca e Listagem:** Visualize listas de cada entidade e selecione itens para edi��o.

## Estrutura do Projeto

- **Sistema_Logistico/Entidades:** Classes de modelo (Veiculo, Motorista, Rota, PrecoCombustivel, Viagem).
- **Sistema_Logistico/Repositorios:** Reposit�rios para acesso ao banco de dados SQLite.
- **Sistema_Logistico/Utils:** Utilit�rios para manipula��o do banco e valida��o de dados.
- **Sistema_Logistico/Database:** Arquivos do banco de dados e scripts de cria��o de tabelas.
- **Sistema_Logistico/Form1.cs:** Interface principal do sistema.

## Banco de Dados

O sistema utiliza o **SQLite** como banco de dados local, armazenado no arquivo `Logistica.db`. O script de cria��o das tabelas est� em `schema.sql`, que � executado automaticamente na primeira inicializa��o do sistema, caso o banco ainda n�o exista.

### Principais tabelas:

- **Veiculo:** Armazena informa��es dos ve�culos (modelo, placa, consumo m�dio, carga m�xima).
- **Motorista:** Guarda dados dos motoristas (nome, CNH, telefone).
- **Rota:** Cont�m rotas com origem, destino e dist�ncia.
- **PrecoCombustivel:** Registra pre�os de combust�veis e data da consulta.
- **Viagem:** Relaciona motorista, ve�culo, rota, datas e situa��o da viagem.

A maioria das tabelas possui um campo de controle l�gico (ex: `Ativo`) para permitir exclus�o l�gica, mantendo o hist�rico dos registros.

## Requisitos

- .NET 8
- Visual Studio 2022 ou superior
- SQLite

## Como Executar

1. Clone o reposit�rio.
2. Abra o projeto no Visual Studio.
3. Execute o projeto (F5). O banco de dados ser� criado automaticamente se n�o existir.
4. Utilize a interface para cadastrar e gerenciar os dados log�sticos.

## Observa��es

- Os arquivos do banco de dados (`Logistica.db` e `schema.sql`) n�o s�o versionados (veja `.gitignore`).
- O sistema utiliza exclus�o l�gica para preservar o hist�rico dos registros.

## Licen�a

Este projeto � apenas para fins educacionais e internos.
