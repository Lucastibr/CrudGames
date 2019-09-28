# CrudGames

CRUD feito com sccaffolding em net core v2.2 e ef core v2.2, para fins de estudo.

Para testar aí na sua máquina, você precisa fazer os seguintes passos:::

Passo 1: Abra o appsettings.json e mude a connection string de acordo com a sua;
Passo 2: Crie um Banco de Dados chamado GamesDB;

Passo 2.5: Use o comando no console Update-Database que ele irá preencher o seu BD, fazendo isso,
se não houver erros pule para o passo 5; agora se houver algum erro pule pro passo 3.

Passo 3: Você precisará criar uma migração com EF Core, então abra o nugget console(Visual Studio > Ferramentas >
Gerenciador de Pacotes do Nugget > Console do Gerenciador de Pacotes) ou VSCODE(Aperte o ctrl + ") e digite o seguinte comando:
Add-Migration "Criacao"
-----
Passo 4: Terminado a criação, faça o comando Update-Database;
*Ele irá preencher o seu BD com as migrações setadas em GameController.cs*

Passo 5: Nisso, só apertar (ctrl + F5) pra abrir o projeto localhost,nisso coloque /Games no fim da url,(Isso no VS Studio), já no VS CODE, use no console dotnet restore e depois dotnet run.

Abraços;
