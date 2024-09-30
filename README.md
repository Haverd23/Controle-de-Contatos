## Descrição do Projeto

### Controle de Contatos

Este projeto é um sistema desenvolvido em ASP.NET MVC que implementa um CRUD (Create, Read, Update, Delete).

#### Objetivo

O objetivo do sistema é permitir que usuários realizem operações de cadastro e gerenciamento de informações, com foco em segurança e acessibilidade. O sistema oferece controle de acesso, permitindo que apenas usuários logados visualizem determinadas páginas.

#### Principais Funcionalidades

- **CRUD Completo**: Criação, leitura, atualização e exclusão de registros de usuários.
- **Controle de Acesso**: Apenas usuários logados têm acesso às views de Estado e Home.
- **Administração**: Usuários administradores têm acesso a uma view exclusiva de administração, enquanto usuários padrão são redirecionados para uma view de acesso restrito se tentarem acessar esta área.
- **Criptografia de Senha**: As senhas dos usuários são armazenadas de forma segura utilizando hash.
- **Data de Cadastro e Atualização**: Informações de data de criação e atualização dos usuários são armazenadas.
- **Pesquisa e Filtro**: A funcionalidade de pesquisa e filtro é implementada usando jQuery DataTable.

### Tela de Login

Abaixo está a tela de login do sistema, onde os usuários inserem suas credenciais para acessar as funcionalidades do sistema.

![Tela de Login](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/Login.png?raw=true)

### Tela Principal

Na tela principal, os usuários podem visualizar todos os registros cadastrados, assim como realizar operações de edição e exclusão. Além disso, é possível adicionar novos usuários ao sistema.

![Tela Principal](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/Usuarios.png?raw=true)  

#### Funcionalidades da Tela Principal

- **Visualização de Usuários**: Todos os usuários cadastrados são listados em uma tabela.
- **Edição de Usuários**: Opção para editar informações de um usuário existente.
- **Exclusão de Usuários**: Opção para remover um usuário do sistema.
- **Adicionar Novo Usuário**: Um botão para adicionar um novo usuário.
- **Pesquisa e Filtro**: A tabela utiliza jQuery DataTable para permitir busca e filtragem de registros de forma eficiente.

### Armazenamento de Senha

As senhas dos usuários são armazenadas de maneira segura utilizando criptografia hash. Isso garante que, mesmo em caso de acesso não autorizado ao banco de dados, as senhas dos usuários permaneçam protegidas.

#### Criptografia de Senha

- **Método de Criptografia**: As senhas são convertidas em um hash antes de serem armazenadas. O método utilizado é baseado em algoritmos de hash seguros, o que significa que não é possível reverter a senha original a partir do hash.


#### Validação de Senha

Quando um usuário tenta fazer login, a senha fornecida é convertida para hash e comparada com a versão armazenada no banco de dados. Se os hashes coincidirem, o acesso é concedido.

### Tela de Edição de Usuário

A tela de edição permite que os usuários façam alterações nas informações de um usuário existente. Essa funcionalidade é essencial para manter os dados atualizados e gerenciar as informações de forma eficaz.

![Tela de Edição](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/Editar.png?raw=true)  

#### Funcionalidades da Tela de Edição

- **Formulário de Edição**: Campos para editar informações como nome, idade, estado, cidade e perfil.
- **Validação de Dados**: Validações são aplicadas para garantir que os campos obrigatórios sejam preenchidos corretamente.
- **Atualização de Dados**: Após a edição, as informações são atualizadas no banco de dados.
- **Mensagens de Sucesso ou Erro**: O usuário recebe feedback sobre a operação realizada, indicando se a atualização foi bem-sucedida ou se houve algum erro.

- ### Tela de Exclusão de Usuário

A tela de exclusão permite que os usuários removam um registro de usuário do sistema. Essa funcionalidade é importante para manter o banco de dados limpo e organizado.

![Tela de Exclusão](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/Apagar.png?raw=true)  
#### Funcionalidades da Tela de Exclusão

- **Confirmação de Exclusão**: Ao tentar excluir um usuário, o sistema solicita uma confirmação para evitar exclusões acidentais.
- **Feedback ao Usuário**: Após a exclusão, o usuário recebe uma mensagem informando se a operação foi bem-sucedida ou se houve um erro.
- **Redirecionamento**: Após a exclusão, o usuário é redirecionado para a tela principal, onde pode ver a lista atualizada de usuários.

- ### Tela de Administração

A tela de administração é acessível apenas para usuários com perfil de administrador.

![Tela de Administração](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/ViewAdmin.png?raw=true)  

#### Funcionalidades da Tela de Administração

- **Gerenciamento de Usuários**: Administradores podem visualizar, editar e excluir usuários.
- **Controle de Acesso**: Apenas usuários com o perfil de administrador podem acessar esta tela. Usuários padrão são redirecionados para uma página de acesso restrito se tentarem acessar.

### Menu do Usuário Padrão

O menu do usuário padrão é simplificado, apresentando apenas as opções necessárias para a interação com o sistema. Ao contrário do menu do administrador, que inclui uma opção específica para acessar a área de administração, o menu do usuário padrão não possui essa opção.

![Menu do Usuário Padrão](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/MenuPadrao.png?raw=true)  

#### Funcionalidades do Menu do Usuário Padrão

- **Acesso às Funcionalidades Principais**: Os usuários padrões têm acesso a funcionalidades como visualizar, editar e adicionar usuários.
- **Ausência de Opção de Administração**: A opção para acessar a tela de administração não está disponível, garantindo que apenas usuários autorizados possam ver essa área.
- **Interface Intuitiva**: O menu é projetado para ser simples e fácil de navegar, proporcionando uma experiência amigável para o usuário.

- ### View Restrita

A View Restrita é exibida quando um usuário padrão tenta acessar uma área do sistema para a qual não possui permissão, como a tela de administração. Esta página informa ao usuário que ele não tem autorização para acessar o conteúdo.

![View Restrita](https://github.com/Haverd23/Controle-de-Contatos/blob/main/Prints/Restrito.png?raw=true) 

#### Mensagem de Acesso Negado

- **Mensagem de Aviso**: A página exibe uma mensagem clara informando que o usuário não tem permissão para acessar aquela área.
- **Redirecionamento**: Um link é fornecido para redirecionar o usuário de volta ao menu principal, facilitando a navegação.





