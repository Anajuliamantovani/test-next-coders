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

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/e9a3c3d8-7eea-4073-b6b8-f6078934712a)

<h3>Utilização</h3>


<h4>Início</h4> 

Menu Principal

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/cb6315ee-b3a3-4771-be61-755d682197b3)


Opção 1. Adicionar tarefa

No menu principal, selecione a opção “Adicionar Tarefa”. Nele será solicitado que você insira o título da tarefa 

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/5b2f752d-3798-49a4-8cda-0e165e126b6a)

1.1 Prioridade

Logo em seguida sua prioridade entre baixa, média ou alta.

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/cd4b8e37-d1fc-4f14-b029-4c6a43451f36)


1.2 Data

Em seguida, você será solicitado a inserir a data e hora de entrega da tarefa. 
<br>Certifique-se de inserir uma data e hora válidas.

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/766adab9-30ca-4f6f-8df6-f29cc2518100)

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/0f8f1565-c83f-4bbf-babd-e29a6456b4d5)

Tarefa adicionada !


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/68fcb2b4-d5f5-4a12-9799-8c6bf0e133ca)

Opção 2. Listar tarefas

No menu principal, selecione a opção “Listar Tarefas”.
<br>Todas as tarefas registradas serão exibidas com seus respectivos detalhes
<br>incluindo título, prioridade, data de criação, data de entrega e status (concluída ou não concluída).



![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/24a1e114-5f62-4721-9891-95566d4af315)

Opção 3. Deletar tarefa

No menu principal, selecione a opção “Excluir Tarefa”.
<br>Será solicitado que você insira o número da tarefa que deseja excluir.
<br>A tarefa selecionada será removida permanentemente do sistema.



![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/a7ab4572-2c14-4448-8597-d682f168b95f)


Tarefa deletada


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/d85ab8d7-9045-4833-b099-8e0d91a5d0d3)

Opção 4. Alterar status

No menu principal, selecione a opção “Alterar Status da Tarefa”.
<br>Será solicitado que você insira o número da tarefa que deseja alterar.
<br>O status da tarefa será alterado entre concluída e não concluída.



![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/0942ecf3-68ad-4e2f-859a-a3898baa69ad)

Status alterado


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/06869228-c03a-4a54-b693-7782239668ad)


Opção 5. Editar tarefa

No menu principal, selecione a opção “Editar Tarefa”.
<br>Você será solicitado a inserir o número da tarefa que deseja editar.
<br>Siga as instruções que serão exibidas para inserir os novos detalhes da tarefa.


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/f542c6a0-8e0d-4d04-b1e4-ee398fc50d4e)

Nome 

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/2ed7fd23-9979-4bf5-a764-3632b81e61c3)

Prioridade

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/6718b108-30ac-4f63-bf76-1e84ac921ba7)

Data

Ao colocar "S" será solicitado que coloque uma nova data e hora

![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/a3b81f0d-ef22-45a8-b568-c78a8259580d)


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/d50328e6-b34f-412e-95b7-37306a6a55ff)


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/389e87dd-ddfb-461e-bbba-790bf97a53ca)

Tarefa editada


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/6e7b6bb0-6d20-4198-932e-e1039eb74eea)

Opção 6. Sair


![image](https://github.com/JhouZz22/Gerenciador-de-Tarefas-Pessoais/assets/151959498/19346dca-29bf-42f6-b1f5-2f7818a09599)


<h2>Problemas e Soluções</h2>
<p align="justify">Assim como qualquer projeto realizado, também enfrentamos desafios, mas com muito esforço conseguimos superá-los e realizar um projeto satisfatório que contribuiu para o nosso desenvolvimento acadêmico.  Durante o projeto o obstáculo que mais tivemos dificuldade foi fazer com que a data e a hora de entrega da tarefa funcionassem de maneira conjunta e correta, para que assim o sistema reconhecesse que precisavam ser posteriores a data e a hora atual da criação da tarefa. A maneira que encontramos para realizar essa correção foi realizar um ajuste na lógica de validação da função “adicionarTarefa”, dessa maneira facilitando e aprimorando a adição das tarefas. Apesar de termos atingido todos os  principais requisitos de nosso sistema, algumas funcionalidades ainda podem ser aprimoradas e adicionadas no futuro, como por exemplo adicionar um cadastro de usuário, melhorar a interface e funcionalidades adjacentes do sistema, para que dessa forma o projeto seja cada vez mais completo e funcional.</p>






















