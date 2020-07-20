# Teste de programação FIAP

Prova de desenvolvimento C#

Video de apresentação do projeto: https://youtu.be/8XefUGJcDoU

# Instalação

Como startar o projeto

### Requisitos

* [Node.js](https://nodejs.org/)
* [Angular CLI](https://cli.angular.io)
* [Dotnet Core](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

Antes de executar os scripts que estão na pasta principal, necessário trocar informação de banco no appsettings.json do projeto FIAP.ParceriaAPI.

Pode ser usado o DB direto do docker, ou algum outro DB, o script de criação do banco está disponivel também na pasta principal.

Para executar o projeto basta executar os scripts que estão na pasta principal.

Abra o Windows Powershell e execute os seguintes comandos:

```sh
$ .\configDbDocker.sh (OPCIONAL)
$ .\start.sh 
$ .\configAngular.sh
```

Caso Seja utilizado o DB com o DOCKER, para utilizar o banco na api, deve ser trocado a informaçõa no appsettings do projeto FIAP.ParceriaAPI e para conseguir o ip do driver do docker, basta executar ipconfig no powershell. (IP da placa virtual do docker geralmente é a iniciada com 172.18.*.*)
