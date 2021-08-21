# Mu Online

Projeto criado com a finalidade de ajudar a comunidade com site e api para mu.

------------

## Funcionalidades

- #### Cadastro de conta
    Permite criar uma conta, após a criação é disparado um e-mail para o usuario aceitar o cadastro, após o aceite é criada a conta no jogo. 
    *Obrigatorio para logar no jogo. 

## Tecnologias usadas no projeto

### Front-end

- Angular 9
- RxJS
- Bootstrap 4.5

### Back-end

- .Net Core 3.1
- EntityFramework
- DDD
- UnitOfWork pattern
- Repository pattern
- Service pattern 
- Swagger
- Conteinerização
- SQL

## Features a serem implementadas
#### Front-end

- Gerenciar conta
- Hora atual servidor/usuario
- Gerenciar site visão adm / add noticias
- UX
- Componentização
- Responsividade

#### Back-end

- Gerenciar conta usuario
- Gerenciar site visão adm / add noticias

## Configurações para rodar o projeto na produção

- #### Back-end
    Alterar string de conexão para o banco de dados no arquivo appsettings.Production.json.
    <br />
    Alterar url base no arquivo appsettings.Production.json com o dominio de produção.
    <br />
    Alterar appsettings.json com os dados do e-mail do servidor, para disparar e-mail para novos cadastros.
- #### Front-end
    Alterar a url base da api dentro do arquivo environment, na raiz do client.
    <br />
    Alterar o link para download do jogo dentro do arquivo downloads.component.ts e download.component.ts
