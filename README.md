# <h1 align="center">Gerenciador de Tarefas 🗃
<p align="center"> O Gerenciado de Tarefas é uma aplicação desenvolvida em ASP.NET Core com o intuito de organizar as tarefas pessoais do nosso dia a dia.
<h2>Guia de usuário</h2>
<h3>Instalação</h3>

Abra o repositorio - [Gerenciador de Tarefas](https://github.com/Anajuliamantovani/test-next-coders.git)

Baixe os 3 arquivos : 

* **.NET 8**

* **MySQL**

* **Visual Studio/VSCode**

<h2>Guia de usuário</h2>

* **Clone o Repositório usando o comando abaixo**

  ```bash
   git clone https://github.com/Anajuliamantovani/test-next-coders.git
   cd test-next-coders

* **Banco de dados MySQL**

  Crie um Banco de dados MySQL e configure a conexão no arquivo `appsettings.json`:

  ```json
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=todo_list;User=root;Password=sua-senha;"
    }
  
<h2>Executando a API</h2>

1. Certifique-se de que você está na pasta onde salvou/clonou o repositório
2. Abra o powershell e aplique o comando
   ```powershell
   dotnet watch
   ```
   
<h2>Testando</h2>

Logo após o comando dotnet watch, essa imagem aparecerá

![image](https://github.com/user-attachments/assets/cc32ee78-3e53-48fa-8448-68f9fad39df5)

**Na sessão de Users você deverá primeiro criar um novo usuário, adicionando o nome e o e-mail**

![image](https://github.com/user-attachments/assets/8e0a8fc0-5a12-4a6d-93fb-93badb87c70b)

**Após isso, ele irá gerar um Id, e com esse Id você irá usar para adicionar uma tarefa atrelada ao usuário criado.**























