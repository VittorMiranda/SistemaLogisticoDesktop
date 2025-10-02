# Sistema Logístico

## Descrição

O **Sistema Logístico** é uma aplicação desktop desenvolvida em C# (.NET 8) para gerenciamento de operações logísticas. O sistema permite o cadastro, consulta, edição e exclusão lógica de veículos, motoristas, rotas, preços de combustíveis e viagens. Seu objetivo é facilitar o controle e a organização das informações essenciais para empresas de transporte ou logística.

## Funcionalidades

- **Cadastro de Veículos:** Permite registrar veículos com modelo, placa, consumo médio e carga máxima.
- **Cadastro de Motoristas:** Gerencia motoristas com nome, CNH e telefone.
- **Cadastro de Rotas:** Armazena rotas com origem, destino e distância.
- **Cadastro de Preços de Combustível:** Registra preços de combustíveis por data.
- **Cadastro de Viagens:** Controla viagens, associando motorista, veículo, rota, datas de saída/chegada e situação.
- **Edição e Exclusão Lógica:** Atualize ou desative registros sem removê-los fisicamente do banco de dados.
- **Busca e Listagem:** Visualize listas de cada entidade e selecione itens para edição.

## Estrutura do Projeto

- **Sistema_Logistico/Entidades:** Classes de modelo (Veiculo, Motorista, Rota, PrecoCombustivel, Viagem).
- **Sistema_Logistico/Repositorios:** Repositórios para acesso ao banco de dados SQLite.
- **Sistema_Logistico/Utils:** Utilitários para manipulação do banco e validação de dados.
- **Sistema_Logistico/Database:** Arquivos do banco de dados e scripts de criação de tabelas.
- **Sistema_Logistico/Form1.cs:** Interface principal do sistema.

## Banco de Dados

O sistema utiliza o **SQLite** como banco de dados local, armazenado no arquivo `Logistica.db`. O script de criação das tabelas está em `schema.sql`, que é executado automaticamente na primeira inicialização do sistema, caso o banco ainda não exista.

### Principais tabelas:

- **Veiculo:** Armazena informações dos veículos (modelo, placa, consumo médio, carga máxima).
- **Motorista:** Guarda dados dos motoristas (nome, CNH, telefone).
- **Rota:** Contém rotas com origem, destino e distância.
- **PrecoCombustivel:** Registra preços de combustíveis e data da consulta.
- **Viagem:** Relaciona motorista, veículo, rota, datas e situação da viagem.

A maioria das tabelas possui um campo de controle lógico (ex: `Ativo`) para permitir exclusão lógica, mantendo o histórico dos registros.

## Requisitos

- .NET 8
- Visual Studio 2022 ou superior
- SQLite

## Como Executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Execute o projeto (F5). O banco de dados será criado automaticamente se não existir.
4. Utilize a interface para cadastrar e gerenciar os dados logísticos.

## Observações

- Os arquivos do banco de dados (`Logistica.db` e `schema.sql`) não são versionados (veja `.gitignore`).
- O sistema utiliza exclusão lógica para preservar o histórico dos registros.

## Licença

Este projeto é apenas para fins educacionais e internos.
