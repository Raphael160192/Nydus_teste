# Readme - Sistema de Cadastro de Colaboradores

Este é um projeto de exemplo que demonstra como utilizar o ASP.NET Core, Entity Framework, SQLite e Migration para criar um sistema de cadastro de colaboradores. O sistema permite cadastrar, atualizar, visualizar e excluir informações sobre colaboradores.

## Requisitos

Antes de rodar o projeto, certifique-se de ter os seguintes requisitos instalados:

- .NET Core SDK (versão 3.1 ou superior)
- Visual Studio ou algum editor de código de sua preferência

## Configuração do Banco de Dados

O projeto utiliza o banco de dados SQLite para persistir os dados dos colaboradores. O Entity Framework é utilizado para se comunicar com o banco de dados.

Para configurar o banco de dados SQLite, siga as etapas abaixo:

1. Abra o terminal (ou prompt de comando) na pasta raiz do projeto.
2. Navegue até a pasta raiz do seu projeto.
3. Execute o seguinte comando para adicionar o pacote do SQLite ao projeto:

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

Isso instalará o provedor do SQLite para o Entity Framework Core.

```
dotnet tool install --global dotnet-ef
```

4. Esse comando criará uma migração inicial com base nas classes/modelos definidas no projeto:

```
dotnet ef migrations add InitialMigration
```

5. Execute o seguinte comando para aplicar a migração e criar o banco de dados:

```
dotnet ef database update
```

Após a execução do comando, o banco de dados SQLite será criado com as tabelas necessárias para o funcionamento do sistema.

## Executando o Projeto

Após configurar o banco de dados e as migrações, você pode executar o projeto. 

1. Abra o terminal (ou prompt de comando) na pasta raiz do projeto.
2. Execute o seguinte comando para iniciar o servidor:

```
dotnet run --project CadastroFuncionários.csproj
```

3. O servidor será iniciado e você poderá acessar a aplicação no seu navegador através do endereço `https://localhost:44329`.

## Funcionalidades e Características

O sistema de cadastro de colaboradores possui as seguintes funcionalidades e características:

- Permite cadastrar, atualizar, visualizar e excluir colaboradores.
- Todos os campos são obrigatórios, exceto a data de demissão do colaborador.
- O campo matrícula do colaborador deve respeitar o formato CCNNNN, onde C são caracteres (sempre em caixa alta) e N são números. Exemplo: AA1234, AB9876.
- A data de demissão não pode ser menor ou igual à data de admissão.
- Não é permitido alterar dados de colaboradores demitidos.

Certifique-se de seguir as regras acima ao interagir com o sistema.

Espero que este readme tenha fornecido as informações necessárias para rodar o projeto e entender suas funcionalidades. Em caso de dúvidas, não hesite em entrar em contato.